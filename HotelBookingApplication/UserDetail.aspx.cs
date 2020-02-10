using System;
using System.Data;
using HotelBookingApplication.DAL;
using HotelBookingApplication.Entity;
using System.Web.UI.WebControls;

namespace HotelBookingApplication
{
    public partial class UserDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Display();
            }
        }
        protected void Display()
        {
            UserRepository userRepository = new UserRepository();
            DataTable data = userRepository.ViewDetails();
            if (data.Rows.Count > 0)
            {
                UserProfile.DataSource = data;
                UserProfile.DataBind();
            }
        }
        protected void UserProfile_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            UserRepository userRepository = new UserRepository();
            int id = Convert.ToInt32(UserProfile.DataKeys[e.RowIndex].Value.ToString());
            userRepository.DeleteDetail(id);
            UserProfile.EditIndex = -1;
            Display();
        }

        protected void UserProfile_RowEditing(object sender, GridViewEditEventArgs e)
        {
            UserProfile.EditIndex = e.NewEditIndex;
        }

        protected void UserProfile_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            UserRepository userRepository = new UserRepository();
            int id = Convert.ToInt32(UserProfile.DataKeys[e.RowIndex].Value.ToString());
            TextBox firstName = UserProfile.Rows[e.RowIndex].FindControl("txtFirstName") as TextBox;
            TextBox lastName = UserProfile.Rows[e.RowIndex].FindControl("txtLastName") as TextBox;
            TextBox mobileNumber = UserProfile.Rows[e.RowIndex].FindControl("txtMobileNumber") as TextBox;
            TextBox password = UserProfile.Rows[e.RowIndex].FindControl("txtPassword") as TextBox;
            TextBox mail = UserProfile.Rows[e.RowIndex].FindControl("txtMail") as TextBox;
            TextBox userType = UserProfile.Rows[e.RowIndex].FindControl("txtUserType") as TextBox;
            User user = new User(firstName.Text, lastName.Text, mobileNumber.Text, mail.Text, password.Text, userType.Text);
            UserProfile.EditIndex = -1;
            Display();
        }
        protected void UserProfile_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            UserProfile.EditIndex = -1;
            Display();
        }
    }
}