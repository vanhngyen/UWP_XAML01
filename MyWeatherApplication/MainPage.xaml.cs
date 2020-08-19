using MyWeatherApplication.Model;
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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using static MyWeatherApplication.Model.GetWeatherData;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MyWeatherApplication
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

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            RootObject myWeather = await GetWeatherData.getOpenWeather();
            string icon = string.Format("http://openweathermap.org/img/w/{0}.png", myWeather.weather[0].icon);
            ResultIconImage.Source = new BitmapImage(new Uri(icon, UriKind.Absolute));
            ResultWeatherTextBlock.Text = myWeather.name + "-" + ((int)myWeather.main.temp).ToString();
        }
    }
}
