using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using TodoApp.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace TodoApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShowTask : ContentPage
    {
        public ShowTask()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            
            base.OnAppearing();
            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                

                conn.CreateTable<Tasks>();
                var listOfTasks = conn.Table<Tasks>().ToList();
                taskView.ItemsSource = listOfTasks;
            }
           
        }

       
    }
}