using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace App1
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    /// 
    
    public sealed partial class MainPage : Page
    {
        private static int num = 0;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void checkBox_check(object sender, RoutedEventArgs e)
        {
            if (num % 2 == 0)
            {
                line.Visibility = Visibility.Visible;
            }
            else
            {
                line.Visibility = Visibility.Collapsed;
            }
            num++;
        }

        private void Goto_button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(BlankPage1), "");
        }
    }
}
