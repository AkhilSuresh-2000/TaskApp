﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TodoApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Startbtn_Clicked(object sender, EventArgs e)
        {
            //navigate to homepage
            Navigation.PushAsync(new HomePage());
        }
    }
}
