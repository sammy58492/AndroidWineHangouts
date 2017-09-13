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
    [Activity(Label = "Activity12")]
    public class Activity12 :Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);


            SetContentView(Resource.Layout.Hangouts);
            Button Top = FindViewById<Button>(Resource.Id.btnTop);
            Button Middle = FindViewById<Button>(Resource.Id.btnMiddle);
            Button Bottom = FindViewById<Button>(Resource.Id.btnBottom);
            Button Bottom1 = FindViewById<Button>(Resource.Id.btnBottom1);
            var metrics = Resources.DisplayMetrics;
            int height = metrics.HeightPixels;
            height = height - (int)((360 * metrics.Density) / 4);
            height = height / 4;
            height = height - 28;
         
            Top.LayoutParameters.Height = height;
            Middle.LayoutParameters.Height = height;
            Bottom.LayoutParameters.Height = height;
            Bottom1.LayoutParameters.Height = height;



            Top.SetBackgroundResource(Resource.Drawable.mt);

            Middle.SetBackgroundResource(Resource.Drawable.mr);

            Bottom.SetBackgroundResource(Resource.Drawable.mf);
            Bottom1.SetBackgroundResource(Resource.Drawable.ms);
        }
    }
}