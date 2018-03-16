using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace App1
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class BlankPage1 : Page
    {
        public BlankPage1()
        {
            this.InitializeComponent();
        }
   
        private void Cancel_button_clicked(object sender, RoutedEventArgs e)
        {  
            Title_textBox.Text = String.Empty;
            Detail_textBox.Text = String.Empty;
            DatePicker.Date = DateTime.Now.Date;
        }

        private async void Create_button_clicked(object sender, RoutedEventArgs e)
        {
            if (Title_textBox.Text == String.Empty || Detail_textBox.Text == string.Empty || (DatePicker.Date < DateTime.Now.Date) )
            {
                var dialog = new ContentDialog()
                {
                    Title = "Error",
                    Content = "Your input is wrong.",
                    PrimaryButtonText = "Confirm",
                    SecondaryButtonText = "Cancel",
                    FullSizeDesired = false,
                };
                
                await dialog.ShowAsync();

            }
            else
            {
                
            }
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
