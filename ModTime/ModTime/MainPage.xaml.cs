using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ModTime
{
    public partial class MainPage : ContentPage
    {
        // create constant for seconds
        const int SECONDS = 60;
        public MainPage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// create integer for the seconds, userSEconds, and minutes
        /// create constant for the minutes = 60
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnConvert_Clicked(object sender, EventArgs e)
        {
            //declare variables for userSeconds minutes and seconds
            int userSeconds, minutes, seconds;
            // validate input to see if the user put an integer in the seconds entry
          if(int.TryParse(EntSeconds.Text, out userSeconds))
            {
                // set minutes from user input
                minutes =  userSeconds / SECONDS;
                // set seconds from user input 
                seconds = userSeconds % SECONDS;

                // show the time
                // if minutes >= 10 or not see if seconds are too, then assign accordingly
                if (minutes >= 10)
                {
                    if (seconds >= 10)
                    {
                    // if seconds and minutes are greater than 10 then we don't need to add a zero on the seconds or minutes
                        Time.Text = minutes + ":" + seconds;
                    }
                    else
                    {
                    //seconds are less than 10 so we need to add a 0 to the beginning of them
                        Time.Text = minutes + ":0" + seconds;
                    }
               
                }
                // if minutes are less than 10 then we will see if seconds are too
                else
                {
                    if (seconds >= 10)
                    {
                        //seconds are greater than 10 so we don't need a zero, minutes do need a zero because they are less than 10
                        Time.Text = "0" + minutes + ":" + seconds;
                    }
                    else
                    {
                        // both minutes and seconds are less than 10 and will both require a zero concatenated onto them.
                        Time.Text = "0" + minutes + ":0" + seconds;

                    }

                }
                
            }
          //display alert  if no integer entered in seconds entry
          else
            {
                DisplayAlert("Invalid input", "Please only use an integer when entering seconds", "Close");
            }
        }
    }
}
