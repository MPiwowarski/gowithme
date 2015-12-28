using GoWithMe.Model.ModelDB;
using GoWithMe.Model.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GoWithMe
{
    public partial class AddUserImage : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            int? userId = Session["UserId"] != null ? Convert.ToInt32(Session["UserId"]) : (int?)null;

            if (userId == null)
            {
                Response.Redirect("Home.aspx");
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            LoadActualUserImage();
        }

        private void LoadActualUserImage()
        {
            ITblImageRepository repo = new TblImageRepository();
            int? userId = Session["UserId"] != null ? Convert.ToInt32(Session["UserId"]) : (int?)null;

            var img = repo.GetUserImage((int)userId);
            if (img != null)
            {
                //byte[] img = repo.GetUserImage((int)userId);


                string base64String = Convert.ToBase64String(img, 0, img.Length);
                ActualUserImage.ImageUrl = "data:image/png;base64," + base64String;
            }

        }

        protected void SaveImageControl_Click(object sender, EventArgs e)
        {
            int? userId = Session["UserId"] != null ? Convert.ToInt32(Session["UserId"]) : (int?)null;

            if (LoadUserImageControl.HasFile)
            {
                try
                {
                    ITblImageRepository repo = new TblImageRepository();

                    tblImage img = new tblImage();
                    img = TblImageRepository.DBContext.Images.Where(x => x.ID == (int)userId).Select(x => x).FirstOrDefault();
                    if (img != null)
                    {
                        TblImageRepository.DBContext.Images.Remove(img);
                    }

                    tblImage image = new tblImage();
                    image.ID = (int)userId;
                    image.UserId = (int)userId;
                    image.Image = LoadUserImageControl.FileBytes;

                    repo.AddNewImage(image);

                    StatusLabelControl.ForeColor = System.Drawing.Color.Green;
                    StatusLabelControl.Text = "Image is saved succesfully";

                    LoadActualUserImage();




                }
                catch (Exception ex)
                {
                    StatusLabelControl.ForeColor = System.Drawing.Color.Red;
                    StatusLabelControl.Text = "Unexpected error during saving";
                }
            }
            else
            {
                StatusLabelControl.ForeColor = System.Drawing.Color.Red;
                StatusLabelControl.Text = "Please upload your image";
            }
        }
    }
}