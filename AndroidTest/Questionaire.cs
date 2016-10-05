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
    [Activity(Label = "Questionaire", MainLauncher = true, Icon = "@drawable/ZarksBurger")]
    public class Questionaire : Activity
    {
        LinearLayout mlayout,mroot;

        ScrollView mSview;

        TableLayout mTblayout;
        RadioGroup rdg;
        TextView textView;
        RadioButton radioButton;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);


            RunOnUiThread(() =>
            {

                mlayout = new LinearLayout(this)
                {
                    Orientation = Orientation.Vertical,
                    LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent),
                };


                mroot = new LinearLayout(this)
                {
                    Orientation = Orientation.Vertical,
                    LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent),
                };

                mSview = new ScrollView(this)
                {
                    LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent),
                };

                //mlayout.AddView(mSview);


                var questions = new List<Questions>
                {
                    
                };

                GetQuestionsC();
               

                mTblayout = new TableLayout(this);
                mTblayout.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent);


                foreach (var question in questions)
                {

                    textView = new TextView(this);
                    textView.Text = question.Question;

                    mTblayout.AddView(textView);

                    rdg = new RadioGroup(this);
                    rdg.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent);

                    foreach (var choice in question.Choices)
                    {
                        switch (choice.QuestionTypeID)
                        {
                            case 1:

                                break;
                            case 2:
                                radioButton = new RadioButton(this);
                                radioButton.Text = choice.ChoicesLabel;
                                rdg.AddView(radioButton);
                                break;
                        }
                    }

                    mTblayout.AddView(rdg);
                }

                mlayout.AddView(mTblayout);

                var button = new Button(this);
                button.Text = "FINISH";
                button.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent);
                button.Click += Button_Click;

                mlayout.AddView(button);
                mSview.AddView(mlayout);

                SetContentView(mSview);

               

            });
        }

        private void Button_Click(object sender, EventArgs e)
        {
            
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
                    case 1: textView.Text = string.Format("{0}", question.Question); break;
                    case 2: textView.Text = string.Format("{0}", question.Question); break;
                        //case 3: Ques3.Text = string.Format("{0}", question.Question); break;
                        //case 4: Ques4.Text = string.Format("{0}", question.Question); break;
                        //case 5: Ques5.Text = string.Format("{0}", question.Question); break;
                        //case 6: Ques6.Text = string.Format("{0}", question.Question); break;
                        //case 7: Ques7.Text = string.Format("{0}", question.Question); break;
                        //case 8: Ques8.Text = string.Format("{0}", question.Question); break;
                        //case 9: Ques9.Text = string.Format("{0}", question.Question); break;
                        //case 10: Ques10.Text = string.Format("{0}", question.Question); break;

                }
            }

        }

        //public async void GetQuestionsC()
        //{
        //    var request = new RestRequest("questions/getQuestionsAndChoices");
        //    var questService = new QuestionService();
        //    var result = questService.ExecuteAsync<List<Questions>>(request);

        //    foreach(var question in R)

        //   // return result.Result;

        //}
    }
}