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
        TextView Ques11, Ques12, Ques13, Ques14, Ques15, Ques16, Ques17, Ques18, Ques19, Ques20;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Third);

            Ques11 = FindViewById<TextView>(Resource.Id.Quest11);
            Ques12 = FindViewById<TextView>(Resource.Id.Quest12);
            Ques13 = FindViewById<TextView>(Resource.Id.Quest13);
            Ques14 = FindViewById<TextView>(Resource.Id.Quest14);
            Ques15 = FindViewById<TextView>(Resource.Id.Quest15);
            Ques16 = FindViewById<TextView>(Resource.Id.Quest16);
            Ques17 = FindViewById<TextView>(Resource.Id.Quest17);
            Ques18 = FindViewById<TextView>(Resource.Id.Quest18);
            Ques19 = FindViewById<TextView>(Resource.Id.Quest19);
            Ques20 = FindViewById<TextView>(Resource.Id.Quest20);

            ///Buttons
            Button Procceed = FindViewById<Button>(Resource.Id.Proc3);
            Procceed.Click += Procceed_Click;


            Get11();
            Get12();
            Get13();
            Get14();
            Get15();
            Get16();
            Get17();
            Get18();
            Get19();
            Get20();
        }

        public async void Get11()
        {
            var request = new RestRequest("my/MyGet/question11");
            request.AddUrlSegment("id", "45");
            var questService = new QuestionService();
            var result = questService.ExecuteAsync<Questions>(request);

            Ques11.Text = (string.Format("{0}", result.Result.Question));
        }

        public async void Get12()
        {
            var request = new RestRequest("my/MyGet/question12");
            request.AddUrlSegment("id", "45");
            var questService = new QuestionService();
            var result = questService.ExecuteAsync<Questions>(request);

            Ques12.Text = (string.Format("{0}", result.Result.Question));
        }

        public async void Get13()
        {
            var request = new RestRequest("my/MyGet/question13");
            request.AddUrlSegment("id", "45");
            var questService = new QuestionService();
            var result = questService.ExecuteAsync<Questions>(request);

            Ques13.Text = (string.Format("{0}", result.Result.Question));
        }

        public async void Get14()
        {
            var request = new RestRequest("my/MyGet/question14");          
            var questService = new QuestionService();
            var result = questService.ExecuteAsync<Questions>(request);

            Ques14.Text = (string.Format("{0}", result.Result.Question));
        }

        public async void Get15()
        {
            var request = new RestRequest("my/MyGet/question15");
            var questService = new QuestionService();
            var result = questService.ExecuteAsync<Questions>(request);

            Ques15.Text = (string.Format("{0}", result.Result.Question));
        }

        public async void Get16()
        {
            var request = new RestRequest("my/MyGet/question16");           
            var questService = new QuestionService();
            var result = questService.ExecuteAsync<Questions>(request);

            Ques16.Text = (string.Format("{0}", result.Result.Question));
        }

        public async void Get17()
        {
            var request = new RestRequest("my/MyGet/question17");
            var questService = new QuestionService();
            var result = questService.ExecuteAsync<Questions>(request);

            Ques17.Text = (string.Format("{0}", result.Result.Question));
        }

        public async void Get18()
        {
            var request = new RestRequest("my/MyGet/question18");           
            var questService = new QuestionService();
            var result = questService.ExecuteAsync<Questions>(request);

            Ques18.Text = (string.Format("{0}", result.Result.Question));
        }

        public async void Get19()
        {
            var request = new RestRequest("my/MyGet/question19");           
            var questService = new QuestionService();
            var result = questService.ExecuteAsync<Questions>(request);

            Ques19.Text = (string.Format("{0}", result.Result.Question));
        }

        public async void Get20()
        {
            var request = new RestRequest("my/MyGet/question20");
            var questService = new QuestionService();
            var result = questService.ExecuteAsync<Questions>(request);

            Ques20.Text = (string.Format("{0}", result.Result.Question));
        }

        private void Procceed_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(Fourth));
           
            
        }
    }
}