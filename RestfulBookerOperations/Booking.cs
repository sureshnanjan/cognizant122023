using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestfulBookerOperations
{
    public class Booking
    {
        private string firstname;
        private string lastname;

        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }


        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }

        private int totalprice;

        public int TotalPrice
        {
            get { return totalprice; }
            set { totalprice = value; }
        }

        private string additionaldetails;

        public string AdditionalDetails
        {
            get { return additionaldetails; }
            set { additionaldetails = value; }
        }

        private BookingDatesInfo bookingdates;

        public BookingDatesInfo BookingDates
        {
            get { return bookingdates; }
            set { bookingdates = value; }
        }




        //string firstname    string Firstname for the guest who made the booking
        //string lastname string Lastname for the guest who made the booking
        // string totalprice   int The total price for the booking
        //bool depositpaid        Whether the deposit has been paid or not
        // bookingdates Sub-object that contains the checkin and checkout dates
        // string checkin  Date the guest is checking in
        // string checkout Date Date the guest is checking out
        // string additionalneeds Any other needs the guest has
    }
}
