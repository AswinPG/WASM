using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WASM
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        int count;
        public MainPage()
        {
            InitializeComponent();
            count = 0;
            List<string> data = new List<string>() { "bhjbjbjk", "jbjb", "bjhbj", "bjkbkhbkjbjk", "jbkjbjkjk" };
            MainCollectionView.ItemsSource = data;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            MainLabel.Text = count++.ToString();
        }

        private async void MainCollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            await DisplayAlert("Test", "Yaaaayyy", "Wokay");
        }
    }
}
