namespace Life_Reaper
{
    public partial class Form1 : Form
    {
        private TimeSpan timeLeft;
        private Point mouseOffset;
        private int secondsElapsed;
        private bool isEmphasized;
        private Point originalLocation;

        public Form1()
        {
            InitializeComponent();
            timeLeft = TimeSpan.FromMinutes(9).Add(TimeSpan.FromSeconds(59));
            secondsElapsed = 0;
            isEmphasized = false;
            originalLocation = Location;
            UpdateCountdownDisplay();
        }

        private void TimerCountdown_Tick(object? sender, EventArgs e)
        {
            if (timeLeft.TotalSeconds > 0)
            {
                timeLeft = timeLeft.Add(TimeSpan.FromSeconds(-1));
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
                MessageBox.Show("时间已到！你的生命已贡献给长者。", "拖出去续了", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EmphasizeCountdown()
        {
            isEmphasized = true;
            lblCountdown.Font = new Font("Consolas", 42F, FontStyle.Bold, GraphicsUnit.Point);
            lblCountdown.ForeColor = Color.FromArgb(255, 0, 0);
            ShakeWindow();

            System.Windows.Forms.Timer resetTimer = new System.Windows.Forms.Timer();
            resetTimer.Interval = 1500;
            resetTimer.Tick += (s, e) =>
            {
                lblCountdown.Font = new Font("Consolas", 32F, FontStyle.Bold, GraphicsUnit.Point);
                lblCountdown.ForeColor = Color.FromArgb(192, 0, 0);
                Location = originalLocation;
                isEmphasized = false;
                ((System.Windows.Forms.Timer)s!).Stop();
                ((System.Windows.Forms.Timer)s!).Dispose();
            };
            resetTimer.Start();
        }

        private async void ShakeWindow()
        {
            int shakeCount = 10;
            int shakeDistance = 15;
            int delay = 50;

            for (int i = 0; i < shakeCount; i++)
            {
                int offsetX = (i % 2 == 0) ? shakeDistance : -shakeDistance;
                Location = new Point(originalLocation.X + offsetX, originalLocation.Y);
                await Task.Delay(delay);
            }
        }

        private void UpdateCountdownDisplay()
        {
            lblCountdown.Text = timeLeft.ToString(@"hh\:mm\:ss");
            lblTimer.Text = $"免费续命剩余时间：{timeLeft.ToString(@"hh\:mm\:ss")}";
        }

        private void BtnDecrypt_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("没有背诵三个代表。请先背诵一遍。", "续命失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnPay_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("请发送 0.05 BTC 到上方地址。\n付款后，点击\"检查付款\"进行验证。", "付款说明", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnCheckPayment_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("尚未检测到付款。请等待区块链确认。", "检查付款", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            mouseOffset = new Point(-e.X, -e.Y);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
                originalLocation = mousePos;
            }
        }
    }
}
