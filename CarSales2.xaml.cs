using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace CarSale_DodgyBrothers
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CarSales2 : Page
    {
        public CarSales2()
        {
            this.InitializeComponent();
        }


        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            double GST_RATE;
            double subcost;
            double GST_Tax;
            double finalcost;
            subcost = double.Parse(price.Text) - double.Parse(tradeIn.Text);
            GST_RATE = 0.1;
            GST_Tax = subcost * GST_RATE;
            finalcost = subcost + GST_Tax;

            SubAmountText.Text = subcost.ToString();
            GstText.Text = GST_Tax.ToString();
            FinalAmountText.Text = finalcost.ToString();
        }


        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            name.Text = "";
            phone.Text = "";
            price.Text = "";
            tradeIn.Text = "";
            SubAmountText.Text = "";
            GstText.Text = "";
            FinalAmountText.Text = "";
            phone.IsEnabled = true;
            name.IsEnabled = true;
            name.Focus(FocusState.Programmatic);
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            phone.IsEnabled = false;
            name.IsEnabled = false;
            price.Focus(FocusState.Programmatic);
        }
    }
}
