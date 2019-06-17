using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


namespace _382Project
{
    public partial class activitylist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
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

                    using (var myDB = new ModelWebEntities())
                    {
                        var allact = (from u in myDB.Activities
                                      select u).ToList();
                        DateTime currentdate = Convert.ToDateTime(DateTime.Now);
                        foreach (var x in allact.ToList())
                        {
                            DateTime dob = Convert.ToDateTime(x.date);
                            TimeSpan time = currentdate.Subtract(dob);
                            int control = time.Days;
                            if (control > 15)
                            {
                                allact.Remove(x);
                            }
                            x.score = x.totalLikes - x.totalDisslike;
                            myDB.SaveChanges();
                        }

                        GridView1.DataSource = allact;
                        GridView1.DataBind();

                    }
                }

                else
                {
                    Response.Redirect("Login.aspx");
                }
            }
        }



        protected void Button1_Click(object sender, EventArgs e)
        {

            foreach (GridViewRow row in GridView1.Rows)
            {
                
                RadioButtonList status = (row.Cells[6].FindControl("RadioButtonList1") as RadioButtonList);
                if (status.SelectedItem != null)
                {
                    string value = status.SelectedItem.Text;


                    Label tbx = row.Cells[0].FindControl("Id") as Label;
                    int u_id = Convert.ToInt32(tbx.Text);

                    if (value == "Like")
                    {
                        updaterow(u_id, 1);
                    }

                    else if (value == "Disslike")
                    {
                        updaterow(u_id, 0);
                    }
                }

            }
        }
        private void updaterow(int rollno, int markstatus)
        {
            using (var myDB = new ModelWebEntities())
            {
                int loggeduserid = Convert.ToInt32(Session["uyeadi_id"]);
                int activityid = rollno;
                var loggeduser = (from u in myDB.Likes where u.user_id == loggeduserid && u.activity_id == activityid select u).FirstOrDefault();
                if (loggeduser != null)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('Daha önce like veya dislike vermişsiniz. Like veya dislike verdiğiniz değerler değişmedi.')", true);
                }
                else
                {
                    string loggedusername = Session["uyeadi"].ToString();

                    var likeekle = (from u in myDB.Users where u.Username == loggedusername select u).FirstOrDefault();
                    if (likeekle != null)
                    {
                        var newlike = new Likes();
                        newlike.activity_id = rollno;
                        newlike.user_id = loggeduserid;
                        if (markstatus == 1)
                        {
                            newlike.good = Convert.ToInt32(markstatus);
                            myDB.Likes.Add(newlike);
                            myDB.SaveChanges();
                        }
                        else
                        {
                            newlike.bad = 1;
                            myDB.Likes.Add(newlike);
                            myDB.SaveChanges();
                        }



                        Activities act = (from u in myDB.Activities where u.id == newlike.activity_id select u).FirstOrDefault();
                        if (newlike.good == 1)
                        {
                            act.totalLikes++;

                        }
                        else
                        {
                            act.totalDisslike++;
                        }

                        myDB.SaveChanges();
                    }
                }
            }



        }

    }




}


