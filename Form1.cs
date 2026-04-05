namespace Life_Reaper
{
    public partial class Form1 : Form
    {
        private TimeSpan timeLeft;

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
                MessageBox.Show("Time expired! The price has been doubled.", "Time Expired", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateCountdownDisplay()
        {
            lblCountdown.Text = timeLeft.ToString(@"hh\:mm\:ss");
            lblTimer.Text = $"Time left to decrypt for free: {timeLeft.ToString(@"hh\:mm\:ss")}";
        }

        private void BtnDecrypt_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Payment not detected. Please send the required amount first.", "Decryption Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnPay_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Send 0.05 BTC to the address above.\nAfter payment, click 'Check Payment' to verify.", "Payment Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnCheckPayment_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("No payment detected yet. Please wait for blockchain confirmation.", "Checking Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
