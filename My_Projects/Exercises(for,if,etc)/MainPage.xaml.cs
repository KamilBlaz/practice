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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Exercises_for_if_etc_
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

       
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string name = "Quentin";
            int x = 3;
            x = x * 17;
            double d = Math.PI / 2;
            myLabel.Text = "nazwa to " + name
                       + "\nx jest równe " + x
                       + "\nd jest równe" + d;

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {

            int someValue = 4;
            string name = "Krzysiek";

            if ((someValue == 3) && (name.Equals("Janek")))
            {
                myLabel.Text = "someValue jest równe 3 i name jest równe Janek";
            }
            myLabel.Text = "ten wiersz jest wykonywany bez względu na warunki";

        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            int result = 0;
            int x = 6;
            while(x > 3)
            {
                result += x;
                x = x - 1;
            }

           

            for (int z = 1; z < 3; z = z + 1)
            {
                result = result + z;

            }
            myLabel.Text = " Zmienna Result jest równa " + result;

        }

        private void button2_Click_1(object sender, RoutedEventArgs e)
        {
            int x = 5;
            if (x == 10)
            {
                myLabel.Text = "x musi być równe 10";

            }
            else
            {
                myLabel.Text = "x nie jest równe 10";
            }

        }
    }
}
