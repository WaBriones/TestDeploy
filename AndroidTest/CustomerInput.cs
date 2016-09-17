using System;
using Android.App;
using Android.OS;
using Android.Widget;
using RestSharp;
using AndroidTest.Service;
using Data.Models;

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
            var CustInfo = new Customer()
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

            var a = Insert(CustInfo);
        }

        public bool Insert(Customer customer)
        {
            var request = new RestRequest("post/customerInsert")
            {
                Method = Method.POST,
                RequestFormat = DataFormat.Json

            };
            request.AddJsonBody(customer);

            var questService = new CustomerService();
            var result = questService.ExecuteAsync<bool>(request);

            return result.Result;
            
        }

    }
 
}