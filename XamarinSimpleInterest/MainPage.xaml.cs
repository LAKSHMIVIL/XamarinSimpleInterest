using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinSimpleInterest
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }
        public async void Simpleinterest(object sender, EventArgs e)
        {
            iname.Text = "" + int.Parse(pname.Text) * int.Parse(rname.Text) * int.Parse(tname.Text) / 100;

        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            
        }
    }
}
