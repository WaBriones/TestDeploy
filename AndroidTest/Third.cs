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
using AndroidTest.Service;
using Data.Models;
using RestSharp;

namespace AndroidTest
{
    [Activity(Label = "Third")]
    public class Third : Activity
    {
      

        RadioButton a11, a12, a13, a14, a15, a16, b11, b12, b13, b14, b15, b16,
           c11, c12, c13, c14, c15, c16, d11, d15, d16, e15, e16;

        

        

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        //    SetContentView(Resource.Layout.Third);

            

          
            ///Buttons
         //   Button Procceed = FindViewById<Button>(Resource.Id.Proc3);
         //   Procceed.Click += Procceed_Click;

            //Radio Buttons
            a11 = FindViewById<RadioButton>(Resource.Id.a11);
            a12 = FindViewById<RadioButton>(Resource.Id.a12);
            a13 = FindViewById<RadioButton>(Resource.Id.a13);
            a14 = FindViewById<RadioButton>(Resource.Id.a14);
            a15 = FindViewById<RadioButton>(Resource.Id.a15);
            a16 = FindViewById<RadioButton>(Resource.Id.a16);

            b11 = FindViewById<RadioButton>(Resource.Id.b11);
            b12 = FindViewById<RadioButton>(Resource.Id.b12);
            b13 = FindViewById<RadioButton>(Resource.Id.b13);
            b14 = FindViewById<RadioButton>(Resource.Id.b14);
            b15 = FindViewById<RadioButton>(Resource.Id.b15);
            b16 = FindViewById<RadioButton>(Resource.Id.b16);

            c11 = FindViewById<RadioButton>(Resource.Id.c11);
            c12 = FindViewById<RadioButton>(Resource.Id.c12);
            c13 = FindViewById<RadioButton>(Resource.Id.c13);
            c14 = FindViewById<RadioButton>(Resource.Id.c14);
            c15 = FindViewById<RadioButton>(Resource.Id.c15);
            c16 = FindViewById<RadioButton>(Resource.Id.c16);

            d11 = FindViewById<RadioButton>(Resource.Id.d11);
            d15 = FindViewById<RadioButton>(Resource.Id.d15);
            d16 = FindViewById<RadioButton>(Resource.Id.d16);

            e15 = FindViewById<RadioButton>(Resource.Id.e15);
            e16 = FindViewById<RadioButton>(Resource.Id.e16);

            //Radio Groups
   


            GetAll();

        }
        public async void GetAll()
        {
            var request = new RestRequest("questions/getall");
            var questService = new QuestionService();
            var result = questService.ExecuteAsync<List<Questions>>(request);

            foreach (var question in result.Result)
            {

                switch (question.QuestionID)
                {
                    case 11: Ques11.Text = string.Format("{0}", question.Question); break;
                    case 12: Ques12.Text = string.Format("{0}", question.Question); break;
                    case 13: Ques13.Text = string.Format("{0}", question.Question); break;
                    case 14: Ques14.Text = string.Format("{0}", question.Question); break;
                    case 15: Ques15.Text = string.Format("{0}", question.Question); break;
                    case 16: Ques16.Text = string.Format("{0}", question.Question); break;
                    case 17: Ques17.Text = string.Format("{0}", question.Question); break;
                    case 18: Ques18.Text = string.Format("{0}", question.Question); break;
                    case 19: Ques19.Text = string.Format("{0}", question.Question); break;
                    case 20: Ques20.Text = string.Format("{0}", question.Question); break;
                }
            }
        }

        private void Procceed_Click(object sender, EventArgs e)
        {


            RadioButton chk11 = FindViewById<RadioButton>(Choices11.CheckedRadioButtonId);
            RadioButton chk12 = FindViewById<RadioButton>(Choices12.CheckedRadioButtonId);
            RadioButton chk13 = FindViewById<RadioButton>(Choices13.CheckedRadioButtonId);
            RadioButton chk14 = FindViewById<RadioButton>(Choices14.CheckedRadioButtonId);
            RadioButton chk15 = FindViewById<RadioButton>(Choices15.CheckedRadioButtonId);
            RadioButton chk16 = FindViewById<RadioButton>(Choices16.CheckedRadioButtonId);


            var datas = new SurveyData();

            if (a11.Text == "" || a12.Text == "" || a13.Text == "" || a14.Text == "" || a15.Text == "" || a16.Text == "" ||
               b11.Text == "" || b12.Text == "" || b13.Text == "" || b14.Text == "" || b15.Text == "" || b16.Text == "" ||
               c11.Text == "" || c12.Text == "" || c13.Text == "" || c14.Text == "" || c15.Text == "" || c16.Text == "" ||
               d11.Text == "" || d15.Text == "" || d16.Text == "" || e15.Text == "" || e16.Text == "" || edit17.Text == "" ||
               edit18.Text == "" || edit19.Text == "" || edit20.Text == "")
            {
                Toast.MakeText(this, "Please answer evrything", ToastLength.Short).Show();
            }
            else
            {
                datas.Question11 = chk11.Text;
                datas.Question12 = chk12.Text;
                datas.Question13 = chk13.Text;
                datas.Question14 = chk14.Text;
                datas.Question15 = chk15.Text;
                datas.Question16 = chk16.Text;

                

                datas.Question17 = edit17.Text;
                datas.Question18 = edit18.Text;
                datas.Question19 = edit19.Text;
                datas.Question20 = edit20.Text;
            }
            var sf = surveyData(datas);

            StartActivity(typeof(Fourth));
           
            
        }
        private bool surveyData(SurveyData datas)
        {
            var request = new RestRequest("post/insertData")
            {
                Method = Method.POST,
                RequestFormat = DataFormat.Json

            };
            request.AddJsonBody(datas);

            var questService = new CustomerService();
            var result = questService.ExecuteAsync<bool>(request);

            return result.Result;
        }

    }
}




//if (a11.Checked) { datas.Question11 = a11.Text; }
//                else if (b11.Checked) { datas.Question11 = b11.Text; }
//                else if (c11.Checked) { datas.Question11 = c11.Text; }
//                else if (d11.Checked) { datas.Question11 = d11.Text; }

//                if (a12.Checked) { datas.Question12 = a12.Text; }
//                else if (b12.Checked) { datas.Question12 = b12.Text; }
//                else if (c12.Checked) { datas.Question12 = c12.Text; }

//                if (a13.Checked) { datas.Question13 = a13.Text; }
//                else if (b13.Checked) { datas.Question13 = b13.Text; }
//                else if (c13.Checked) { datas.Question13 = c13.Text; }


//                if (a14.Checked) { datas.Question14 = a14.Text; }
//                else if (b14.Checked) { datas.Question14 = b14.Text; }
//                else if (c14.Checked) { datas.Question14 = c14.Text; }

//                if (a15.Checked) { datas.Question15 = a15.Text; }
//                else if (b15.Checked) { datas.Question15 = b15.Text; }
//                else if (c15.Checked) { datas.Question15 = c15.Text; }
//                else if (d15.Checked) { datas.Question15 = d15.Text; }
//                else if (e15.Checked) { datas.Question15 = e15.Text; }

//                if (a16.Checked) { datas.Question15 = a16.Text; }
//                else if (b16.Checked) { datas.Question15 = b16.Text; }
//                else if (c16.Checked) { datas.Question15 = c16.Text; }
//                else if (d16.Checked) { datas.Question15 = d16.Text; }
//                else if (e16.Checked) { datas.Question15 = e16.Text; }