using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _382Project
{
    public partial class profil : System.Web.UI.Page
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
                    using (var myDB = new ModelWebEntities())
                    {
                        var k_adi = Session["uyeadi"].ToString();

                        var loggeduser = (from u in myDB.Users where u.Username == k_adi select u).FirstOrDefault();
                        if (loggeduser != null)
                        {
                            FirstName.Text = loggeduser.FirstName;
                            LastName.Text = loggeduser.LastName;
                            Email.Text = loggeduser.Email;
                            Department.Text = loggeduser.Department;
                            ProfilResmi.ImageUrl = Convert.ToString(loggeduser.Image);
                        }
                    }
                    User.Text = Session["uyeadi"].ToString();
                }

                int userid = Convert.ToInt32(Session["uyeadi_id"]);
                using (var myDB = new ModelWebEntities())
                {

                    List<Activities> aktivite_sayisi = (from a in myDB.Activities where a.activity_by == userid select a).ToList();
                    int user_aktivities = aktivite_sayisi.Count();
                    Aktivite.Text = user_aktivities.ToString();

                    List<Likes> like_sayisi = (from a in myDB.Likes where a.user_id == userid && a.good == 1 select a).ToList();
                    int likes_sayi = like_sayisi.Count();
                    Like.Text = likes_sayi.ToString();

                    List<Likes> dislike_sayisi = (from a in myDB.Likes where a.user_id == userid && a.bad == 1 select a).ToList();
                    int dislikes_sayi = dislike_sayisi.Count();
                    Dislike.Text = dislikes_sayi.ToString();


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
                string loggedusername = Session["uyeadi"].ToString();
                var loggeduser = (from u in myDB.Users where u.Username == loggedusername select u).FirstOrDefault();
                if (loggeduser != null)
                {
                    loggeduser.FirstName = FirstName.Text;
                    loggeduser.LastName = LastName.Text;
                    loggeduser.Email = Email.Text;
                    loggeduser.Department = Department.Text;
                    loggeduser.Password = Password.Text;
                    if (this.fluDosya.HasFile)
                    {
                        fluDosya.SaveAs(Server.MapPath("~/Dosyalar/" + this.fluDosya.FileName));
                        string fileName = Path.GetFileName(this.fluDosya.PostedFile.FileName);
                        Session["ImagePath"] = "Dosyalar/" + fileName;

                        loggeduser.Image = Convert.ToString(Session["ImagePath"]);

                    }
                    myDB.SaveChanges();

                    Durum.Text = "Güncelleme başarılı";
                    Response.Redirect("Profile");
                }
                else
                {
                    Durum.Text = "Güncelleme başarısız!";
                }
            }
        }
    }
}