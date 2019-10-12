using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bonus_assignment_n01399681_Anshuk_Aggarwal
{
    public partial class bonus_assigment_q1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            //These are reference from the in class example covered in aspx_validation file by Christine Bittle
            if (Page.IsPostBack)
            {
                Page.Validate();

                if(Page.IsValid)
                {
                    //here, I am just creating the C# variables and refrencing it to the aspx ids.
                    //ToInt32 converts a value to an integer
                    int X_Coordinate = Convert.ToInt32(x_coordinate.Text);
                    int Y_Coordinate = Convert.ToInt32(y_coordinate.Text);
                    confirmbox.InnerHtml = "Thank you for your entry <br>";
                    //Goal:Create a logic that can check value of two coordinates and display the corresponding quadrant.
                    //Requirements:Two coordinates from the user.
                    //if both are positive 1st quadrant


                    if (X_Coordinate>0 && Y_Coordinate>0)
                    {
                        confirmbox.InnerHtml += "falls in quadrant 1";

                    }
                    //if x is negative and y is postive:2nd Quadrant
                    else if(X_Coordinate<0 && Y_Coordinate>0)
                        {
                        confirmbox.InnerHtml += "falls in quadrant 2";

                    }
                    // if both are negative:Third quadrant.
                    else if(X_Coordinate<0 && Y_Coordinate<0)
                        {
                        confirmbox.InnerHtml += "falls in quadrant 3";

                    }
                    //if x is positive and y is negative:4th quadrant.
                    else if(X_Coordinate>0 && Y_Coordinate<0)
                            {
                        confirmbox.InnerHtml += "falls in quadrant 4";

                    }
                    //if both are zero.ask user to retry
                    else
                    {

                        confirmbox.InnerHtml += "The coordinates for either axes cannot be zero. Please re-try";
                    }
                }

            }

        }
    }
}