using Polaris.Properties;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Polaris
{
    internal static class Renderer
    {
        private static int alpha = 255;

        private static int spacing = Settings.Default.Spacing;
        private static int brushWeight = Settings.Default.Weight;
        private static Color hourColor = Settings.Default.HourColor;
        private static Color minuteColor = Settings.Default.MinuteColor;
        private static Color secondColor = Settings.Default.SecondColor;
        private static Color backColor = Settings.Default.BackColor;
        private static bool enable24HourFormat = Settings.Default.TimeFormat;

        public static void RenderClock(RectangleF area, Graphics graphics, bool isPreview)
        {
            int tempBrushWeight = isPreview ? 2 : brushWeight;
            int tempSpacing = isPreview ? 4 : spacing;

            Pen penSecond = new Pen(new SolidBrush(Color.FromArgb(alpha, secondColor)), tempBrushWeight);
            Pen penMinute = new Pen(new SolidBrush(Color.FromArgb(alpha, minuteColor)), tempBrushWeight);
            Pen penHour = new Pen(new SolidBrush(Color.FromArgb(alpha, hourColor)), tempBrushWeight);

            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

            // Formula
            // 1. Subdivide the circle by the total count of each sec, min or hours
            // 2. Multiply the value from 1. by the current sec, min or hour
            // 3.  ==> For ex, for sec (360/60)*current second

            DateTime now = DateTime.Now;

            // Draw second arc
            // For smooth animation consider the current seconds in terms of floating point number like below instead of this --> graphics.DrawArc(penSecond, area, -90f, 6*now.Second);
            graphics.DrawArc(penSecond, area, -90f, 6F * ((now.Second + now.Millisecond / 1000F)));

            // Draw minute arc
            graphics.DrawArc(penMinute, new RectangleF(area.X + tempSpacing * 2, area.Y + tempSpacing * 2, area.Width - tempSpacing * 4, area.Height - tempSpacing * 4), -90f, 6F * (now.Minute + now.Second / 60F));

            int hour = enable24HourFormat ? int.Parse(now.ToString("HH")) : int.Parse(now.ToString("%h"));
            float hourMultiplier = enable24HourFormat ? 360 / 24f : 360 / 12f;

            // Draw hour arc
            graphics.DrawArc(penHour, new RectangleF(area.X + tempSpacing * 4, area.Y + tempSpacing * 4, area.Width - tempSpacing * 8, area.Height - tempSpacing * 8), -90f, hourMultiplier * (hour + now.Minute / 60F));

            graphics.Flush();
        }

        public static void RenderBackground(RectangleF rectangle, Graphics graphics)
        {
            graphics.Clear(backColor);
        }
    }
}
