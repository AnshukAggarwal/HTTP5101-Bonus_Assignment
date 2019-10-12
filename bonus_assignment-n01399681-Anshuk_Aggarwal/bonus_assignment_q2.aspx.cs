using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bonus_assignment_n01399681_Anshuk_Aggarwal
{
    public partial class bonus_assignment_q2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();

                if (Page.IsValid)
                {
                    string User_Schedule = user_schedule.Text;
                    confirmbox.InnerHtml = "Thank you</br>";//testing the connection

                    //print number 1 to 31. use a FOR loop

                for (var i = 1; i <= 31; i++)
                    {//to check the day of the week. We are adding 7 days.
                        if (i == 1 || i == 8 || i == 15 || i = 22 || i == 29)
                        {
                            confirmbox.InnerHtml += "Today is Tuesday";
                        }
                        //if the user works on a particular day. The message should say time to work.
                    }
                //collect the days the user works
                foreach(ListItem user_schedule in user_schedule.Items)
                    {

                        if (user_schedule.Selected == true)
                        {


                        }
                    }


                    
                }
            }
        }
        //this is taken from the in class example file.
        protected void UserSchedule_Validate(object sender, ServerValidateEventArgs e)
        {


        }
        
    }


}