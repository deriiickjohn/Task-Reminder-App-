using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Assignment_2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ViewTask : Page
    {
        public List<Task> CompleteTasks;
        public List<Task> IncompleteTasks;
       
        

        public ViewTask()
        {
            this.InitializeComponent();

          

            CompleteTasks = TaskManager.Tasks.Where(t => t.IsDone == true).ToList();
            IncompleteTasks = TaskManager.Tasks.Where(t => t.IsDone == false).ToList();

            OverDueFunction();
            UpdateChart();
        }


        private void listView_ItemClick(object sender, RoutedEventArgs e)
        {

            var taskClicked = (MenuFlyoutItem)sender;
            var task = (Task)taskClicked.DataContext;

                foreach (Task t in TaskManager.Tasks)
                {

                    if (task.Id == t.Id)
                    {
                        t.IsDone = !t.IsDone;

                        if (t.IsDone)
                        {
                            t.ImageLogo = "Assets/complete.png";
                        }
                        else {
                            t.ImageLogo = "Assets/incomplete.png";
                        }


                    }

                }
                Frame.Navigate(typeof(ViewTask));

         }

        public  void OverDueFunction()
        {


            foreach (Task i in IncompleteTasks)
            {

                DateTime dueDate = Convert.ToDateTime(i.Date);

                if (DateTime.Today > dueDate)
                {

                    i.dateStatus = "Overdue: ";

                }
                else {

                    i.dateStatus = "Due Date: ";
                }
            }
        }

        private void UpdateChart() {

            textBlockTotal.Text = TaskManager.Tasks.Count().ToString();
            textBlockComplete.Text = CompleteTasks.Count().ToString();
            textBlockIncomplete.Text = IncompleteTasks.Count().ToString();

        }

        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            var taskClicked = (MenuFlyoutItem)sender;

            TaskManager.Tasks.Remove((Task)taskClicked.DataContext);
            Frame.Navigate(typeof(ViewTask));

        }
    }
}
