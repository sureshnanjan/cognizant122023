using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestfulBookerOperations
{
    public interface IRestfulBookerOperations
    {
        /// <summary>
        /// Creates a new auth token to use for access to the PUT and DELETE /booking
        /// </summary>
        /// <param name="uname"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Task<string> createToken(string uname, string password);
        /// <summary>
        /// Returns the ids of all the bookings that exist within the API. Can take optional query strings to search and return a subset of booking ids.
        /// </summary>
        /// <param name="fname">Return bookings with a specific firstname</param>
        /// <param name="lname">Return bookings with a specific lastname</param>
        /// <param name="checkin">Return bookings that have a checkin date greater than or equal to the set checkin date. Format must be CCYY-MM-DD</param>
        /// <param name="checkout">Return bookings that have a checkout date greater than or equal to the set checkout date. Format must be CCYY-MM-DD</param>
        /// <returns></returns>
        Task<string[]> GetBookingIds(string fname, string lname, string checkin, string checkout);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Booking> GetBooking(string id);
    }
}
