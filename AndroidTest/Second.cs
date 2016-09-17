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

            Get1();
            Get2();
            Get3();
            Get4();
            Get5();
            Get6();
            Get7();
            Get8();
            Get9();
            Get10();

        }
  
        public async void Get1()
        {
            var request = new RestRequest("my/MyGet/{id}");
            request.AddUrlSegment("id", "45");
            var questService = new QuestionService();
            var result = questService.ExecuteAsync<Questions>(request);

            Ques1.Text = (string.Format("{0}", result.Result.Question));
        }

        public async void Get2()
        {
            var request = new RestRequest("my/MyGet/question2");
            request.AddUrlSegment("id", "45");
            var questService = new QuestionService();
            var result = questService.ExecuteAsync<Questions>(request);

            Ques2.Text = (string.Format("{0}", result.Result.Question));
        }

        public async void Get3()
        {
            var request = new RestRequest("my/MyGet/question3");
            request.AddUrlSegment("id", "45");
            var questService = new QuestionService();
            var result = questService.ExecuteAsync<Questions>(request);

            Ques3.Text = (string.Format("{0}", result.Result.Question));
        }

        public async void Get4()
        {
            var request = new RestRequest("my/MyGet/question4");
           
            var questService = new QuestionService();
            var result = questService.ExecuteAsync<Questions>(request);

            Ques4.Text = (string.Format("{0}", result.Result.Question));
        }

        public async void Get5()
        {
            var request = new RestRequest("my/MyGet/question5");
           
            var questService = new QuestionService();
            var result = questService.ExecuteAsync<Questions>(request);

            Ques5.Text = (string.Format("{0}", result.Result.Question));
        }

        public async void Get6()
        {
            var request = new RestRequest("my/MyGet/question6");
           
            var questService = new QuestionService();
            var result = questService.ExecuteAsync<Questions>(request);

            Ques6.Text = (string.Format("{0}", result.Result.Question));
        }

        public async void Get7()
        {
            var request = new RestRequest("my/MyGet/question7");
          
            var questService = new QuestionService();
            var result = questService.ExecuteAsync<Questions>(request);

            Ques7.Text = (string.Format("{0}", result.Result.Question));
        }

        public async void Get8()
        {
            var request = new RestRequest("my/MyGet/question8");
          
            var questService = new QuestionService();
            var result = questService.ExecuteAsync<Questions>(request);

            Ques8.Text = (string.Format("{0}", result.Result.Question));
        }

        public async void Get9()
        {
            var request = new RestRequest("my/MyGet/question9");
            
            var questService = new QuestionService();
            var result = questService.ExecuteAsync<Questions>(request);

            Ques9.Text = (string.Format("{0}", result.Result.Question));
        }

        public async void Get10()
        {
            var request = new RestRequest("my/MyGet/question10");
           
            var questService = new QuestionService();
            var result = questService.ExecuteAsync<Questions>(request);

            Ques10.Text = (string.Format("{0}", result.Result.Question));
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