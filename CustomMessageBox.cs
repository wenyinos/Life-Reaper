namespace Life_Reaper
{
    public class CustomMessageBox : Form
    {
        private Panel? panelTitleBar;
        private Label? lblTitle;
        private Button? btnClose;
        private Panel? panelContent;
        private Label? lblMessage;
        private Button? btnOk;
        private Point mouseOffset;
        private bool isDragging;

        private CustomMessageBox(string message, string title)
        {
            InitializeMessageBox(message, title);
        }

        private void InitializeMessageBox(string message, string title)
        {
            // Calculate size based on message length
            int width = 450;
            int height = 200;

            if (message.Length > 50)
            {
                width = 500;
                height = 240;
            }
            if (message.Length > 100)
            {
                width = 550;
                height = 280;
            }

            // Window-level styles (match main window)
            Text = title;
            Size = new Size(width, height);
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterParent;
            ShowInTaskbar = false;
            TopMost = true;

            // Title bar panel
            panelTitleBar = new Panel();
            panelTitleBar.BackColor = Color.FromArgb(192, 0, 0);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Size = new Size(width, 40);
            panelTitleBar.MouseDown += PanelTitleBar_MouseDown;

            // Title label
            lblTitle = new Label();
            lblTitle.Text = title;
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
            btnClose.Location = new Point(width - 40, 4);
            btnClose.BackColor = Color.FromArgb(192, 0, 0);
            btnClose.ForeColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Click += (s, e) => Close();

            // Content panel
            panelContent = new Panel();
            panelContent.BackColor = Color.FromArgb(245, 245, 245);
            panelContent.Dock = DockStyle.Fill;

            // Message label
            lblMessage = new Label();
            lblMessage.Text = message;
            lblMessage.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMessage.ForeColor = Color.FromArgb(50, 50, 50);
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            lblMessage.Location = new Point(20, 30);
            lblMessage.Size = new Size(width - 40, height - 120);
            lblMessage.AutoSize = false;

            // OK button
            btnOk = new Button();
            btnOk.Text = "确认";
            btnOk.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnOk.Size = new Size(120, 40);
            btnOk.Location = new Point((width - 120) / 2, height - 90);
            btnOk.BackColor = Color.FromArgb(192, 0, 0);
            btnOk.ForeColor = Color.White;
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.FlatAppearance.BorderSize = 0;
            btnOk.Click += (s, e) => Close();

            // Add controls
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Controls.Add(btnClose);
            panelContent.Controls.Add(lblMessage);
            panelContent.Controls.Add(btnOk);
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

        public static void Show(string message, string title)
        {
            CustomMessageBox msgBox = new CustomMessageBox(message, title);
            msgBox.ShowDialog();
        }

        public static void Show(IWin32Window owner, string message, string title)
        {
            CustomMessageBox msgBox = new CustomMessageBox(message, title);
            msgBox.ShowDialog(owner);
        }
    }
}
