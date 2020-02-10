using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApplication.Entity
{
    public class Hotel
    {
        public string hotelName { get; set; }
        public string hotelAddress { get; set; }
        public int totalRoom { get; set; }
        public int bookedRoom { get; set; }
        public int availableRoom { get; set; }
        public string roomAmenities { get; set; }
        public int pricePerDay { get; set; }
        public Hotel(string hotelName, string hotelAddress, int totalRoom,int bookedRoom, int availableRoom, string roomAmenities, int pricePerDay)
        {
            this.hotelName = hotelName;
            this.hotelAddress = hotelAddress;
            this.totalRoom = totalRoom;
            this.bookedRoom = bookedRoom;
            this.availableRoom = availableRoom;
            this.roomAmenities = roomAmenities;
            this.pricePerDay = pricePerDay; 
        }
    }
}
