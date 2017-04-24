using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Microsoft.Toolkit.Uwp;

namespace TestBGT
{
    public sealed partial class MainPage : Page
    {
        DispatcherTimer timer;
        int mins = 0;

        public MainPage()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 1, 0);

            timer.Tick += (s, e) =>
            {
                var task = BackgroundTaskHelper.IsBackgroundTaskRegistered("TimeBackgroundTask");
                var r1 = new Run();
                r1.Text = $@"==== Task registration status ====
                            Reg status: {task}
                            Time: {DateTime.Now.ToString("HH:mm:ss")}
                            ==== Task registration status ====";

                var p1 = new Paragraph();
                p1.Inlines.Add(r1);
                editor.Blocks.Add(p1);
                counter.Text = (++mins).ToString();
            };

            timer.Start();
        }
    }
}
