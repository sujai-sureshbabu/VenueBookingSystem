using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SmallVenueBookingSystem
{
    [ServiceContract]
    public interface IService
    {       
        [OperationContract]
        List<VenueSeatingDetails> GetSeatingDetails();

        [OperationContract]
        string BookVenueSeats(List<string> seats);
    }


    [DataContract]
    public class VenueSeatingDetails
    {        

        [DataMember]
        public string Seat_No;

        [DataMember]
        public string Booked_Customer;

        [DataMember]
        public string Cust_Age;

        [DataMember]
        public string Partially_Enabled;

        [DataMember]
        public int? Age;

        [DataMember]
        public string booking_date { get; set; }

        [DataMember]
        public bool? isAvailable { get; set; }
    }
}
