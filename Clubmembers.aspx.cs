using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _382Project
{
    public partial class ClubMembers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Session["uyeadi_role"]) == 1)
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
                    LinkButton lbMasterClubmembers = new LinkButton();
                    lbMasterClubmembers = (LinkButton)Master.FindControl("LinkButtonClubmembers");
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
                    lbMasterClubmembers.Visible = true;

                    lblWelcome.Text = Session["uyeadi"].ToString();
                    lblWelcome.Visible = true;

                }
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
          
        }
        protected void DeleteUser(object sender, GridViewDeleteEventArgs e)
        {
            int r = Convert.ToInt32(e.RowIndex.ToString());

            int butonubul = int.Parse(GridView1.DataKeys[r].Value.ToString());
            using (var db = new ModelWebEntities())
            {

                Users user = db.Users.Where(x => x.UserID == butonubul).FirstOrDefault();

                List<Activities> aktivite_listesi = (from u in db.Activities where u.activity_by == butonubul select u).ToList();
              

                foreach (var Item in aktivite_listesi)
                {
                    List<Likes> L_list = (from u in db.Likes where Item.id == u.activity_id select u).ToList();
                    foreach (var i in L_list)
                    {
                        db.Likes.Remove(i);
                    }
                    List<Comments> C_list = (from u in db.Comments where Item.id == u.activity_id select u).ToList();
                    foreach (var x in C_list)
                    {
                        db.Comments.Remove(x);
                    }
                }
                db.SaveChanges();

                List<Likes> likes_listesi = (from u in db.Likes where butonubul == u.user_id select u).ToList();
                List<Comments> comment_listesi = (from u in db.Comments where butonubul == u.user_id select u).ToList();

                foreach (var x in likes_listesi)
                {
                    db.Likes.Remove(x);
                }
                db.SaveChanges();

                foreach (var y in comment_listesi)
                {
                    db.Comments.Remove(y);
                }
                db.SaveChanges();

                foreach (var Item in aktivite_listesi)
                {
                    db.Activities.Remove(Item);
                }
                db.SaveChanges();

                db.Users.Remove(user);
                db.SaveChanges();
            }
        }


    }
}
