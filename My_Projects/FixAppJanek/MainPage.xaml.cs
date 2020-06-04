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

namespace FixAppJanek
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

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ItemClick(object sender, ItemClickEventArgs e)
        {
            ComicQuery query = e.ClickedItem as ComicQuery;
            if (query != null)
                this.Frame.Navigate(typeof(QueryDetail), query);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            ComicQuery comicQuery = e.Parameter as ComicQuery;
            if(comicQuery != null){
                comicQueryManager.UpdateQueryResults(comicQuery);
            
            }
            base.OnNavigatedTo(e);
        }
    }
}