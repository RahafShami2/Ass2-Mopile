using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App5
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button_Clicked(object sender, EventArgs e)
        {
          
            Label l = new Label();

            for (int year = 1990; year <= 2030; year++)
            {
                l.Text = year + "\n";
                layout.Children.Add(l);
            }
                 
        }
    }
}
    
