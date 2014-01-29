using System;
using System.Drawing;
using System.Windows.Forms;

namespace Polaris
{
    public partial class MainWindow : Form
    {
        private bool isMouseInitialised;
        private Point initialMousePosition;

        public MainWindow()
        {
            InitializeComponent();
            Cursor.Hide();

            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
#if DEBUG
            TopMost = false;
#endif
        }

        private float cx, cy;
        private float radius;

        protected override void OnPaint(PaintEventArgs e)
        {
            Renderer.RenderClock(rect, e.Graphics, false);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            Renderer.RenderBackground(rect, e.Graphics);
        }

        private void MainWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseInitialised && initialMousePosition != e.Location)
            {
                HandleKeyOrMouseEvent();
            }
            else
            {
                isMouseInitialised = true;
                initialMousePosition = e.Location;
            }
        }

        private void MainWindow_KeyOrMouseEvent(object sender, EventArgs e)
        {
            HandleKeyOrMouseEvent();
        }

        private void HandleKeyOrMouseEvent()
        {
            Cursor.Show();
            Application.Exit();
        }

        private RectangleF rect;

        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            cx = this.ClientSize.Width / 2f;
            cy = this.ClientSize.Height / 2f;
            radius = (Math.Min(cx, cy) * 0.8f);
            BackColor = Properties.Settings.Default.BackColor;
            rect = new RectangleF(cx - radius, cy - radius, radius * 2f, radius * 2f);
        }
    }
}
