using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _0615_Hello {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (!this.IsPostBack) {
                //read data from DB Server
                //set
                TextBox1.Text = "please keyin name";
            }


        }

        protected void Button1_Click(object sender, EventArgs e) {
            //checking data
            //write into DB Sever
            //prompt user to report/result page
            //Literal1.Text = "<h1>Hello!!!" + TextBox1.Text;
            if (TextBox1.Text == "") {
                Literal1.Text = "please keyin your name";
                return;
            }
            //Session["userName"] = TextBox1.Text;

            Response.Redirect("hello.aspx");
            
        }
    }
}