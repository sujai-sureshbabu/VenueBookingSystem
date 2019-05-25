using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.Entity;

namespace SmallVenueBookingSystem
{

    public class Service : IService
    {
        /// <summary>
        /// Method used to book seats for small venue
        /// </summary>
        /// <param name="seats">Seats selected for venue booking</param>
        /// <returns>success or failure based on whether seats booked or not</returns>
        public string BookVenueSeats(List<string> seats)
        {
            try
            {

                using (SmallVenueDbEntities context = new SmallVenueDbEntities())
                {
                    var venueBook = context.SeatLayouts.Where(s => seats.Contains(s.seat_no));

                    if (venueBook != null)
                    {
                        foreach (var v in venueBook)
                        {
                            v.isAvailable = false;
                            v.booking_date = DateTime.Now.ToString();
                        }
                    }

                    foreach (var item in venueBook)
                    {
                        context.Entry(item).State = EntityState.Modified;
                    }

                    if (context.SaveChanges() > 0)
                    {
                        return "Success";
                    }
                    else
                    {
                        return "Failure";
                    }
                }
            }
            catch (Exception e)
            {
                return "Failed" + e.Message;
            }
        }

        /// <summary>
        /// Fetch Seat Details Availability of Venue 
        /// </summary>
        /// <returns></returns>
        public List<VenueSeatingDetails> GetSeatingDetails()
        {
            try
            {
                var seats = new List<VenueSeatingDetails>();

                using (SmallVenueDbEntities context = new SmallVenueDbEntities())
                {

                    seats = (from a in context.SeatLayouts
                             select new VenueSeatingDetails
                             {
                                 Seat_No = a.seat_no,
                                 isAvailable = a.isAvailable
                             }).OrderBy(x => x.Seat_No).ToList();

                    return seats;
                }
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);       
            }
        }
    }
}
