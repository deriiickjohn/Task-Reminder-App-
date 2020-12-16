using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;



// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Assignment_2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Drink : Page
    {
        private int time = 30;

        DispatcherTimer dt;


        public Drink()
        {
            this.InitializeComponent();
            dt = new DispatcherTimer();
            dt.Interval = new TimeSpan(0, 0, 1);
            dt.Tick += Timer_Tick;

        }

        void Timer_Tick(object sender, object e)
        {
            if (time > 0)
            {
              
                    time--;
                    timerTextBlock.Text = string.Format("{0} mins:{1} secs", time / 60, time % 60);
                
            }
            else
            {
                dt.Stop();
                timerTextBlock.Text = "Drink your water now!!";
                timerTextBlock.Foreground = new SolidColorBrush(Colors.CadetBlue);
                imageWater.Source = new BitmapImage(new Uri("ms-appx:///Assets/drinkwater2.gif"));
                timerTextBlock.FontSize = 70;
            }
        }


        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            dt.Start();
        }

        private void comboBoxName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            imageWater.Source = new BitmapImage(new Uri("ms-appx:///Assets/drinkwater.gif"));
            timerTextBlock.FontSize = 70;
            timerTextBlock.Foreground = new SolidColorBrush(Colors.Black);
            ComboBoxItem cmb = comboBox.SelectedItem as ComboBoxItem;
            string test = cmb.Content.ToString();
            if (test == "15 secs") time = 15;
            else if (test == "30 secs") time = 30;
            else if (test == "1 min") time = 60;
            else if (test == "5 mins") time = 300;
            else if (test == "10 mins") time = 600;
            else if (test == "20 mins") time = 1200;
            else if (test == "30 mins") time = 1800; 
            timerTextBlock.Text = test;
        }

      
      
    }
}