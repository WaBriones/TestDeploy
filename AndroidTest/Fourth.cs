using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;

using Android.Views;
using Android.Widget;
using RestSharp;
using AndroidTest.Service;
using Data.Models;

namespace AndroidTest
{
    [Activity(Label = "Fourth")]
    public class Fourth : Activity
    {
        TextView Ques21, Ques22, Ques23, Ques24, Ques25, Ques26, Ques27, Ques28, Ques29, Ques30;

        RadioButton a24, a25, a26, a27, a28, a29, a30, b24, b25, b26, b27, b28, b29, b30,c24, c25, c26, c27, c28, c29, d25, d27, d28, d29, e25, e27, e28, e29;

        RadioGroup Choices24, Choices25, Choices26, Choices27, Choices28, Choices29, Choices30;

        EditText edit21, edit22, edit23;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
       //     SetContentView(Resource.Layout.Fourth);

            Ques21 = FindViewById<TextView>(Resource.Id.Quest21);
            Ques22 = FindViewById<TextView>(Resource.Id.Quest22);
            Ques23 = FindViewById<TextView>(Resource.Id.Quest23);
            Ques24 = FindViewById<TextView>(Resource.Id.Quest24);
            Ques25 = FindViewById<TextView>(Resource.Id.Quest25);
            Ques26 = FindViewById<TextView>(Resource.Id.Quest26);
            Ques27 = FindViewById<TextView>(Resource.Id.Quest27);
            Ques28 = FindViewById<TextView>(Resource.Id.Quest28);
            Ques29 = FindViewById<TextView>(Resource.Id.Quest29);
            Ques30 = FindViewById<TextView>(Resource.Id.Quest30);

            a24 = FindViewById<RadioButton>(Resource.Id.a24);
            a25 = FindViewById<RadioButton>(Resource.Id.a25);
            a26 = FindViewById<RadioButton>(Resource.Id.a26);
            a27 = FindViewById<RadioButton>(Resource.Id.a27);
            a28 = FindViewById<RadioButton>(Resource.Id.a28);
            a29 = FindViewById<RadioButton>(Resource.Id.a29);
            a30 = FindViewById<RadioButton>(Resource.Id.a30);

            b24 = FindViewById<RadioButton>(Resource.Id.b24);
            b25 = FindViewById<RadioButton>(Resource.Id.b25);
            b26 = FindViewById<RadioButton>(Resource.Id.b26);
            b27 = FindViewById<RadioButton>(Resource.Id.b27);
            b28 = FindViewById<RadioButton>(Resource.Id.b28);
            b29 = FindViewById<RadioButton>(Resource.Id.b29);
            b30 = FindViewById<RadioButton>(Resource.Id.b30);

            c24 = FindViewById<RadioButton>(Resource.Id.c24);
            c25 = FindViewById<RadioButton>(Resource.Id.c25);
            c26 = FindViewById<RadioButton>(Resource.Id.c26);
            c27 = FindViewById<RadioButton>(Resource.Id.c27);
            c28 = FindViewById<RadioButton>(Resource.Id.c28);
            c29 = FindViewById<RadioButton>(Resource.Id.c29);

            d25 = FindViewById<RadioButton>(Resource.Id.d25);
            d27 = FindViewById<RadioButton>(Resource.Id.d27);
            d28 = FindViewById<RadioButton>(Resource.Id.d28);
            d29 = FindViewById<RadioButton>(Resource.Id.d29);

            e25 = FindViewById<RadioButton>(Resource.Id.e25);
            e27 = FindViewById<RadioButton>(Resource.Id.e27);
            e28 = FindViewById<RadioButton>(Resource.Id.e28);
            e29 = FindViewById<RadioButton>(Resource.Id.e29);

            edit21 = FindViewById<EditText>(Resource.Id.Edit_Quest21);
            edit22 = FindViewById<EditText>(Resource.Id.Edit_Quest22);
            edit23 = FindViewById<EditText>(Resource.Id.Edit_Quest23);

            Choices24 = FindViewById<RadioGroup>(Resource.Id.Choices24);
            Choices25 = FindViewById<RadioGroup>(Resource.Id.Choices25);
            Choices26 = FindViewById<RadioGroup>(Resource.Id.Choices26);
            Choices27 = FindViewById<RadioGroup>(Resource.Id.Choices27);
            Choices28 = FindViewById<RadioGroup>(Resource.Id.Choices28);
            Choices29 = FindViewById<RadioGroup>(Resource.Id.Choices29);
            Choices30 = FindViewById<RadioGroup>(Resource.Id.Choices30);


