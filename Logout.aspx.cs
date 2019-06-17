using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _382Project
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["uyeadi"] = null;
            Session["uyeadi_id"] = null;
            Session["uyeadi_resim"] = null;
            Session["ImagePath"] = null;
            Session["uyeadi_role"] = null;

            Response.Redirect("Login.aspx");
        }
    }
}