using System;
using HotelBookingApplication.Entity;
using HotelBookingApplication.DAL;

namespace HotelBookingApplication
{
    public partial class RegisterHotel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                Hotel hotel = new Hotel(txtHotelName.Text, txtHotelAddress.Text, Convert.ToInt32(txtTotalRoom.Text), Convert.ToInt32(txtBookedRoom.Text), Convert.ToInt32(txtAvailableRoom.Text), txtRoomAmenities.Text, Convert.ToInt32(txtPricePerDay.Text));
                UserRepository userRepository = new UserRepository();
                int retRows = userRepository.HotelRegistration(hotel);
                if (retRows >= 1)
                {
                    string message = "Registered successfully.";
                    string script = "window.onload = function(){ alert('";
                    script += message;
                    script += "')};";
                    ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
                }
                else
                {
                    Response.Write("Not Registered...");
                }

            }
            catch (Exception m)
            {
                Console.WriteLine(m.Message);
            }
        }
    }
}