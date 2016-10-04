using System;
using Android.App;
using Android.Widget;
using Android.OS;
using RestSharp;
using AndroidTest.Service;
using System.Collections.Generic;
using Data.Models;

namespace AndroidTest
{
    [Activity(Label = "Zark's Survey")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

                      

            RunOnUiThread(() =>
            {
                SetContentView(Resource.Layout.Second);

                Button GetStart = FindViewById<Button>(Resource.Id.btnGetStarted);
            GetStart.Click += GetStart_Click;
            });

        }

        private void GetStart_Click(object sender, EventArgs e)
        {
           //startActivity(typeof(Second));
           // StartActivity(typeof(CustomerInput));
        }

    }

        
}

