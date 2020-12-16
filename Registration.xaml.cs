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


using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Assignment_2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Registration : Page
    {
        

      //  public static  List<User> user = new List<User>();


        public Registration()
        {
            this.InitializeComponent();

           
        }

        private void buttonLogin_Click(object sender, RoutedEventArgs e)
        {
           Frame.Navigate(typeof(Login));
        }

        private  void buttonRegister_Click(object sender, RoutedEventArgs e)
        {
            App.Register(textBoxUsername,textBoxPassword,textBoxFirstname,textBoxLastname,textBoxEmail,textBoxContact,Frame);
        }

     
    }
}
