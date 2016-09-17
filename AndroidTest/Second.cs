using System;
using System.Collections.Generic;

using Android.App;
using Android.OS;
using Android.Widget;
using AndroidTest.Service;
using Data.Models;
using DataModels;
using RestSharp;

namespace AndroidTest
{
    [Activity(Label = "Second")]
    public class Second : Activity
    {

        TextView Ques1, Ques2, Ques3, Ques4, Ques5, Ques6, Ques7, Ques8, Ques9, Ques10;

        RadioButton a, a2, a3, a4, a5, a6, a7, a8, a9, a10, b, b2, b3, b4, b5, b6, b7, b8, b9, b10,
            c, c2, c3, c4, c5, c6, c7, c8, c9, c10, d, d2, d3, d4, d6, e2, e4, e6;

        RadioGroup Choices1, Choices2, Choices3, Choices4, Choices5, Choices6, Choices7, Choices8, Choices9, Choices10;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Second);

            Ques1 = FindViewById<TextView>(Resource.Id.Quest1);
            Ques2 = FindViewById<TextView>(Resource.Id.Quest2);
            Ques3 = FindViewById<TextView>(Resource.Id.Quest3);
            Ques4 = FindViewById<TextView>(Resource.Id.Quest4);
            Ques5 = FindViewById<TextView>(Resource.Id.Quest5);
            Ques6 = FindViewById<TextView>(Resource.Id.Quest6);
            Ques7 = FindViewById<TextView>(Resource.Id.Quest7);
            Ques8 = FindViewById<TextView>(Resource.Id.Quest8);
            Ques9 = FindViewById<TextView>(Resource.Id.Quest9);
            Ques10 = FindViewById<TextView>(Resource.Id.Quest10);

            ////////////////////////////////////////
            Button Procceed = FindViewById<Button>(Resource.Id.Proc2);
            Procceed.Click += Procceed_Click;

            ////Radiobuttons
            a = FindViewById<RadioButton>(Resource.Id.a);
            a2 = FindViewById<RadioButton>(Resource.Id.a2);
            a3 = FindViewById<RadioButton>(Resource.Id.a3);
            a4 = FindViewById<RadioButton>(Resource.Id.a4);
            a5 = FindViewById<RadioButton>(Resource.Id.a5);
            a6 = FindViewById<RadioButton>(Resource.Id.a6);
            a7 = FindViewById<RadioButton>(Resource.Id.a7);
            a8 = FindViewById<RadioButton>(Resource.Id.a8);
            a9 = FindViewById<RadioButton>(Resource.Id.a9);
            a10 = FindViewById<RadioButton>(Resource.Id.a10);

            b = FindViewById<RadioButton>(Resource.Id.b);
            b2 = FindViewById<RadioButton>(Resource.Id.b2);
            b3 = FindViewById<RadioButton>(Resource.Id.b3);
            b4 = FindViewById<RadioButton>(Resource.Id.b4);
            b5 = FindViewById<RadioButton>(Resource.Id.b5);
            b6 = FindViewById<RadioButton>(Resource.Id.b6);
            b7 = FindViewById<RadioButton>(Resource.Id.b7);
            b8 = FindViewById<RadioButton>(Resource.Id.b8);
            b9 = FindViewById<RadioButton>(Resource.Id.b9);
            b10 = FindViewById<RadioButton>(Resource.Id.b10);

            c = FindViewById<RadioButton>(Resource.Id.c);
            c2 = FindViewById<RadioButton>(Resource.Id.c2);
            c3 = FindViewById<RadioButton>(Resource.Id.c3);
            c4 = FindViewById<RadioButton>(Resource.Id.c4);
            c5 = FindViewById<RadioButton>(Resource.Id.c5);
            c6 = FindViewById<RadioButton>(Resource.Id.c6);
            c7 = FindViewById<RadioButton>(Resource.Id.c7);
            c8 = FindViewById<RadioButton>(Resource.Id.c8);
            c9 = FindViewById<RadioButton>(Resource.Id.c9);
            c10 = FindViewById<RadioButton>(Resource.Id.c10);

            d = FindViewById<RadioButton>(Resource.Id.d);
            d2 = FindViewById<RadioButton>(Resource.Id.d2);
            d3 = FindViewById<RadioButton>(Resource.Id.d3);
            d4 = FindViewById<RadioButton>(Resource.Id.d4);
            d6 = FindViewById<RadioButton>(Resource.Id.d6);
            e2 = FindViewById<RadioButton>(Resource.Id.e2);
            e4 = FindViewById<RadioButton>(Resource.Id.e4);
            e6 = FindViewById<RadioButton>(Resource.Id.e6);

