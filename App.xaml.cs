using Assignment_2.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.SpeechSynthesis;
using Windows.Networking.BackgroundTransfer;
using Windows.UI.Popups;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace Assignment_2
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    sealed partial class App : Application
    {
        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        ///

       
        static Random rand = new Random();
      

        internal static List<User> user = new List<User>() { new User() { FirstName = "Paul", LastName = "Morris", Contact = "1", Email = "//", Id = 1, Username = "paul", Password = "1234" } };
        internal static User userLoggedInfo = new User();

        internal static string[] bgColors = new string[] {
            "#FFE2869F",
            "#FFDFC07D",
            "#FF598286",
            "#FFE16364",
            "#FFAEDD97",
            "#FF578386",
            "#FFE2849E",
            "#FFE285A0",
            "#FFAEDD95",
            "#FF94DCC4",
            "#FF598288",
            "#FF97DDC5",
            "#FFE1C37D",          
        };

        public App()
        {
            this.InitializeComponent();
            this.Suspending += OnSuspending;

        
           

            //  Tasks = TaskManager.GetTasks();

        }

        /// <summary>
        /// Invoked when the application is launched normally by the end user.  Other entry points
        /// will be used such as when the application is launched to open a specific file.
        /// </summary>
        /// <param name="e">Details about the launch request and process.</param>
        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;

            // Do not repeat app initialization when the Window already has content,
            // just ensure that the window is active
            if (rootFrame == null)
            {
                // Create a Frame to act as the navigation context and navigate to the first page
                rootFrame = new Frame();

                rootFrame.NavigationFailed += OnNavigationFailed;

                if (e.PreviousExecutionState == ApplicationExecutionState.Terminated)
                {
                    //TODO: Load state from previously suspended application
                }

                // Place the frame in the current Window
                Window.Current.Content = rootFrame;
            }

            if (e.PrelaunchActivated == false)
            {
                if (rootFrame.Content == null)
                {
                    // When the navigation stack isn't restored navigate to the first page,
                    // configuring the new page by passing required information as a navigation
                    // parameter
                    rootFrame.Navigate(typeof(StartPage), e.Arguments);
                    
                }
                // Ensure the current window is active
                Window.Current.Activate();
            }
        }

        /// <summary>
        /// Invoked when Navigation to a certain page fails
        /// </summary>
        /// <param name="sender">The Frame which failed navigation</param>
        /// <param name="e">Details about the navigation failure</param>
        void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            throw new Exception("Failed to load Page " + e.SourcePageType.FullName);
        }

        /// <summary>
        /// Invoked when application execution is being suspended.  Application state is saved
        /// without knowing whether the application will be terminated or resumed with the contents
        /// of memory still intact.
        /// </summary>
        /// <param name="sender">The source of the suspend request.</param>
        /// <param name="e">Details about the suspend request.</param>
        private void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();
            //TODO: Save application state and stop any background activity
            deferral.Complete();
        }

        internal static async void Login(TextBox textBoxUsername,PasswordBox textBoxPass,Frame frame) {

            Frame rootFrame = Window.Current.Content as Frame;

            MessageDialog msg = new MessageDialog("", "");
            var userQuery = App.user.Where(u => u.Username.Equals(textBoxUsername.Text) && u.Password.Equals(textBoxPass.Password)).FirstOrDefault();

            if (userQuery == null)
            {
                msg.Content = "Invalid Account";
                msg.Title = "Login Failed";
            }
            else
            {
                msg.Content = String.Format("Welcome {0}", userQuery.Username);
                msg.Title = "Login Successful";
                rootFrame.Navigate(typeof(MainPage));

                App.userLoggedInfo = new User() { Username = userQuery.Username, FirstName = userQuery.FirstName, LastName = userQuery.LastName, Id = userQuery.Id, Contact = userQuery.Contact, Email = userQuery.Email, Password = userQuery.Password };


            }
            await msg.ShowAsync();
        }

        internal static async void Register(TextBox textBoxUsername,PasswordBox textBoxPassword,TextBox textBoxFirstname,TextBox textBoxLastname, TextBox textBoxEmail, TextBox textBoxContact,Frame frame) {
           
            MessageDialog msg = new MessageDialog("");

            if (textBoxFirstname.Text == "" &&
                textBoxLastname.Text == "" &&
                textBoxUsername.Text == "" &&
                textBoxPassword.Password == "" &&
                textBoxEmail.Text == "" &&
                textBoxContact.Text == "")
            {

                msg.Content = "Please complete details.";

            }
            else if (textBoxFirstname.Text != "" &&
                     textBoxLastname.Text != "" &&
                     textBoxUsername.Text != "" &&
                     textBoxPassword.Password != "" &&
                     textBoxEmail.Text != "" &&
                     textBoxContact.Text != "")
            {
                App.user.Add(new User
                {
                    FirstName = textBoxFirstname.Text,
                    LastName = textBoxLastname.Text,
                    Username = textBoxUsername.Text,
                    Password = textBoxPassword.Password,
                    Email = textBoxEmail.Text,
                    Contact = textBoxContact.Text,
                });

                msg.Content = "Registration Successfully";
                frame.Navigate(typeof(Login));

            }
            else { msg.Content = "Please complete details."; }



            await msg.ShowAsync();
        }

        internal static  void RandomBackground(Grid rp) {
             
            rp.Background = GetSolidColorBrush(bgColors[rand.Next(0, bgColors.Length)]);

        }

        internal static SolidColorBrush GetSolidColorBrush(string hex)
        {
            hex = hex.Replace("#", string.Empty);
            byte a = (byte)(Convert.ToUInt32(hex.Substring(0, 2), 16));
            byte r = (byte)(Convert.ToUInt32(hex.Substring(2, 2), 16));
            byte g = (byte)(Convert.ToUInt32(hex.Substring(4, 2), 16));
            byte b = (byte)(Convert.ToUInt32(hex.Substring(6, 2), 16));
            SolidColorBrush myBrush = new SolidColorBrush(Windows.UI.Color.FromArgb(a, r, g, b));
            return myBrush;
        }

        internal async static void DisplayJoke(TextBlock tb1, TextBlock tb2) {

            SpeechSynthesizer r = new SpeechSynthesizer();
            MediaElement mediaplayer = new MediaElement();
            var voice = SpeechSynthesizer.AllVoices;
            r.Voice = voice.First(gender => gender.Gender == VoiceGender.Male);
            int randomJokeNumber = rand.Next(0, JokeManager.Jokes.Count);

            /////////////////////////////////////////////////////////////////////////

            tb1.Text = "\"" + JokeManager.Jokes[randomJokeNumber].FirstLine + "\"";
            tb2.Text = JokeManager.Jokes[randomJokeNumber].SecondLine;

            var fullText = tb1.Text + tb2.Text;
            


            var stream = await r.SynthesizeTextToStreamAsync(fullText);
            mediaplayer.SetSource(stream, stream.ContentType);
            mediaplayer.Play();



        }

        internal static string ReturnFullname() {
            return App.userLoggedInfo.FirstName + " " + App.userLoggedInfo.LastName;
        }

       

      


    }
}
