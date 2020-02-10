using System.Data;
using System.Data.SqlClient;
using HotelBookingApplication.Entity;
using System.Collections.Generic;
using System;

namespace HotelBookingApplication.DAL
{
    public class UserRepository
    {
        public int Registration(User data)
        {
            string sql = "sp_Registration";
            using (SqlConnection sqlConnection = Connection.GetDBConnection())
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@firstName";
                parameter.Value = data.firstName;
                parameter.SqlDbType = SqlDbType.Char;
                sqlCommand.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@lastName";
                parameter.Value = data.lastName;
                parameter.SqlDbType = SqlDbType.Char;
                parameter.Size = 20;
                sqlCommand.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@mobileNumber";
                parameter.Value = data.mobileNumber;
                parameter.SqlDbType = SqlDbType.Char;
                parameter.Size = 20;
                sqlCommand.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@gmail";
                parameter.Value = data.gmail;
                parameter.SqlDbType = SqlDbType.Char;
                parameter.Size = 30;
                sqlCommand.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@password";
                parameter.Value = data.password;
                parameter.SqlDbType = SqlDbType.Char;
                parameter.Size = 20;
                sqlCommand.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@userType";
                parameter.Value = data.userType;
                parameter.SqlDbType = SqlDbType.Char;
                sqlCommand.Parameters.Add(parameter);
                int retRows = sqlCommand.ExecuteNonQuery();
                return retRows;
            }
        }

        public int HotelRegistration(Hotel data)
        {
            string sql = "sp_RegisterDetail";
            using (SqlConnection sqlConnection = Connection.GetDBConnection())
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@hotelName";
                parameter.Value = data.hotelName;
                parameter.SqlDbType = SqlDbType.Char;
                sqlCommand.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@hotelAddress";
                parameter.Value = data.hotelAddress;
                parameter.SqlDbType = SqlDbType.Char;
                parameter.Size = 20;
                sqlCommand.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@totalRoom";
                parameter.Value = data.totalRoom;
                parameter.SqlDbType = SqlDbType.Int;
                sqlCommand.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@bookedRoom";
                parameter.Value = data.bookedRoom;
                parameter.SqlDbType = SqlDbType.Int;
                sqlCommand.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@availableRoom";
                parameter.Value = data.availableRoom;
                parameter.SqlDbType = SqlDbType.Int;
                sqlCommand.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@roomAmenities";
                parameter.Value = data.roomAmenities;
                parameter.SqlDbType = SqlDbType.Char;
                sqlCommand.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@pricePerDay";
                parameter.Value = data.pricePerDay;
                parameter.SqlDbType = SqlDbType.Int;
                sqlCommand.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@approvalStatus";
                parameter.Value = "Pending";
                parameter.SqlDbType = SqlDbType.Char;
                sqlCommand.Parameters.Add(parameter);
                int retRows = sqlCommand.ExecuteNonQuery();
                return retRows;
            }
        }
        public DataTable ViewDetails()
        {
            using (SqlConnection sqlConnection = Connection.GetDBConnection())
            {
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from USER_LOGIN", sqlConnection);
                DataTable table = new DataTable();
                sqlDataAdapter.Fill(table);
                return table;
            }
        }
        public void DeleteDetail(int id)
        {
            using (SqlConnection sqlConnection = Connection.GetDBConnection())
            {
                sqlConnection.Open();

                string sql = "sp_DeleteDetail";
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter para = new SqlParameter();
                sqlCommand.Parameters.AddWithValue("@id", id);
                int rows = sqlCommand.ExecuteNonQuery();
            }
        }
        public void UpdateDetail(int id, User user)
        {
            using (SqlConnection sqlConnection = Connection.GetDBConnection())
            {
                sqlConnection.Open();

                string idQuery = "sp_UpdateDetail";
                SqlCommand sqlCommand = new SqlCommand(idQuery, sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter para = new SqlParameter();
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.Parameters.AddWithValue("@firstName", user.firstName);
                sqlCommand.Parameters.AddWithValue("@lastName", user.lastName);
                sqlCommand.Parameters.AddWithValue("@mobileNumber", user.mobileNumber);
                sqlCommand.Parameters.AddWithValue("@gmail", user.gmail);
                sqlCommand.Parameters.AddWithValue("@password", user.password);
                sqlCommand.Parameters.AddWithValue("@userType", user.userType);
                int rows = sqlCommand.ExecuteNonQuery();
            }
        }
        public static List<User> userList = new List<User>();
        public string LogIn(User user, SqlConnection sqlConnection)
        {
            using (SqlCommand sqlCommand = new SqlCommand("sp_LogIn", sqlConnection))
            {
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@gmail", user.gmail);
                sqlCommand.Parameters.AddWithValue("@password", user.password);
                sqlCommand.Parameters.Add("@userType", SqlDbType.VarChar, 15);
                sqlCommand.Parameters["@userType"].Direction = ParameterDirection.Output;
                //string type = Convert.ToString(sqlCommand.Parameters["@userType"].Value);
                SqlDataReader data = sqlCommand.ExecuteReader();
                if (Convert.ToString(sqlCommand.Parameters["@userType"].Value)=="Admin")
                {
                    return "Admin";
                }
                else if (Convert.ToString(sqlCommand.Parameters["@userType"].Value) == "Customer")
                {
                    return "Customer";
                }
                else
                {
                    return "HotelOwner";
                }
            }
        }
    }
}
