using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TravelRecordApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
        void LoginButton_Clicked(object sender,EventArgs e)
        {
            bool isEmailEmpty = string.IsNullOrEmpty(txbEmail.Text);
            bool isPasswordEmpty = string.IsNullOrEmpty(txbPassword.Text);

            if (!isEmailEmpty && !isPasswordEmpty)
            {
                Navigation.PushAsync(new HomePage());
            }
            else
            {
                
            }
        }
	}
}
