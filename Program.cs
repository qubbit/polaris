using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

//Modified Program.cs from http://sinchron.codeplex.com/

namespace Polaris
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            switch (args.Length > 0 ? args[0].Substring(0, 2) : string.Empty)
            {
                case "/c":
                    Application.EnableVisualStyles();

                    var polarisOptions = new OptionsWindow();

                    if (polarisOptions.ShowDialog() == DialogResult.OK)
                    {
                        polarisOptions.SaveSettings();
                    }
                    break;
                case "/p":
                    try
                    {
                        IntPtr previewWindowHandle = new IntPtr(uint.Parse(args[1]));

                        while (!IsWindowVisible(previewWindowHandle))
                        {
                            Application.DoEvents();
                            Thread.Sleep(0);
                        }

                        var previewWindowRect = new RECT();

                        GetClientRect(previewWindowHandle, ref previewWindowRect);

                        int cx = previewWindowRect.right / 2;
                        int cy = previewWindowRect.bottom / 2;
                        int radius = (int)(Math.Min(cx, cy) * 0.8);

                        var previewWindowRectangle = new RectangleF(cx - radius, cy - radius, radius * 2f, radius * 2f);

                        Application.DoEvents();
                        using (var graphics = Graphics.FromHwnd(previewWindowHandle))
                        {
                            graphics.Clear(Properties.Settings.Default.BackColor);

                            Renderer.RenderClock(previewWindowRectangle, graphics, true);

                            graphics.Flush();
                        }
                    }
                    catch
                    {

                    }

                    break;
                default:
                case "/s":
                    ShowScreensaver();
                    break;
            }
        }

        [DllImport("user32.dll")]
        private static extern bool IsWindowVisible(IntPtr previewWindowHandle);

        [DllImport("user32.dll")]
        private static extern void GetClientRect(IntPtr previewWindowHandle, ref RECT rectangle);

        private struct RECT
        {
            public int left, top, right, bottom;
        }

        private static void ShowScreensaver()
        {
            var formList = new List<MainWindow>(Screen.AllScreens.Count());

            foreach (var screen in Screen.AllScreens)
            {
                var form = new MainWindow();

                form.Show();

                form.Bounds = screen.Bounds;

                formList.Add(form);
            }

            bool isRunning = true;


            ThreadPool.QueueUserWorkItem((state) =>
            {
                try
                {
                    while (isRunning)
                    {
                        var results = from form in formList
                                      select new { Form = form, AsyncResult = form.BeginInvoke(new MethodInvoker(form.Refresh)) };

                        WaitHandle.WaitAll(results.Select(result => result.AsyncResult.AsyncWaitHandle).ToArray());

                        foreach (var result in results)
                        {
                            result.Form.EndInvoke(result.AsyncResult);
                        }
                    }
                }
                catch (ObjectDisposedException)
                {
                    Application.Exit();
                }
                catch
                {
                    Application.Exit();
                    throw;
                }
            });

            Application.Run();

            isRunning = false;
        }
    }
}