  //          Button Procceed = FindViewById<Button>(Resource.Id.Proc4);
   //         Procceed.Click += Procceed_Click;

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
                    case 21: Ques21.Text = string.Format("{0}", question.Question); break;
                    case 22: Ques22.Text = string.Format("{0}", question.Question); break;
                    case 23: Ques23.Text = string.Format("{0}", question.Question); break;
                    case 24: Ques24.Text = string.Format("{0}", question.Question); break;
                    case 25: Ques25.Text = string.Format("{0}", question.Question); break;
                    case 26: Ques26.Text = string.Format("{0}", question.Question); break;
                    case 27: Ques27.Text = string.Format("{0}", question.Question); break;
                    case 28: Ques28.Text = string.Format("{0}", question.Question); break;
                    case 29: Ques29.Text = string.Format("{0}", question.Question); break;
                    case 30: Ques30.Text = string.Format("{0}", question.Question); break;
                   
                }
            }
        }


        private void Procceed_Click(object sender, EventArgs e)
        {
            RadioButton chk24 = FindViewById<RadioButton>(Choices24.CheckedRadioButtonId);
            RadioButton chk25 = FindViewById<RadioButton>(Choices25.CheckedRadioButtonId);
            RadioButton chk26 = FindViewById<RadioButton>(Choices26.CheckedRadioButtonId);
            RadioButton chk27 = FindViewById<RadioButton>(Choices27.CheckedRadioButtonId);
            RadioButton chk28 = FindViewById<RadioButton>(Choices28.CheckedRadioButtonId);
            RadioButton chk29 = FindViewById<RadioButton>(Choices29.CheckedRadioButtonId);
            RadioButton chk30 = FindViewById<RadioButton>(Choices30.CheckedRadioButtonId);

            var datas = new SurveyData()
            {
                Question21 = edit21.Text,
                Question22 = edit22.Text,
                Question23 = edit23.Text,

            };

            if (edit21.Text == "" | edit22.Text == "" | edit23.Text == "" | a24.Text == "" | a25.Text == "" | a26.Text == "" |
                a27.Text == "" | a28.Text == "" | a29.Text == "" | a30.Text == "" | b24.Text == "" | b25.Text == "" | b26.Text == "" |
                b27.Text == "" | b28.Text == "" | b29.Text == "" | b30.Text == "" | c24.Text == "" | c25.Text == "" | c26.Text == "" |
                c27.Text == "" | c28.Text == "" | c29.Text == "" | d25.Text == "" | d27.Text == "" | d28.Text == "" | d29.Text == "" | e25.Text == "" |
                e27.Text == "" | e28.Text == "" | e29.Text == "")
            {
                Toast.MakeText(this, "Please answer everthing", ToastLength.Short).Show();

            }

            else
            {
                if (a24.Checked) { datas.Question24 = a24.Text; }
                else if (b24.Checked) { datas.Question24 = a24.Text; }
                else if (c24.Checked) { datas.Question24 = a24.Text; }

                if (a25.Checked) { datas.Question25 = a25.Text; }
                else if (b25.Checked) { datas.Question25 = b25.Text;}
                else if (c25.Checked) { datas.Question25 = c25.Text;}
                else if (d25.Checked) { datas.Question25 = d25.Text; }
                else if (e25.Checked) { datas.Question25 = e25.Text;}

                if (a26.Checked) { datas.Question26 = a26.Text; }
                else if (b26.Checked) { datas.Question26 = b26.Text; }
                else if (b26.Checked) { datas.Question26 = c26.Text; }

                     if (a27.Checked) { datas.Question27 = a27.Text; }
                else if (b27.Checked) { datas.Question27 = b27.Text; }
                else if (c27.Checked) { datas.Question27 = c27.Text; }
                else if (d27.Checked) { datas.Question27 = d27.Text; }
                else if (e27.Checked) { datas.Question27 = e27.Text; }

                     if (a28.Checked) { datas.Question28 = a28.Text; }
                else if (b28.Checked) { datas.Question28 = b28.Text; }
                else if (c28.Checked) { datas.Question28 = c28.Text; }
                else if (d28.Checked) { datas.Question28 = d28.Text; }
                else if (e28.Checked) { datas.Question28 = e28.Text; }


                      if (a29.Checked) { datas.Question29 = a29.Text; }
                else if (b29.Checked) { datas.Question29 = b29.Text; }
                else if (c29.Checked) { datas.Question29 = c29.Text; }
                else if (d29.Checked) { datas.Question29 = d29.Text; }
                else if (e29.Checked) { datas.Question29 = e29.Text; }

                      if (a30.Checked) { datas.Question29 = a30.Text; }
                else if (b30.Checked) { datas.Question29 = b30.Text; }

            }
            var sf = surveyData(datas);

            StartActivity(typeof(last));

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