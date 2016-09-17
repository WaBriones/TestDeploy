using System;
using Android.App;
using Android.Widget;
using Android.OS;
using RestSharp;
using AndroidTest.Service;
using Data.Models;

namespace AndroidTest
{
    [Activity(Label = "AndroidTest", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);


            SetContentView(Resource.Layout.dialog);
            Button Start = FindViewById<Button>(Resource.Id.btnGetStarted);
            Start.Click += Start_Click;
         
        }

        private void Start_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(Second));
        }
    }
}

