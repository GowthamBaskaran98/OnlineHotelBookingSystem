﻿using System;
using System.Data.SqlClient;
using HotelBookingApplication.DAL;
using HotelBookingApplication.Entity;

namespace HotelBookingAppication
{
    public partial class SignIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected virtual void Submit_Clicked(object sender, EventArgs e)
        {
            User user = new User(userId.Text, password.Text);
            SqlConnection sqlConnection = new SqlConnection(@"Data Source = KOWSALYA\SQLSERVER; Initial Catalog = master; User ID = sa; Password = gowtham");
            UserRepository userRepository = new UserRepository();
            int retRows = userRepository.LogIn(user, sqlConnection);
            if (retRows == 0)
            {
                Response.Write("Incorrect Username or Password");
            }
            else
            {
                string message = "Logged in successfully.";
                string script = "window.onload = function(){ alert('";
                script += message;
                script += "')};";
                ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
            }
        }
    }
}