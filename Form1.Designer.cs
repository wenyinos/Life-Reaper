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
            panelTitleBar = new Panel();
            btnClose = new Button();
            btnMinimize = new Button();
            lblTitle = new Label();
            panelContent = new Panel();
            lblWarning = new Label();
            lblQuestion1 = new Label();
            lblDescription1 = new Label();
            lblQuestion2 = new Label();
            lblDescription2 = new Label();
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
            panelTitleBar.SuspendLayout();
            panelContent.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(192, 0, 0);
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Controls.Add(btnMinimize);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Margin = new Padding(4, 4, 4, 4);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1003, 53);
            panelTitleBar.TabIndex = 0;
            panelTitleBar.MouseDown += PanelTitleBar_MouseDown;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.FromArgb(192, 0, 0);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 14F);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(951, 5);
            btnClose.Margin = new Padding(4, 4, 4, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(46, 43);
            btnClose.TabIndex = 2;
            btnClose.Text = "✕";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += BtnClose_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.FromArgb(192, 0, 0);
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Segoe UI", 14F);
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Location = new Point(897, 5);
            btnMinimize.Margin = new Padding(4, 4, 4, 4);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(46, 43);
            btnMinimize.TabIndex = 1;
            btnMinimize.Text = "─";
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += BtnMinimize_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(15, 8);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(173, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "续命 26.08.17";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.FromArgb(245, 245, 245);
            panelContent.Controls.Add(lblWarning);
            panelContent.Controls.Add(lblQuestion1);
            panelContent.Controls.Add(lblDescription1);
            panelContent.Controls.Add(lblQuestion2);
            panelContent.Controls.Add(lblDescription2);
            panelContent.Controls.Add(lblCountdownLabel);
            panelContent.Controls.Add(lblCountdown);
            panelContent.Controls.Add(lblInstructions);
            panelContent.Controls.Add(lblBtcAddress);
            panelContent.Controls.Add(lblBtcAmount);
            panelContent.Controls.Add(btnDecrypt);
            panelContent.Controls.Add(btnPay);
            panelContent.Controls.Add(btnCheckPayment);
            panelContent.Controls.Add(lblTimer);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 53);
            panelContent.Margin = new Padding(4, 4, 4, 4);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1003, 694);
            panelContent.TabIndex = 1;
            // 
            // lblWarning
            // 
            lblWarning.AutoSize = true;
            lblWarning.Font = new Font("Microsoft YaHei UI", 20F, FontStyle.Bold);
            lblWarning.ForeColor = Color.FromArgb(192, 0, 0);
            lblWarning.Location = new Point(39, 27);
            lblWarning.Margin = new Padding(4, 0, 4, 0);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(496, 45);
            lblWarning.TabIndex = 0;
            lblWarning.Text = "哎呀，你的寿命正在快速消失！";
            // 
            // lblQuestion1
            // 
            lblQuestion1.AutoSize = true;
            lblQuestion1.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Bold);
            lblQuestion1.ForeColor = Color.FromArgb(192, 0, 0);
            lblQuestion1.Location = new Point(39, 93);
            lblQuestion1.Margin = new Padding(4, 0, 4, 0);
            lblQuestion1.Name = "lblQuestion1";
            lblQuestion1.Size = new Size(231, 36);
            lblQuestion1.TabIndex = 1;
            lblQuestion1.Text = "你的寿命怎么了？";
            // 
            // lblDescription1
            // 
            lblDescription1.Font = new Font("Microsoft YaHei UI", 11F);
            lblDescription1.ForeColor = Color.FromArgb(50, 50, 50);
            lblDescription1.Location = new Point(39, 133);
            lblDescription1.Margin = new Padding(4, 0, 4, 0);
            lblDescription1.Name = "lblDescription1";
            lblDescription1.Size = new Size(926, 40);
            lblDescription1.TabIndex = 2;
            lblDescription1.Text = "有一位老领导正在进行时间众筹。你暂时不会被续掉，但寿命正在快速减少。";
            // 
            // lblQuestion2
            // 
            lblQuestion2.AutoSize = true;
            lblQuestion2.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Bold);
            lblQuestion2.ForeColor = Color.FromArgb(192, 0, 0);
            lblQuestion2.Location = new Point(39, 180);
            lblQuestion2.Margin = new Padding(4, 0, 4, 0);
            lblQuestion2.Name = "lblQuestion2";
            lblQuestion2.Size = new Size(204, 36);
            lblQuestion2.TabIndex = 3;
            lblQuestion2.Text = "我应该怎么做？";
            // 
            // lblDescription2
            // 
            lblDescription2.Font = new Font("Microsoft YaHei UI", 11F);
            lblDescription2.ForeColor = Color.FromArgb(50, 50, 50);
            lblDescription2.Location = new Point(39, 220);
            lblDescription2.Margin = new Padding(4, 0, 4, 0);
            lblDescription2.Name = "lblDescription2";
            lblDescription2.Size = new Size(926, 40);
            lblDescription2.TabIndex = 4;
            lblDescription2.Text = "你应该背诵三个代表全篇，或者学习老三篇，也可以念两句诗。";
            // 
            // lblCountdownLabel
            // 
            lblCountdownLabel.AutoSize = true;
            lblCountdownLabel.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold);
            lblCountdownLabel.ForeColor = Color.FromArgb(192, 0, 0);
            lblCountdownLabel.Location = new Point(39, 293);
            lblCountdownLabel.Margin = new Padding(4, 0, 4, 0);
            lblCountdownLabel.Name = "lblCountdownLabel";
            lblCountdownLabel.Size = new Size(350, 31);
            lblCountdownLabel.TabIndex = 5;
            lblCountdownLabel.Text = "你的命将在以下时间续给长者：";
            // 
            // lblCountdown
            // 
            lblCountdown.AutoSize = true;
            lblCountdown.Font = new Font("Consolas", 32F, FontStyle.Bold);
            lblCountdown.ForeColor = Color.FromArgb(192, 0, 0);
            lblCountdown.Location = new Point(39, 340);
            lblCountdown.Margin = new Padding(4, 0, 4, 0);
            lblCountdown.Name = "lblCountdown";
            lblCountdown.Size = new Size(267, 64);
            lblCountdown.TabIndex = 6;
            lblCountdown.Text = "07:00:00";
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            lblInstructions.ForeColor = Color.FromArgb(50, 50, 50);
            lblInstructions.Location = new Point(39, 433);
            lblInstructions.Margin = new Padding(4, 0, 4, 0);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(252, 27);
            lblInstructions.TabIndex = 7;
            lblInstructions.Text = "三个代表重要思想内容是：";
            // 
            // lblBtcAddress
            // 
            lblBtcAddress.Font = new Font("Microsoft YaHei UI", 10F);
            lblBtcAddress.ForeColor = Color.FromArgb(0, 100, 200);
            lblBtcAddress.Location = new Point(39, 473);
            lblBtcAddress.Margin = new Padding(4, 0, 4, 0);
            lblBtcAddress.Name = "lblBtcAddress";
            lblBtcAddress.Size = new Size(926, 51);
            lblBtcAddress.TabIndex = 8;
            lblBtcAddress.Text = "中国共产党要始终代表中国先进社会生产力的发展要求，代表中国先进文化的前进方向，代表中国最广大人民的根本利益";
            // 
            // lblBtcAmount
            // 
            lblBtcAmount.AutoSize = true;
            lblBtcAmount.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold);
            lblBtcAmount.ForeColor = Color.FromArgb(192, 0, 0);
            lblBtcAmount.Location = new Point(39, 520);
            lblBtcAmount.Margin = new Padding(4, 0, 4, 0);
            lblBtcAmount.Name = "lblBtcAmount";
            lblBtcAmount.Size = new Size(61, 31);
            lblBtcAmount.TabIndex = 9;
            lblBtcAmount.Text = "+1S";
            // 
            // btnDecrypt
            // 
            btnDecrypt.BackColor = Color.FromArgb(192, 0, 0);
            btnDecrypt.FlatAppearance.BorderSize = 0;
            btnDecrypt.FlatStyle = FlatStyle.Flat;
            btnDecrypt.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            btnDecrypt.ForeColor = Color.White;
            btnDecrypt.Location = new Point(39, 587);
            btnDecrypt.Margin = new Padding(4, 4, 4, 4);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(257, 60);
            btnDecrypt.TabIndex = 10;
            btnDecrypt.Text = "背诵三个代表";
            btnDecrypt.UseVisualStyleBackColor = false;
            btnDecrypt.Click += BtnDecrypt_Click;
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.FromArgb(0, 100, 200);
            btnPay.FlatAppearance.BorderSize = 0;
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            btnPay.ForeColor = Color.White;
            btnPay.Location = new Point(334, 587);
            btnPay.Margin = new Padding(4, 4, 4, 4);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(257, 60);
            btnPay.TabIndex = 11;
            btnPay.Text = "学习老三篇";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += BtnPay_Click;
            // 
            // btnCheckPayment
            // 
            btnCheckPayment.BackColor = Color.FromArgb(80, 80, 80);
            btnCheckPayment.FlatAppearance.BorderSize = 0;
            btnCheckPayment.FlatStyle = FlatStyle.Flat;
            btnCheckPayment.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            btnCheckPayment.ForeColor = Color.White;
            btnCheckPayment.Location = new Point(630, 587);
            btnCheckPayment.Margin = new Padding(4, 4, 4, 4);
            btnCheckPayment.Name = "btnCheckPayment";
            btnCheckPayment.Size = new Size(257, 60);
            btnCheckPayment.TabIndex = 12;
            btnCheckPayment.Text = "念两句诗";
            btnCheckPayment.UseVisualStyleBackColor = false;
            btnCheckPayment.Click += BtnCheckPayment_Click;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("Microsoft YaHei UI", 10F);
            lblTimer.ForeColor = Color.FromArgb(100, 100, 100);
            lblTimer.Location = new Point(39, 673);
            lblTimer.Margin = new Padding(4, 0, 4, 0);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(163, 23);
            lblTimer.TabIndex = 13;
            lblTimer.Text = "你的寿命剩余时间：";
            // 
            // timerCountdown
            // 
            timerCountdown.Enabled = true;
            timerCountdown.Interval = 1000;
            timerCountdown.Tick += TimerCountdown_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 747);
            Controls.Add(panelContent);
            Controls.Add(panelTitleBar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "续命 26.08.17";
            TopMost = true;
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitleBar;
        private Label lblTitle;
        private Button btnMinimize;
        private Button btnClose;
        private Panel panelContent;
        private Label lblWarning;
        private Label lblQuestion1;
        private Label lblDescription1;
        private Label lblQuestion2;
        private Label lblDescription2;
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