            Choices1 = FindViewById<RadioGroup>(Resource.Id.Choices1);
            Choices2 = FindViewById<RadioGroup>(Resource.Id.Choices2);
            Choices3 = FindViewById<RadioGroup>(Resource.Id.Choices3);
            Choices4 = FindViewById<RadioGroup>(Resource.Id.Choices4);
            Choices5 = FindViewById<RadioGroup>(Resource.Id.Choices5);
            Choices6 = FindViewById<RadioGroup>(Resource.Id.Choices6);
            Choices7 = FindViewById<RadioGroup>(Resource.Id.Choices7);
            Choices8 = FindViewById<RadioGroup>(Resource.Id.Choices8);
            Choices9 = FindViewById<RadioGroup>(Resource.Id.Choices9);
            Choices10 = FindViewById<RadioGroup>(Resource.Id.Choices10);

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
                    case 1: Ques1.Text = string.Format("{0}", question.Question); break;
                    case 2: Ques2.Text = string.Format("{0}", question.Question); break;
                    case 3: Ques3.Text = string.Format("{0}", question.Question); break;
                    case 4: Ques4.Text = string.Format("{0}", question.Question); break;
                    case 5: Ques5.Text = string.Format("{0}", question.Question); break;
                    case 6: Ques6.Text = string.Format("{0}", question.Question); break;
                    case 7: Ques7.Text = string.Format("{0}", question.Question); break;
                    case 8: Ques8.Text = string.Format("{0}", question.Question); break;
                    case 9: Ques9.Text = string.Format("{0}", question.Question); break;
                    case 10: Ques10.Text = string.Format("{0}", question.Question); break;
                    
                }
            }
        }



        private void Procceed_Click(object sender, EventArgs e)
        {


            var datas = new SurveyData();


            if (a.Text == "" | a2.Text == "" | a3.Text == "" | a4.Text == "" | a5.Text == "" | a6.Text == "" | a7.Text == "" | a8.Text == "" |
                a9.Text == "" | a10.Text == "" | b.Text == "" | b2.Text == "" | b3.Text == "" | b4.Text == "" | b5.Text == "" | b6.Text == "" |
                b7.Text == "" | b8.Text == "" | b9.Text == "" | b10.Text == "" | c.Text == "" | c2.Text == "" | c3.Text == "" | c4.Text == "" |
                c5.Text == "" | c6.Text == "" | c7.Text == "" | c8.Text == "" | c9.Text == "" | c10.Text == "" | d.Text == "" | d2.Text == "" |
                d3.Text == "" | d4.Text == "" | d6.Text == "" | e2.Text == "" | e4.Text == "" | e6.Text == "" )
            {
                Toast.MakeText(this, "Please answer evrything", ToastLength.Short).Show();
            }
            else if (a.Checked)  {datas.Question1 = a.Text;}
            else if (b.Checked) { datas.Question1 = b.Text;}
            else if (c.Checked) { datas.Question1 = c.Text;}
            else if (d.Checked) { datas.Question1 = d.Text;}

                if (a2.Checked) { datas.Question2 = a2.Text; }
            else if (b2.Checked) { datas.Question2 = b2.Text; }
            else if (c2.Checked) { datas.Question2 = c2.Text; }
            else if (d2.Checked) { datas.Question2 = d2.Text; }
            else if (e2.Checked) { datas.Question2 = e2.Text; }

                 if (a3.Checked) { datas.Question3 = a3.Text; }
            else if (b3.Checked) { datas.Question3 = b3.Text; }
            else if (c3.Checked) { datas.Question3 = c3.Text; }
            else if (d3.Checked) { datas.Question3 = d3.Text; }

                 if (a4.Checked) { datas.Question4 = a4.Text; }
            else if (b4.Checked) { datas.Question4 = b4.Text; }
            else if (c4.Checked) { datas.Question4 = c4.Text; }
            else if (d4.Checked) { datas.Question4 = d4.Text; }
            else if (e4.Checked) { datas.Question4 = e4.Text; }

                if (a5.Checked) { datas.Question5 = a5.Text; }
            else if (b5.Checked) { datas.Question5 = b5.Text; }
            else if (c5.Checked) { datas.Question5 = c5.Text; }

                if (a6.Checked) { datas.Question6 = a6.Text; }
            else if (b6.Checked) { datas.Question6 = b6.Text; }
            else if (c6.Checked) { datas.Question6 = c6.Text; }
            else if (d6.Checked) { datas.Question6 = d6.Text; }
            else if (e6.Checked) { datas.Question6 = e6.Text; }

                 if (a7.Checked) { datas.Question7 = a7.Text; }
            else if (b7.Checked) { datas.Question7 = b7.Text; }
            else if (c7.Checked) { datas.Question7 = c7.Text; }

                  if (a8.Checked) { datas.Question8 = a8.Text; }
            else if (b8.Checked) { datas.Question8 = b8.Text; }
            else if (c8.Checked) { datas.Question8 = c8.Text; }

                if (a9.Checked) { datas.Question9 = a9.Text; }
            else if (b9.Checked) { datas.Question9 = b9.Text; }
            else if (c9.Checked) { datas.Question9 = c9.Text; }

                  if (a10.Checked) { datas.Question10 = a10.Text;}
            else if (b10.Checked) { datas.Question10 = b10.Text; }
            else if (c10.Checked) { datas.Question10 = c10.Text; }


            var res = surveyData(datas);


            StartActivity(typeof(Third));
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


//RadioButton chk1 = FindViewById<RadioButton>(Choices1.CheckedRadioButtonId);
//RadioButton chk2 = FindViewById<RadioButton>(Choices2.CheckedRadioButtonId);
//RadioButton chk3 = FindViewById<RadioButton>(Choices3.CheckedRadioButtonId);
//RadioButton chk4 = FindViewById<RadioButton>(Choices4.CheckedRadioButtonId);
//RadioButton chk5 = FindViewById<RadioButton>(Choices5.CheckedRadioButtonId);
//RadioButton chk6 = FindViewById<RadioButton>(Choices6.CheckedRadioButtonId);
//RadioButton chk7 = FindViewById<RadioButton>(Choices7.CheckedRadioButtonId);
//RadioButton chk8 = FindViewById<RadioButton>(Choices8.CheckedRadioButtonId);
//RadioButton chk9 = FindViewById<RadioButton>(Choices9.CheckedRadioButtonId);
//RadioButton chk10 = FindViewById<RadioButton>(Choices10.CheckedRadioButtonId);