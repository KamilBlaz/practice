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

namespace Await_Async
{
    using Windows.UI.Popups;
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        
        DispatcherTimer timer = new DispatcherTimer();
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            timer.Tick += timer_Tick;
            timer.Interval = TimeSpan.FromMilliseconds(50);
            timer.Start();
            CheckHappiness();

        }

        private  async void CheckHappiness()
        {
            MessageDialog dialog = new MessageDialog("Czy jestes szczęśliwy?");
            dialog.Commands.Add(new UICommand("Szczęśliwy i radosny !"));
            dialog.Commands.Add(new UICommand("Smutny jak listopadowa pogoda."));
            dialog.DefaultCommandIndex = 1;
            UICommand result = await dialog.ShowAsync() as UICommand;
            if (result != null && result.Label == "Szczęśliwy i radosny!")
                response.Text = "Uzytkownik jest szczęsliwy.";
            else
                response.Text = "Uzytkownik jest smutny";
            timer.Stop();
        }

        int i = 0;

        void timer_Tick(object sender, object e)
        {
            ticker.Text = "Chwila nr " + i++;
        }
    }
}
