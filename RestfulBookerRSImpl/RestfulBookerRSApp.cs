using RestSharp;
using RestfulBookerOperations;

namespace RestfulBookerRSImpl
{
    public class RestfulBookerRSApp: IRestfulBookerOperations
    {
        private string apitoken = default;
        private static IRestClient _apiClient = default;
        public RestfulBookerRSApp()
        {
            _apiClient = new RestClient();
        }

        public string createToken(string uname, string password)
        {
            throw new System.NotImplementedException();
        }

        public string GetBooking(string id)
        {
            throw new System.NotImplementedException();
        }

        public string[] GetBookingIds(string fname, string lname, string checkin, string checkout)
        {
            throw new System.NotImplementedException();
        }
    }
}
