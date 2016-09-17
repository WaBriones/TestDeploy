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
            RadioButton chk1 = FindViewById<RadioButton>(Choices1.CheckedRadioButtonId);
            RadioButton chk2 = FindViewById<RadioButton>(Choices2.CheckedRadioButtonId);
            RadioButton chk3 = FindViewById<RadioButton>(Choices3.CheckedRadioButtonId);
            RadioButton chk4 = FindViewById<RadioButton>(Choices4.CheckedRadioButtonId);
            RadioButton chk5 = FindViewById<RadioButton>(Choices5.CheckedRadioButtonId);
            RadioButton chk6 = FindViewById<RadioButton>(Choices6.CheckedRadioButtonId);
            RadioButton chk7 = FindViewById<RadioButton>(Choices7.CheckedRadioButtonId);
            RadioButton chk8 = FindViewById<RadioButton>(Choices8.CheckedRadioButtonId);
            RadioButton chk9 = FindViewById<RadioButton>(Choices9.CheckedRadioButtonId);
            RadioButton chk10 = FindViewById<RadioButton>(Choices10.CheckedRadioButtonId);


            StartActivity(typeof(Third));
        }
       

    }
}