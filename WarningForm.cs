namespace Life_Reaper
{
    public class WarningForm : Form
    {
        private Panel? panelTitleBar;
        private Label? lblTitle;
        private Button? btnClose;
        private Panel? panelContent;
        private Label? lblWarning;
        private Button? btnConfirm;
        private Point mouseOffset;
        private bool isDragging;

        public WarningForm()
        {
            InitializeWarningForm();
        }

        private void InitializeWarningForm()
        {
            // Window-level styles (match main window)
            Text = "警告";
            Size = new Size(500, 280);
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterParent;
            ShowInTaskbar = false;
            TopMost = true;

            // Title bar panel
            panelTitleBar = new Panel();
            panelTitleBar.BackColor = Color.FromArgb(192, 0, 0);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Size = new Size(500, 40);
            panelTitleBar.MouseDown += PanelTitleBar_MouseDown;

            // Title label
            lblTitle = new Label();
            lblTitle.Text = "警告";
            lblTitle.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(12, 6);
            lblTitle.AutoSize = true;
            lblTitle.MouseDown += PanelTitleBar_MouseDown;

            // Close button
            btnClose = new Button();
            btnClose.Text = "✕";
            btnClose.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Size = new Size(36, 32);
            btnClose.Location = new Point(460, 4);
            btnClose.BackColor = Color.FromArgb(192, 0, 0);
            btnClose.ForeColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Click += (s, e) => Close();

            // Content panel
            panelContent = new Panel();
            panelContent.BackColor = Color.FromArgb(245, 245, 245);
            panelContent.Dock = DockStyle.Fill;

            // Warning label
            lblWarning = new Label();
            lblWarning.Text = "你正在给长者续命";
            lblWarning.Font = new Font("Microsoft YaHei UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            lblWarning.ForeColor = Color.FromArgb(192, 0, 0);
            lblWarning.TextAlign = ContentAlignment.MiddleCenter;
            lblWarning.Location = new Point(25, 40);
            lblWarning.Size = new Size(450, 60);
            lblWarning.AutoSize = false;

            // Confirm button
            btnConfirm = new Button();
            btnConfirm.Text = "确认";
            btnConfirm.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirm.Size = new Size(120, 40);
            btnConfirm.Location = new Point(190, 130);
            btnConfirm.BackColor = Color.FromArgb(192, 0, 0);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.Click += (s, e) => Close();

            // Add controls
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Controls.Add(btnClose);
            panelContent.Controls.Add(lblWarning);
            panelContent.Controls.Add(btnConfirm);
            Controls.Add(panelContent);
            Controls.Add(panelTitleBar);
        }

        private void PanelTitleBar_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            isDragging = true;
            Point mousePos = Control.MousePosition;
            mouseOffset = new Point(mousePos.X - Location.X, mousePos.Y - Location.Y);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (!isDragging || e.Button != MouseButtons.Left)
            {
                return;
            }

            Point mousePos = Control.MousePosition;
            Location = new Point(mousePos.X - mouseOffset.X, mousePos.Y - mouseOffset.Y);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }
    }
}
