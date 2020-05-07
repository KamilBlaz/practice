using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp_Exercises_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class NotMain: Window
    {
        
        public NotMain()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
            if (checkBox.IsChecked == true)
            {
                if (label.Text == "Z prawej")
                {
                    label.Text = "Z lewej";
                    label.HorizontalAlignment = HorizontalAlignment.Right;


                }
                else
                {
                    label.Text = "Z prawej";
                    label.HorizontalAlignment = HorizontalAlignment.Left;


                }
            }




            else
            {
                label.Text = "Mozliwosc zmiany tekstu zostala wylaczona";
            }
            
        }
    }
}
