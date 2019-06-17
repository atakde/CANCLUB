using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _382Project
{
    public partial class regdeneme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["currentuser"] != null)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), " ", "alert('Giriş yaptınız, yeni hesap oluşturmanız için oturumunuz kapatılıyor...')", true);
                Session["currentuser"] = null;



            }
            else
            {

                LinkButton lbMasterRegister = new LinkButton();
                lbMasterRegister = (LinkButton)Master.FindControl("LinkButtonRegister");
                lbMasterRegister.Visible = false;

                LinkButton lbMasterLogin = new LinkButton();
                lbMasterLogin = (LinkButton)Master.FindControl("LinkButtonLogin");
                lbMasterLogin.Visible = true;
            }

        }

        protected void Kaydet_Click(object sender, EventArgs e)
        {
            using (var myDB = new ModelWebEntities())
            {
                var loggeduser = (from u in myDB.Users where u.Email == Email.Text select u).FirstOrDefault();
                if (loggeduser != null)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), " ", "alert('This e-mail is already using.')", true);
                }
                else
                {
                    var newuser = new Users();
                    newuser.FirstName = FirstName.Text;
                    newuser.LastName = LastName.Text;
                    newuser.Email = Email.Text;
                    newuser.Department = Department.Text;
                    newuser.BirthDate = Convert.ToDateTime(dttpTarih.Text);
                    newuser.Username = Username.Text;
                    newuser.Password = Password.Text;
                    newuser.Role = 0;

                    if (this.fluDosya.HasFile)
                    {
                        fluDosya.SaveAs(Server.MapPath("~/Dosyalar/" + this.fluDosya.FileName));
                        string fileName = Path.GetFileName(this.fluDosya.PostedFile.FileName);
                        Session["ImagePath"] = "Dosyalar/" + fileName;

                        //Some code to insert values in DataBase
                        newuser.Image = Convert.ToString(Session["ImagePath"]);


                    }




                    myDB.Users.Add(newuser);
                    int control = myDB.SaveChanges();
                    if (control >= 1)
                    {
                        Durum.Text = "Register OK!";

                    }
                    else Response.Write("Register Failed!");

                }
            }
        }
    }
}