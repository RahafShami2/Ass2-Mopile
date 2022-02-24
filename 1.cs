using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App4
{
    public partial class MainPage : ContentPage
    {

        private void button2_Clicked(object sender, EventArgs e)
        {
                    Browser.Source = " https://www.google.it/";

     
        }

        private void button1_Clicked(object sender, EventArgs e)
        {
            Browser.Source = "https://zajel.najah.edu/";
        }
        public MainPage()
        {
            InitializeComponent();
            Browser.Source = "https://www.najah.edu/en/";


        }


    }
}
