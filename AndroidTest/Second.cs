using System;
using System.Collections.Generic;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using AndroidTest.Service;
using RestSharp;
using Data.Models;

namespace AndroidTest
{
    [Activity(Label = "Second")]
    public class Second : Activity
    {

        TextView Ques1, Ques2, Ques3, Ques4, Ques5, Ques6, Ques7, Ques8, Ques9, Ques10;
        TextView Ques11, Ques12, Ques13, Ques14, Ques15, Ques16, Ques17, Ques18, Ques19, Ques20;
        TextView Ques21, Ques22, Ques23, Ques24, Ques25, Ques26, Ques27, Ques28, Ques29, Ques30;

        RadioGroup Choices1, Choices2, Choices3, Choices4, Choices5, Choices6, Choices7, Choices8, Choices9, Choices10;
        RadioGroup Choices11, Choices12, Choices13, Choices14, Choices15, Choices16;
        RadioGroup Choices24, Choices25, Choices26, Choices27, Choices28, Choices29, Choices30;

        EditText edit17, edit18, edit19, edit20;
        EditText edit21, edit22, edit23;

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

            ////////////////////////////////////////
            Button Procceed = FindViewById<Button>(Resource.Id.Proc2);
            Procceed.Click += Procceed_Click;

            ////RadioGroups
         
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
            Choices11 = FindViewById<RadioGroup>(Resource.Id.Choices11);
            Choices12 = FindViewById<RadioGroup>(Resource.Id.Choices12);
            Choices13 = FindViewById<RadioGroup>(Resource.Id.Choices13);
            Choices14 = FindViewById<RadioGroup>(Resource.Id.Choices14);
            Choices15 = FindViewById<RadioGroup>(Resource.Id.Choices15);
            Choices16 = FindViewById<RadioGroup>(Resource.Id.Choices16);

            edit17 = FindViewById<EditText>(Resource.Id.Edit_Quest17);
            edit18 = FindViewById<EditText>(Resource.Id.Edit_Quest18);
            edit19 = FindViewById<EditText>(Resource.Id.Edit_Quest19);
            edit20 = FindViewById<EditText>(Resource.Id.Edit_Quest20);

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
            RadioButton chk11 = FindViewById<RadioButton>(Choices11.CheckedRadioButtonId);
            RadioButton chk12 = FindViewById<RadioButton>(Choices12.CheckedRadioButtonId);
            RadioButton chk13 = FindViewById<RadioButton>(Choices13.CheckedRadioButtonId);
            RadioButton chk14 = FindViewById<RadioButton>(Choices14.CheckedRadioButtonId);
            RadioButton chk15 = FindViewById<RadioButton>(Choices15.CheckedRadioButtonId);
            RadioButton chk16 = FindViewById<RadioButton>(Choices16.CheckedRadioButtonId);
            //--
            RadioButton chk24 = FindViewById<RadioButton>(Choices24.CheckedRadioButtonId);
            RadioButton chk25 = FindViewById<RadioButton>(Choices25.CheckedRadioButtonId);
            RadioButton chk26 = FindViewById<RadioButton>(Choices26.CheckedRadioButtonId);
            RadioButton chk27 = FindViewById<RadioButton>(Choices27.CheckedRadioButtonId);
            RadioButton chk28 = FindViewById<RadioButton>(Choices28.CheckedRadioButtonId);
            RadioButton chk29 = FindViewById<RadioButton>(Choices29.CheckedRadioButtonId);
            RadioButton chk30 = FindViewById<RadioButton>(Choices30.CheckedRadioButtonId);

            var datas = new SurveyData
            {
                Name = Intent.GetStringExtra("Name"),
                CustomerID = Intent.GetIntExtra("CustomerID", 0),
                SurveyNo = Intent.GetIntExtra("SurveyNo", 0),
                Age = Intent.GetIntExtra("Age", 0),
                Gender = Intent.GetStringExtra("Gender"),
            };

            if (chk1.Text == "" || chk2.Text == "" || chk3.Text == "" || chk4.Text == "" || chk5.Text == "" || chk6.Text == "" || chk7.Text == "" || chk8.Text == "" || chk9.Text == "" || chk10.Text == "" || chk11.Text == "" || chk12.Text == "" || chk13.Text == "" || chk14.Text == "")
            {
                Toast.MakeText(this, "Please answer evrything", ToastLength.Short).Show();
            }
            else
            {
                datas.Question1 = chk1.Text;
                datas.Question2 = chk2.Text;
                datas.Question3 = chk3.Text;
                datas.Question4 = chk4.Text;
                datas.Question5 = chk5.Text;
                datas.Question6 = chk6.Text;
                datas.Question7 = chk7.Text;
                datas.Question8 = chk8.Text;
                datas.Question9 = chk9.Text;
                datas.Question10 = chk10.Text;

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

                datas.Question21 = edit21.Text;
                datas.Question22 = edit22.Text;
                datas.Question23 = edit23.Text;
                datas.Question24 = chk24.Text;
                datas.Question25 = chk25.Text;
                datas.Question26 = chk26.Text;
                datas.Question27 = chk27.Text;
                datas.Question28 = chk28.Text;
                datas.Question29 = chk29.Text;
                datas.Question30 = chk30.Text;

            }

            var res = surveyData(datas);

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

