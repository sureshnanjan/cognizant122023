using RestSharp;
using RestfulBookerOperations;
using System;
using System.Threading.Tasks;

namespace RestfulBookerRSImpl
{
    public class RestfulBookerRSApp: IRestfulBookerOperations
    {
        private string authUrl;
        private string bookingUrl;
        private string apitoken = default;
        private static IRestClient _apiClient = default;
        private APIAutomationConfiguration _config = default;
        public RestfulBookerRSApp()
        {
            authUrl = "/auth";
            bookingUrl = " /booking";
            _config = APIApplicationFactory.getAPIEndPointParams();
            var options = new RestClientOptions(_config.Url)
            {
                MaxTimeout = -1,
            };
            _apiClient = new RestClient(options);
        }

        public async Task<string> createToken(string uname, string password)
        {
            
            var request = new RestRequest(authUrl, Method.Post);
            request.AddHeader("Content-Type", "application/json");
            var body = @"{ 
" + "\n" +
            @"    ""username"" : ""admin"",
" + "\n" +
            @"    ""password"" : ""password123""
" + "\n" +
            @"}";
            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = await _apiClient.ExecuteAsync(request);
            Console.WriteLine(response.Content);
            return response.Content;
        }

        public async Task<string[]> getAllBookings() {
            var request = new RestRequest(bookingUrl, Method.Get);
            RestResponse response = await _apiClient.ExecuteAsync(request);
            Console.WriteLine(response.Content);
            return new  string[] { };
        }

        public async Task<string[]> getAllBookingsByName() {
            var request = new RestRequest("/booking?firstname=suresh&lastname=nanjan", Method.Get);
            RestResponse response = await _apiClient.ExecuteAsync(request);
            Console.WriteLine(response.Content);
            return new string[] { };
        }

        public async Task GetBooking(string id)
        {
            var request = new RestRequest($"/booking/{id}", Method.Get);
            request.AddHeader("Accept", "application/json");
            RestResponse response = await _apiClient.ExecuteAsync(request);
            Console.WriteLine(response.Content);
        }

        public string[] GetBookingIds(string fname, string lname, string checkin, string checkout)
        {
            throw new System.NotImplementedException();
        }


        private async Task BasicAuth() {
            var options = new RestClientOptions("https://postman-echo.com")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("/basic-auth", Method.Get);
            request.AddHeader("Authorization", "Basic cG9zdG1hbjpwYXNzd29yZA==");
            request.AddHeader("Cookie", "sails.sid=s%3A-sW9T81ic2YLjb6LBR8G2dKz05yMBDOF.NS2GkCt8JRKZZpWLermErwr1H7ISgIPz3Re3wdvZpVw");
            RestResponse response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content);
        }

        private async Task DigestAuth() {
            var options = new RestClientOptions("https://postman-echo.com")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("/digest-auth", Method.Get);
            request.AddHeader("Authorization", "Digest username=\"postman\", realm=\"Users\", nonce=\"ni1LiL0O37PRRhofWdCLmwFsnEtH1lew\", uri=\"/digest-auth\", response=\"254679099562cf07df9b6f5d8d15db44\", opaque=\"\"");
            request.AddHeader("Cookie", "sails.sid=s%3A-sW9T81ic2YLjb6LBR8G2dKz05yMBDOF.NS2GkCt8JRKZZpWLermErwr1H7ISgIPz3Re3wdvZpVw");
            RestResponse response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content);
        }

        private  async Task HawkAuth() {
            var options = new RestClientOptions("https://postman-echo.com")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("/auth/hawk", Method.Get);
            request.AddHeader("Authorization", "Hawk id=\"dh37fgj492je\", ts=\"1702896822\", nonce=\"RZKGNz\", mac=\"ivpjkykMmV6ax5u4SbCXTcvKwQ7FIP78XweYHkntTNE=\"");
            request.AddHeader("Cookie", "sails.sid=s%3A-sW9T81ic2YLjb6LBR8G2dKz05yMBDOF.NS2GkCt8JRKZZpWLermErwr1H7ISgIPz3Re3wdvZpVw");
            RestResponse response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content);
        }

        private async Task OAuth1() {
            var options = new RestClientOptions("https://postman-echo.com")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("/oauth1", Method.Get);
            request.AddHeader("Authorization", "OAuth oauth_consumer_key=\"RKCGzna7bv9YD57c\",oauth_signature_method=\"HMAC-SHA1\",oauth_timestamp=\"1702912546\",oauth_nonce=\"RVxREqS3c4X\",oauth_signature=\"gY%2FCvgLwRc%2BCsYWN%2Fh7yPRtx278%3D\"");
            request.AddHeader("Cookie", "sails.sid=s%3AF4OexJSAe001hHsv9Bn8sHEl7dFYR7bb.Z5T98Zn2YS6%2BWzQUQ8YRY3fXlVhE13C91nTZbOBCSRk");
            RestResponse response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content);
        }

        Task<string[]> IRestfulBookerOperations.GetBookingIds(string fname, string lname, string checkin, string checkout)
        {
            throw new NotImplementedException();
        }

        Task<Booking> IRestfulBookerOperations.GetBooking(string id)
        {
            throw new NotImplementedException();
        }
    }
}
