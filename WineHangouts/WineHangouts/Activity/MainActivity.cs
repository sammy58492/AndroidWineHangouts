using Android.App;
using Android.Widget;
using Android.OS;
using System.Threading;

namespace WineHangouts
{
    [Activity(Label = "WineHangouts", MainLauncher = false, Theme = "@style/Theme.Splash", NoHistory = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
          
            //Display Splash Screen for 4 Sec  
            Thread.Sleep(4000);
            //Start Activity1 Activity  
            StartActivity(typeof(Login));
        }
    }
}

