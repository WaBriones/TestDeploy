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
    [Activity(Label = "Questionaire")]
    public class Questionaire : Activity
    {
        LinearLayout mlayout,mroot;

        ScrollView mSview;

        TableLayout mTblayout;
        RadioGroup rdg;
        TextView textView;
        EditText edtext;
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

               questions =  GetQuestionsC();
               

                mTblayout = new TableLayout(this);
                mTblayout.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent);

                int i = 0;
                int z = 0;
                int e = 0;
                foreach (var question in questions)
                {

                    textView = new TextView(this);
                    textView.SetTextAppearance(Android.Resource.Attribute.TextAppearanceMedium);
                    textView.Text = question.Question;

                    mTblayout.AddView(textView);

                    rdg = new RadioGroup(this);
                    rdg.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent);
                    rdg.Id = z++;
                    
                    foreach (var choice in question.Choices)
                    {
                        switch (choice.QuestionTypeID)
                        {
                            case 1:
                                radioButton = new RadioButton(this);
                                radioButton.Id = i++;
                                radioButton.Text = choice.ChoicesLabel;
                                rdg.AddView(radioButton);
                                break;
                            case 2:
                                edtext = new EditText(this);
                                edtext.Id = e++;
                                edtext.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent);
                                edtext.SetBackgroundResource(Resource.Animation.edit_text_style);

                                
                                mTblayout.AddView(edtext);
                                

                              
                                break;
                        }
                    }

                    mTblayout.AddView(rdg);
                }

                mlayout.AddView(mTblayout);

                var button = new Button(this);
                button.Text = "FINISH";
                button.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent);
                button.SetBackgroundResource(Resource.Animation.ButtonSignUpStyle);
                button.Click += Button_Click;

                mlayout.AddView(button);
                mSview.AddView(mlayout);

                SetContentView(mSview);

               

            });
        }

        public void Button_Click(object sender, EventArgs e)
        {

            var datas = new SurveyData
            {
                Name = Intent.GetStringExtra("Name"),
                CustomerID = Intent.GetIntExtra("CustomerID", 0),
                SurveyNo = Intent.GetIntExtra("SurveyNo", 0),
                Age = Intent.GetIntExtra("Age", 0),
                Gender = Intent.GetStringExtra("Gender"),
            };
         
            getAnswer(mlayout);
            var sf = surveyData(datas);

        }

        public void getAnswer(ViewGroup parent)
        {
            RunOnUiThread(() =>
            {
                var datas = new SurveyData();

                for (int i = 0; i < parent.ChildCount; i++)
                {
                    View child = parent.GetChildAt(i);
                    if (child is TableLayout)
                    {
                        var count = (mTblayout as ViewGroup);
                        for (int x = 0; x < mTblayout.ChildCount; x++)
                        {
                            View childrens = mTblayout.GetChildAt(x);

                            if (childrens is RadioGroup)
                            {
                                var rdgrp = (RadioGroup)childrens;

                                RadioButton radio = FindViewById<RadioButton>(rdgrp.CheckedRadioButtonId);

                                datas.Question1 = radio.Text;

                                switch (rdgrp.Id)
                                {
                                    case 2:
                                        break;
                                    case 4:
                                        datas.Question2 = radio.Text;
                                        break;
                                    case 6:
                                        datas.Question3 = radio.Text;
                                        break;
                                    case 8:
                                        datas.Question4 = radio.Text;
                                        break;
                                    case 5:
                                        datas.Question5 = radio.Text;
                                        break;

                                }

                                //        //datas.Question6 = radio.Text;
                                //        //datas.Question7 = radio.Text;
                                //        //datas.Question8 = radio.Text;
                                //        //datas.Question9 = radio.Text;
                                //        //datas.Question10 = radio.Text;
                                //        //datas.Question11 = radio.Text;
                                //        //datas.Question12 = radio.Text;
                                //        //datas.Question13 = radio.Text;
                                //        //datas.Question14 = radio.Text;
                                //        //datas.Question15 = radio.Text;
                                //        //datas.Question16 = radio.Text;
                                //        //datas.Question24 = radio.Text;
                                //        //datas.Question25 = radio.Text;
                                //        //datas.Question26 = radio.Text;
                                //        //datas.Question27 = radio.Text;
                                //        //datas.Question28 = radio.Text;
                                //        //datas.Question29 = radio.Text;
                                //        //datas.Question30 = radio.Text;

                                //    }
                                //else if(childrens is EditText)
                                //    {
                                //        var edittext = (EditText)childrens;

                                //        datas.Question17 = edittext.Text;
                                //        datas.Question18 = edittext.Text;
                                //        datas.Question19 = edittext.Text;
                                //        datas.Question20 = edittext.Text;
                                //        datas.Question21 = edittext.Text;
                                //        datas.Question22 = edittext.Text;
                                //        datas.Question23 = edittext.Text;
                                //    }
                            }

                        }

                    }
                }
            });
        }

        //public async void GetAll()
        //{
        //    var request = new RestRequest("questions/getall");
        //    var questService = new QuestionService();
        //    var result = questService.ExecuteAsync<List<Questions>>(request);

        //    foreach (var question in result.Result)
        //    {

        //        switch (question.QuestionID)
        //        {
        //            case 1: textView.Text = string.Format("{0}", question.Question); break;
        //            case 2: textView.Text = string.Format("{0}", question.Question); break;
        //                //case 3: Ques3.Text = string.Format("{0}", question.Question); break;
        //                //case 4: Ques4.Text = string.Format("{0}", question.Question); break;
        //                //case 5: Ques5.Text = string.Format("{0}", question.Question); break;
        //                //case 6: Ques6.Text = string.Format("{0}", question.Question); break;
        //                //case 7: Ques7.Text = string.Format("{0}", question.Question); break;
        //                //case 8: Ques8.Text = string.Format("{0}", question.Question); break;
        //                //case 9: Ques9.Text = string.Format("{0}", question.Question); break;
        //                //case 10: Ques10.Text = string.Format("{0}", question.Question); break;

        //        }
        //    }

        //}

        public List<Questions> GetQuestionsC()
        {
            var request = new RestRequest("questions/getQuestionsAndChoices");
            var questService = new QuestionService();
            var result = questService.ExecuteAsync<List<Questions>>(request);

            return result.Result;

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