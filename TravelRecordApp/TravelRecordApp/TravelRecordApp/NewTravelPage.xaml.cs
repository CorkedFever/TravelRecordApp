using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRecordApp.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravelRecordApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NewTravelPage : ContentPage
	{
		public NewTravelPage ()
		{
			InitializeComponent ();
		}
        public void ToolbarItemSave_Clicked(object sender, EventArgs e)
        {
            try
            {
                Post post = new Post()
                {
                    Experience = txbExperienceEntry.Text
                };
                SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation);
                conn.CreateTable<Post>();
                int rows = conn.Insert(post);
                conn.Close();

                if (rows > 0)
                    DisplayAlert("Success","Experience succesfully inserted\r\n"+"Location: "+App.DatabaseLocation, "Ok");
                else
                {
                    DisplayAlert("Failure", "Experience failed inserted\r\n" + "Location: " + App.DatabaseLocation, "Ok");
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Error",ex.ToString(),"Ok");
            }



        }

    }
}