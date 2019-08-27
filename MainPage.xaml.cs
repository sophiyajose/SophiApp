using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SophiApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        double value1;
        double value2;
        double result;
        string operation;
        public MainPage()
        {
            InitializeComponent();

        }  
        private void OperatorClicked(object sender, EventArgs e)
        {
            if (entryLabel.Text != null)
            {
                value1 = double.Parse(entryLabel.Text);
                entryLabel.Text = null;
                operation = (sender as Button).Text;
            }
            OnAppearing();
        }
        private void ClearClicked(object sender, EventArgs e)
        {
            entryLabel.Text = null;
        }
        private void EqualtoClicked(object sender, EventArgs e)
        { 
           if (entryLabel.Text != null)
            {
                value2 = double.Parse(entryLabel.Text);
                entryLabel.Text = "";
                switch (operation)
                {
                    case "+":
                        result = value1 + value2;
                        break;
                    case "-":
                        result = value1 - value2;
                        break;
                    case "*":
                        result = value1 * value2;
                        break;
                    case "/":
                        result = value1 / value2;
                        break;
                }
                entryLabel.Text = result.ToString(); 
            }
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            entryLabel.Focus();
        }
    }
}
