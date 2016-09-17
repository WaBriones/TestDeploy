using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using MySql;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidTest.Resources.Objects;
using MySql.Data.MySqlClient;
using System.Data;
using RestSharp;
using AndroidTest.Service;

namespace AndroidTest
{
    
   

    [Activity(Label = "CustomerInput")]
    public class CustomerInput : Activity
    {
        EditText txtName, txtAge;
        Button Proceed;
        RadioButton rbtnMale,rbtnFemale;
        RadioGroup rGender;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.First);

            txtName = FindViewById<EditText>(Resource.Id.Name);
            txtAge = FindViewById<EditText>(Resource.Id.Age);
            rGender = FindViewById<RadioGroup>(Resource.Id.rdgrp);

            rbtnMale = FindViewById<RadioButton>(Resource.Id.rbtnMale);
            rbtnFemale = FindViewById<RadioButton>(Resource.Id.rbtnFemale);
            Proceed = FindViewById<Button>(Resource.Id.Proc);
            Proceed.Click += Proceed_Click;

            
        }

        private void Proceed_Click(object sender, EventArgs e)
        {
           
          
            RadioButton sex =FindViewById<RadioButton>(rGender.CheckedRadioButtonId);
            var CustInfo = new CustomerInfo()
            {
                Name = txtName.Text,
                Age = int.Parse(txtAge.Text)
               
            };

            if (string.IsNullOrWhiteSpace(txtName.Text)| string.IsNullOrWhiteSpace(txtAge.Text)| string.IsNullOrWhiteSpace(rbtnMale.Text)| string.IsNullOrWhiteSpace(rbtnFemale.Text))
            {
                Toast.MakeText(this, "Please enter your info!", ToastLength.Long).Show();
            }
            if (sex.Text == "Male")
            {
                CustInfo.Gender = rbtnMale.Text;
            }
            else if (sex.Text == "Female")
            {
                CustInfo.Gender = rbtnFemale.Text;
            }
            
        }

        public async void Insert()
        {
            var request = new RestRequest("my/MyGet/customerInfo");

            var questService = new CustomerService();
            var result = questService.ExecuteAsync<CustomerInfo>(request);



            //var respone = new RestResponse<CustomerInfo>()



            //Ques4.Text = (string.Format("{0}", result.Result.Question));
        }

    }
 
}