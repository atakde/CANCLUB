using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _382Project
{
    public partial class trends : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["uyeadi"] != null)
            {
                if (!IsPostBack)
                {
                    LinkButton lbMasterHome = new LinkButton();
                    lbMasterHome = (LinkButton)Master.FindControl("LinkButtonHome");
                    LinkButton lbMasterAdd = new LinkButton();
                    lbMasterAdd = (LinkButton)Master.FindControl("LinkButtonAdd");
                    LinkButton lbMasterList = new LinkButton();
                    lbMasterList = (LinkButton)Master.FindControl("LinkButtonList");
                    LinkButton lbMasterLogin = new LinkButton();
                    lbMasterLogin = (LinkButton)Master.FindControl("LinkButtonLogin");
                    LinkButton lbMasterLogout = new LinkButton();
                    lbMasterLogout = (LinkButton)Master.FindControl("LinkButtonLogout");
                    LinkButton lbMasterRegister = new LinkButton();
                    lbMasterRegister = (LinkButton)Master.FindControl("LinkButtonRegister");
                    LinkButton lbMasterProfile = new LinkButton();
                    lbMasterProfile = (LinkButton)Master.FindControl("LinkButtonProfile");
                    LinkButton lbMasterTrends = new LinkButton();
                    lbMasterTrends = (LinkButton)Master.FindControl("LinkButtonTrends");

                    Label lblWelcome = new Label();
                    lblWelcome = (Label)Master.FindControl("LabelWelcome");

                    lbMasterHome.Visible = true;
                    lbMasterAdd.Visible = true;
                    lbMasterTrends.Visible = true;
                    lbMasterProfile.Visible = true;
                    lbMasterList.Visible = true;
                    lbMasterLogin.Visible = false;
                    lbMasterLogout.Visible = true;
                    lbMasterRegister.Visible = false;

                    lblWelcome.Text = Session["uyeadi"].ToString();
                    lblWelcome.Visible = true;

                    if (Convert.ToInt32(Session["uyeadi_role"]) == 1)
                    {
                        LinkButton lbMasterClubmembers = new LinkButton();
                        lbMasterClubmembers = (LinkButton)Master.FindControl("LinkButtonClubmembers");

                        lbMasterClubmembers.Visible = true;
                    }

                }
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}