using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TodoApp.Model;

namespace TodoApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Addtask : ContentPage
    {
        public Addtask()
        {
            InitializeComponent();
        }

        private void SaveTask_Clicked(object sender, EventArgs e)
        {
            string selectedColor;

            if(PriorityEntry.Text == "High" || PriorityEntry.Text == "high")
            {
                selectedColor = "Red";
            }
            else if (PriorityEntry.Text == "medium" || PriorityEntry.Text == "Medium")
            {
                selectedColor = "Yellow";
            }
            else
            {
                selectedColor = "Green";
            }

            Tasks tk = new Tasks
            {
                Task = TaskEntry.Text,
                Priority = PriorityEntry.Text,
                TextColor = selectedColor   
                
            };

            using (SQLiteConnection con = new SQLiteConnection(App.DatabaseLocation))
            {
                con.CreateTable<Tasks>();
                int row = con.Insert(tk);
                con.Close();
                if (row > 0)
                {
                    DisplayAlert("Successfull", "data Added ", "OK");
                }
                else
                {
                    DisplayAlert("Failed", "No data Added!", "OK");
                }

               
                

            }

        }
    }
}