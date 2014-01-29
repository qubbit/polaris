using System.Drawing;
using System.Windows.Forms;
using Polaris.Properties;

namespace Polaris
{
    public partial class OptionsWindow : Form
    {
        private Color hourColor, minuteColor, secondColor, backColor;

        private bool _24HourFormat;

        private int spacing, brushWeight;

        public OptionsWindow()
        {
            InitializeComponent();
        }

        internal void SaveSettings()
        {
            Settings.Default.Weight = int.Parse(txtBrushWeight.Text);

            Settings.Default.Spacing = int.Parse(txtSpacing.Text);            

            Settings.Default.HourColor = hourColor;

            Settings.Default.MinuteColor = minuteColor;

            Settings.Default.SecondColor = secondColor;

            Settings.Default.BackColor = backColor;

            Settings.Default.TimeFormat = chk24Hour.Checked;

            Settings.Default.Save();

        }

        private Color SelectColor()
        {
            ColorDialog colorDialog = new ColorDialog();

            colorDialog.AnyColor = true;
            colorDialog.AllowFullOpen = true;
            colorDialog.FullOpen = true;

            if (colorDialog.ShowDialog() == DialogResult.OK)
                return colorDialog.Color;
            return Color.Black;

        }

        private void btnSecondColor_Click(object sender, System.EventArgs e)
        {
            secondColor = SelectColor();
            btnSecondColor.BackColor = secondColor;
            btnSecondColor.Text = secondColor.Name;
        }

        private void btnHourColor_Click(object sender, System.EventArgs e)
        {
            hourColor = SelectColor();
            btnHourColor.BackColor = hourColor;
            btnHourColor.Text = hourColor.Name;

        }

        private void btnMinuteColor_Click(object sender, System.EventArgs e)
        {
            minuteColor = SelectColor();
            btnMinuteColor.BackColor = minuteColor;
            btnMinuteColor.Text = minuteColor.Name;
        }        

        private void btnOKSave_Click(object sender, System.EventArgs e)
        {
            SaveSettings();
        }

        private void OptionsWindow_Load(object sender, System.EventArgs e)
        {            
            hourColor = Properties.Settings.Default.HourColor;
            minuteColor = Properties.Settings.Default.MinuteColor;
            secondColor = Properties.Settings.Default.SecondColor;
            backColor = Properties.Settings.Default.BackColor;
            brushWeight = Properties.Settings.Default.Weight;
            spacing = Properties.Settings.Default.Spacing;
            _24HourFormat = Settings.Default.TimeFormat;

            btnSecondColor.BackColor = secondColor;
            btnHourColor.BackColor = hourColor;
            btnMinuteColor.BackColor = minuteColor;            
            btnBackColor.BackColor = backColor;

            txtBrushWeight.Text = brushWeight.ToString();
            txtSpacing.Text = spacing.ToString();
            
            btnMinuteColor.Text = minuteColor.Name;
            btnHourColor.Text = hourColor.Name;
            btnSecondColor.Text = secondColor.Name;
            btnBackColor.Text = backColor.Name;

            chk24Hour.Checked = _24HourFormat;

        }

        private void btnBackColor_Click(object sender, System.EventArgs e)
        {
            backColor = SelectColor();
            btnBackColor.BackColor = backColor;
            btnBackColor.Text = backColor.Name;
        }
    }
}