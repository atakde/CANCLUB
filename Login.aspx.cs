using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _382Project
{
    public partial class giris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LinkButton lbMasterLogin = new LinkButton();
            lbMasterLogin = (LinkButton)Master.FindControl("LinkButtonLogin");
            lbMasterLogin.Visible = false;
        }

        protected void Kaydet_Click(object sender, EventArgs e)
        {
            using (var myDB = new ModelWebEntities())
            {
                var loggeduser = (from u in myDB.Users where u.Username == Username.Text && u.Password == Password.Text select u).FirstOrDefault();
                if (loggeduser != null)
                {
                    Session["uyeadi"] = loggeduser.Username;
                    Session["uye_email"] = loggeduser.Email;
                    Session["uyeadi_id"] = loggeduser.UserID;
                    Session["uyeadi_resim"] = loggeduser.Image;
                    Session["ImagePath"] = loggeduser.Image;
                    Session["uyeadi_role"] = loggeduser.Role;
                    Durum.Text = "Login OK!";
                    Response.Redirect("Homepage.aspx");


                }
                else
                {
                    Durum.Text = "Login Failed";
                }
            }
        }
    }
}