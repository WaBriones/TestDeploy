namespace AndroidTest.Service
{
    public class CustomerService : BaseService
    {
        public CustomerService()
        {
            BaseUrl = string.Format("http://customersurveryapi.azurewebsites.net/api");
            //BaseUrl = string.Format("http://10.0.2.2:80/api");
        }
    }
}