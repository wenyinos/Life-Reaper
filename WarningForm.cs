namespace Life_Reaper
{
    public class WarningForm : Form
    {
        public WarningForm()
        {
            InitializeWarningForm();
        }

        private void InitializeWarningForm()
        {
            Text = "警告";
            Size = new Size(500, 280);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            BackColor = Color.FromArgb(255, 255, 200);
            ShowInTaskbar = false;
            TopMost = true;

            Label lblWarning = new Label();
            lblWarning.Text = "你正在给长者续命";
            lblWarning.Font = new Font("Microsoft YaHei UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            lblWarning.ForeColor = Color.FromArgb(200, 0, 0);
            lblWarning.TextAlign = ContentAlignment.MiddleCenter;
            lblWarning.Location = new Point(20, 30);
            lblWarning.Size = new Size(450, 80);
            lblWarning.AutoSize = false;

            Button btnConfirm = new Button();
            btnConfirm.Text = "确认";
            btnConfirm.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirm.Size = new Size(120, 40);
            btnConfirm.Location = new Point(190, 140);
            btnConfirm.BackColor = Color.FromArgb(200, 0, 0);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.Click += (s, e) => Close();

            Controls.Add(lblWarning);
            Controls.Add(btnConfirm);
        }
    }
}
