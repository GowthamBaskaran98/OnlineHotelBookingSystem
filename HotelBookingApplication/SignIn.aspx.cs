using System;
using System.Data.SqlClient;
using HotelBookingApplication.DAL;
using HotelBookingApplication.Entity;
using System.Data;

namespace HotelBookingApplication
{
    public partial class SignIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected virtual void Submit_Clicked(object sender, EventArgs e)
        {
            User user = new User(userId.Text, password.Text);
            using (SqlConnection sqlConnection = Connection.GetDBConnection())
            {
                UserRepository userRepository = new UserRepository();
                string type = userRepository.LogIn(user, sqlConnection);
                string message = "Logged in successfully.";
                string script = "window.onload = function(){ alert('";
                script += message;
                script += "')};";
                ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
                if (type == "HotelOwner")
                {
                    Response.Redirect("HotelOwnerPage.aspx");
                }
                else if (type == "Admin")
                {
                    Response.Redirect("AdminPage.aspx");
                }
                else
                {
                    Response.Redirect("CustomerPage.aspx");
                }
                Response.Write("Incorrect Username or Password");
            }
        }
    }
}