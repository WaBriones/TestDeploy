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
using Java.Lang;
using RestSharp;

namespace AndroidTest
{
    [Activity(Label = "Questionaire")]
    public class Questionaire : Activity
    {
        LinearLayout mlayout;

        //ScrollView mSview;

        TableLayout mTblayout;
        RadioGroup rdg;
        TextView textView;
        EditText edtext;
        RadioButton radioButton;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Questionaire);

            mlayout = FindViewById<LinearLayout>(Resource.Id.mlayout);
            
            var questions = GetQuestionsC();

            //  mTblayout = FindViewById<TableLayout>(Resource.Id.mTbllayout);
            textView = new TextView(this);
            textView.SetTextAppearance(Android.Resource.Attribute.TextAppearanceMedium);
            textView.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent);
            textView.Text = "Wawa";
            textView.Id = 1;

            mlayout.AddView(textView);
            //foreach (var question in questions)
            //{

            //    textView = new TextView(this);
            //    textView.SetTextAppearance(Android.Resource.Attribute.TextAppearanceMedium);
            //    textView.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent);
            //    textView.Text = question.Question;
            //    textView.Id = question.QuestionID;

            //    mlayout.AddView(textView);

            //    //rdg = new RadioGroup(this);
            //    //rdg.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent);
            //    //rdg.Id = question.QuestionID;

            //    //foreach (var choice in question.Choices)
            //    //{
            //    //    switch (choice.QuestionTypeID)
            //    //    {
            //    //        case 1:
            //    //            radioButton = new RadioButton(this);
            //    //            radioButton.Id = choice.ChoicesID;
            //    //            radioButton.Text = choice.ChoicesLabel;

            //    //            rdg.AddView(radioButton);
            //    //            break;
            //    //        case 2:
            //    //            edtext = new EditText(this);
            //    //            edtext.Id = choice.ChoicesID;
            //    //            edtext.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent);
            //    //            edtext.SetBackgroundResource(Resource.Animation.edit_text_style);

            //    //            mTblayout.AddView(edtext);
            //    //            break;
            //    //    }
            //    //}

            //    //mTblayout.AddView(rdg);
            //}

            //mlayout.AddView(mTblayout);

            var button = new Button(this);
            button.Text = "FINISH";
            button.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent);
            button.SetBackgroundResource(Resource.Animation.ButtonSignUpStyle);
            button.Click += Button_Click;

            mlayout.AddView(button);
        }

        public void Button_Click(object sender, EventArgs e)
        {
            GetAnswer(mlayout);
        }

        public void GetAnswer(ViewGroup parent)
        {
           
            var datas = new SurveyData();
            List<SurveyAnswer> toSave = new List<SurveyAnswer>();
            
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
                            var rdgrp = (RadioGroup) childrens;

                            if (rdgrp.CheckedRadioButtonId > -1)
                            {
                                toSave.Add(new SurveyAnswer
                                {
                                    CustomerId = Intent.GetIntExtra("CustomerID", 0),
                                    QuestionId = rdgrp.Id,
                                    ChoiceId = rdgrp.CheckedRadioButtonId
                                });
                            }
                        }
                        else if(childrens is EditText)
                        {
                            var previousChildren = mTblayout.GetChildAt(x - 1);
                            var textBox = (EditText)childrens;

                            if (previousChildren is RadioGroup)
                            {
                                var rdgrp = (RadioGroup)previousChildren;

                                toSave.Add(new SurveyAnswer
                                {
                                    CustomerId = Intent.GetIntExtra("CustomerID", 0),
                                    QuestionId = rdgrp.CheckedRadioButtonId == -1 ? rdgrp.Id : 0,
                                    TextAnswer = textBox.Text
                                });
                            }
                            else
                            {
                                var txtView = (TextView) previousChildren;

                                toSave.Add(new SurveyAnswer
                                {
                                    CustomerId = Intent.GetIntExtra("CustomerID", 0),
                                    QuestionId = txtView.Id,
                                    TextAnswer = textBox.Text
                                });
                            }
                        }

                    }

                }
            }

            AddSurveyAnswer(toSave);
        }

        public List<Questions> GetQuestionsC()
        {
            var request = new RestRequest("questions/getQuestionsAndChoices");
            var questService = new QuestionService();
            var result = questService.ExecuteAsync<List<Questions>>(request);

            return result.Result;

        }

        private bool AddSurveyAnswer(List<SurveyAnswer> datas)
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