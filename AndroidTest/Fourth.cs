using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql;


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

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Fourth);

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



            Button Procceed = FindViewById<Button>(Resource.Id.Proc4);
            Procceed.Click += Procceed_Click;

            Get21();
            Get22();
            Get23();
            Get24();
            Get25();
            Get26();
            Get27();
            Get28();
            Get29();
            Get30();
            
        }

        public async void Get21()
        {
            var request = new RestRequest("my/MyGet/question21");
            request.AddUrlSegment("id", "45");
            var questService = new QuestionService();
            var result = questService.ExecuteAsync<Questions>(request);

            Ques21.Text = (string.Format("{0}", result.Result.Question));
        }

        public async void Get22()
        {
            var request = new RestRequest("my/MyGet/question22");
            request.AddUrlSegment("id", "45");
            var questService = new QuestionService();
            var result = questService.ExecuteAsync<Questions>(request);

            Ques22.Text = (string.Format("{0}", result.Result.Question));
        }

        public async void Get23()
        {
            var request = new RestRequest("my/MyGet/question23");
            request.AddUrlSegment("id", "45");
            var questService = new QuestionService();
            var result = questService.ExecuteAsync<Questions>(request);

            Ques23.Text = (string.Format("{0}", result.Result.Question));
        }

        public async void Get24()
        {
            var request = new RestRequest("my/MyGet/question24");
            var questService = new QuestionService();
            var result = questService.ExecuteAsync<Questions>(request);

            Ques24.Text = (string.Format("{0}", result.Result.Question));
        }

        public async void Get25()
        {
            var request = new RestRequest("my/MyGet/question25");
            var questService = new QuestionService();
            var result = questService.ExecuteAsync<Questions>(request);

            Ques25.Text = (string.Format("{0}", result.Result.Question));
        }

        public async void Get26()
        {
            var request = new RestRequest("my/MyGet/question26");
            var questService = new QuestionService();
            var result = questService.ExecuteAsync<Questions>(request);

            Ques26.Text = (string.Format("{0}", result.Result.Question));
        }

        public async void Get27()
        {
            var request = new RestRequest("my/MyGet/question27");
            var questService = new QuestionService();
            var result = questService.ExecuteAsync<Questions>(request);

            Ques27.Text = (string.Format("{0}", result.Result.Question));
        }

        public async void Get28()
        {
            var request = new RestRequest("my/MyGet/question28");
            var questService = new QuestionService();
            var result = questService.ExecuteAsync<Questions>(request);

            Ques28.Text = (string.Format("{0}", result.Result.Question));
        }

        public async void Get29()
        {
            var request = new RestRequest("my/MyGet/question29");
            var questService = new QuestionService();
            var result = questService.ExecuteAsync<Questions>(request);

            Ques29.Text = (string.Format("{0}", result.Result.Question));
        }

        public async void Get30()
        {
            var request = new RestRequest("my/MyGet/question30");
            var questService = new QuestionService();
            var result = questService.ExecuteAsync<Questions>(request);

            Ques30.Text = (string.Format("{0}", result.Result.Question));
        }


        private void Procceed_Click(object sender, EventArgs e)
        {
           
        }
    }
}