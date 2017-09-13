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
    [Activity(Label = "Activitylo")]
    public class Activitylo :Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Location);
            Button Top = FindViewById<Button>(Resource.Id.btnTop);
            Button Middle = FindViewById<Button>(Resource.Id.btnMiddle);
            Button Bottom =FindViewById<Button>(Resource.Id.btnBottom);
            var metrics = Resources.DisplayMetrics;
            int height = metrics.HeightPixels;
            height = height - (int)((360 * metrics.Density) / 3);
            height = height / 3;
            height = height - 17;
            Top.LayoutParameters.Height = height;
            Middle.LayoutParameters.Height = height;
            Bottom.LayoutParameters.Height = height;
            Top.SetBackgroundResource(Resource.Drawable.wall1);        
            Middle.SetBackgroundResource(Resource.Drawable.pp1);       
            Bottom.SetBackgroundResource(Resource.Drawable.scacus1);
         }
    }
}