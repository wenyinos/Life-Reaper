namespace Life_Reaper
{
    public partial class Form1 : Form
    {
        private TimeSpan timeLeft;
        private Point mouseOffset;
        private int secondsElapsed;
        private bool isEmphasized;
        private Point originalLocation;
        private bool isDragging;
        private System.Windows.Forms.Timer? emphasizeResetTimer;
        private Font? countdownNormalFont;
        private Font? countdownEmphasizeFont;
        private CancellationTokenSource? shakeCts;

        public Form1()
        {
            InitializeComponent();
            timeLeft = TimeSpan.FromMinutes(9).Add(TimeSpan.FromSeconds(59));
            secondsElapsed = 0;
            isEmphasized = false;
            UpdateCountdownDisplay();

            // Drag only from title bar (prevents accidental jumps when dragging elsewhere).
            panelTitleBar.MouseMove += PanelTitleBar_MouseMove;
            panelTitleBar.MouseUp += PanelTitleBar_MouseUp;
            lblTitle.MouseDown += PanelTitleBar_MouseDown;
            lblTitle.MouseMove += PanelTitleBar_MouseMove;
            lblTitle.MouseUp += PanelTitleBar_MouseUp;

            // Reuse resources instead of allocating on every emphasize tick.
            countdownNormalFont = new Font("Consolas", 32F, FontStyle.Bold, GraphicsUnit.Point);
            countdownEmphasizeFont = new Font("Consolas", 42F, FontStyle.Bold, GraphicsUnit.Point);
            emphasizeResetTimer = new System.Windows.Forms.Timer { Interval = 1500 };
            emphasizeResetTimer.Tick += EmphasizeResetTimer_Tick;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            // Location is finalized after the form is shown (StartPosition=CenterScreen).
            originalLocation = Location;
        }

        private void TimerCountdown_Tick(object? sender, EventArgs e)
        {
            if (timeLeft.TotalSeconds > 0)
            {
                timeLeft = timeLeft - TimeSpan.FromSeconds(1);
                secondsElapsed++;
                UpdateCountdownDisplay();

                if (secondsElapsed % 59 == 0 && !isEmphasized)
                {
                    EmphasizeCountdown();
                }
            }
            else
            {
                timerCountdown.Stop();
                lblCountdown.Text = "00:00:00";
                CustomMessageBox.Show(this, "时间已到！你的生命已贡献给长者。", "拖出去续了");
            }
        }

        private void EmphasizeCountdown()
        {
            isEmphasized = true;
            if (countdownEmphasizeFont != null)
            {
                lblCountdown.Font = countdownEmphasizeFont;
            }
            lblCountdown.ForeColor = Color.FromArgb(255, 0, 0);
            ShakeWindow();

            emphasizeResetTimer?.Stop();
            emphasizeResetTimer?.Start();
        }

        private async void ShakeWindow()
        {
            int shakeCount = 10;
            int shakeDistance = 15;
            int delay = 50;

            shakeCts?.Cancel();
            shakeCts?.Dispose();
            shakeCts = new CancellationTokenSource();
            CancellationToken token = shakeCts.Token;

            Point baseLocation = Location;
            originalLocation = baseLocation;

            try
            {
                for (int i = 0; i < shakeCount; i++)
                {
                    token.ThrowIfCancellationRequested();
                    int offsetX = (i % 2 == 0) ? shakeDistance : -shakeDistance;
                    Location = new Point(baseLocation.X + offsetX, baseLocation.Y);
                    await Task.Delay(delay, token);
                }
            }
            catch (OperationCanceledException)
            {
                // Ignore: a newer shake (or drag) replaced this one.
            }
            finally
            {
                // If the user is dragging, don't fight their input.
                if (!isDragging)
                {
                    Location = baseLocation;
                }
            }
        }

        private void UpdateCountdownDisplay()
        {
            string text = timeLeft.ToString(@"hh\:mm\:ss");
            lblCountdown.Text = text;
            lblTimer.Text = $"你的寿命剩余时间：{text}";
        }

        private void BtnDecrypt_Click(object? sender, EventArgs e)
        {
            CustomMessageBox.Show(this, "没有背诵三个代表。请先背诵一遍。", "续命失败");
        }

        private void BtnPay_Click(object? sender, EventArgs e)
        {
            CustomMessageBox.Show(this, "请问你是否确认续命？\n确认后，点击\"检查续命\"进行验证。", "续命说明");
        }

        private void BtnCheckPayment_Click(object? sender, EventArgs e)
        {
            CustomMessageBox.Show(this, "你已成功续命。", "+1s");
        }

        private void BtnMinimize_Click(object? sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnClose_Click(object? sender, EventArgs e)
        {
            ShowCloseWarning();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            ShowCloseWarning();
        }

        private void ShowCloseWarning()
        {
            WarningForm warning = new WarningForm();
            warning.ShowDialog(this);
        }

        private void PanelTitleBar_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            isDragging = true;
            // Offset from form origin to mouse pointer in screen coordinates.
            Point mousePos = Control.MousePosition;
            mouseOffset = new Point(mousePos.X - Location.X, mousePos.Y - Location.Y);
            shakeCts?.Cancel(); // stop shaking while the user drags
        }

        private void PanelTitleBar_MouseMove(object? sender, MouseEventArgs e)
        {
            if (!isDragging || e.Button != MouseButtons.Left)
            {
                return;
            }

            Point mousePos = Control.MousePosition;
            Location = new Point(mousePos.X - mouseOffset.X, mousePos.Y - mouseOffset.Y);
            originalLocation = Location;
        }

        private void PanelTitleBar_MouseUp(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void EmphasizeResetTimer_Tick(object? sender, EventArgs e)
        {
            emphasizeResetTimer?.Stop();

            if (countdownNormalFont != null)
            {
                lblCountdown.Font = countdownNormalFont;
            }

            lblCountdown.ForeColor = Color.FromArgb(192, 0, 0);
            if (!isDragging)
            {
                Location = originalLocation;
            }
            isEmphasized = false;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            emphasizeResetTimer?.Stop();
            emphasizeResetTimer?.Dispose();
            shakeCts?.Cancel();
            shakeCts?.Dispose();
            countdownNormalFont?.Dispose();
            countdownEmphasizeFont?.Dispose();
            base.OnFormClosed(e);
        }
    }
}
