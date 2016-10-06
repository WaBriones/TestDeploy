using System;
using Android.App;
using Android.OS;
using Android.Widget;
using RestSharp;
using AndroidTest.Service;
using Data.Models;
using Android.Content;

namespace AndroidTest
{



    [Activity(Label = "CustomerInput", MainLauncher = true, Icon = "@drawable/ZarksBurger")]
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

            RadioButton sex = FindViewById<RadioButton>(rGender.CheckedRadioButtonId);
            var CustInfo = new Customer()
            {
                Name = txtName.Text,
                Age = int.Parse(txtAge.Text)

            };

            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtAge.Text)|| string.IsNullOrWhiteSpace(rbtnMale.Text)|| string.IsNullOrWhiteSpace(rbtnFemale.Text))
            {
                Toast.MakeText(this, "Please enter your info!", ToastLength.Long).Show();
            }
            else
            {
                CustInfo.Gender = sex.Text;
            }

            var surveyData = Insert(CustInfo);

            Intent intent = new Intent(this, typeof(Questionaire));

            intent.PutExtra("CustomerID", surveyData.CustomerID);
            intent.PutExtra("Age", surveyData.Age);
            intent.PutExtra("SurveyNo", surveyData.SurveyNo);
            intent.PutExtra("Gender", surveyData.Gender);
            intent.PutExtra("Name", surveyData.Name);

            StartActivity(intent);
        }

        public SurveyData Insert(Customer customer)
        {
            var request = new RestRequest("post/customerInsert")
            {
                Method = Method.POST,
                RequestFormat = DataFormat.Json

            };
            request.AddJsonBody(customer);

            var questService = new CustomerService();
            var result = questService.ExecuteAsync<SurveyData>(request);

            return result.Result;

        }

    }
 
}