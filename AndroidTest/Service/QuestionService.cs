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

namespace AndroidTest.Service
{
    public class QuestionService : BaseService
    {
        public QuestionService()
        {
            BaseUrl = string.Format("http://customersurveryapi.azurewebsites.net/api");
        }

        
    }
}