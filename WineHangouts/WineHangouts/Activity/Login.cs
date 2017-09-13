using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace WineHangouts
{
    [Activity(Label = "WineHangouts")]
    public class Login : TabActivity
    {
        protected override void OnCreate(Bundle bundle)
        {

            base.OnCreate(bundle);
           
            SetContentView(Resource.Layout.Start);

            //var intent = new Intent(this, typeof(Activitylo));
            //intent.AddFlags(ActivityFlags.ClearTop);
            //var spec = TabHost.NewTabSpec("WhatsOn");
            //var draw = Resources.GetDrawable(Resource.Drawable.ic_tab_whats_on);
            //spec.SetIndicator("", draw);
            //spec.SetContent(intent);
            //TabHost.AddTab(spec);

            //intent = new Intent(this, typeof(Activity12));
            //intent.AddFlags(ActivityFlags.ClearTop);
            //spec = TabHost.NewTabSpec("Cart");
            //draw = Resources.GetDrawable(Resource.Drawable.ic_tab_speakers);
            //spec.SetIndicator("", draw);
            //spec.SetContent(intent);

            //TabHost.AddTab(spec);

            //intent = new Intent(this, typeof(SessionsActivity));
            //intent.AddFlags(ActivityFlags.ClearTop);
            //spec = TabHost.NewTabSpec("Login");
            //draw = Resources.GetDrawable(Resource.Drawable.ic_tab_sessions);
            //spec.SetIndicator("", draw);
            //spec.SetContent(intent);
            //TabHost.AddTab(spec);

            //intent = new Intent(this, typeof(MyScheduleActivity));
            //intent.AddFlags(ActivityFlags.ClearTop);
            //spec = TabHost.NewTabSpec("Contect");
            //draw = Resources.GetDrawable(Resource.Drawable.ic_tab_my_schedule);

            //spec.SetIndicator("", draw);
            //spec.SetContent(intent);
            //TabHost.AddTab(spec);

        }
    }
}