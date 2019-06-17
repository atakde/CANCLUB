using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _382Project
{
    public partial class Comments1 : System.Web.UI.Page
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
                    lbMasterProfile = (LinkButton)Master.FindControl("LinkButtonTrends");

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

        protected void Kaydet_Click(object sender, EventArgs e)
        {
            using (var myDB = new ModelWebEntities())
            {
                string aktivite_baslik =Convert.ToString(SelectActivity.Text);
                string loggedusername = Session["uyeadi"].ToString();
                var loggeduser = (from u in myDB.Users where u.Username == loggedusername select u).FirstOrDefault();
                if (loggeduser != null)
                {
                    Activities act = (from u in myDB.Activities where u.title == aktivite_baslik select u).FirstOrDefault();

                    var newcomment = new Comments();
                    newcomment.activity_id = act.id;
                    newcomment.comment_include = Comment.Text;
                    newcomment.user_id = loggeduser.UserID;
                    myDB.Comments.Add(newcomment);
                    myDB.SaveChanges();
                    Response.Redirect("comments.aspx");
                }
            }
        }
    }
}