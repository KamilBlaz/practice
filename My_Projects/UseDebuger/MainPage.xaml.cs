﻿using System;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UseDebuger
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            int number = 15;
            number = number + 10;
            number = 36 * 15;
            number = 12 - (42 / 7);
            number = number + 10;
            number = number + 3;
            number = 71 / 3;

            int count = 0;
            count++;
            count--;

            string result = "witam";
            result += "ponownie " + result;
            output.Text = result;
            result = "wartoscia jest " +  count;
            result = "";

            bool yesNo = false;
            bool anotherBool = true;
            yesNo = !anotherBool;








        }
    }
}
