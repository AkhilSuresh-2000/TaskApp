using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Xamarin.Forms;
namespace TodoApp.Model
{
   public class Tasks
    {
        [PrimaryKey, AutoIncrement]
        public int TaskId { get; set; }

        [MaxLength(25)]
        public string Task { get; set; }

        [MaxLength(25)]
        public string Priority { get; set; }

        public string TextColor { get; set; }
    }
}
