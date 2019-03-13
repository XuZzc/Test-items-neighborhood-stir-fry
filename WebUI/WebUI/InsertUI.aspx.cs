using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;
namespace WebUI
{
    public partial class InsertUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack )
            {
                this.DropDownList1.DataSource = TypeClassBLL.TypeClassUI();
                this.DropDownList1.DataTextField = "TypeName";
                this.DropDownList1.DataValueField = "Typeld";
                this.DropDownList1.DataBind();
            }

        }
        //确定添加
        protected void Button2_Click(object sender, EventArgs e)
        {
            SelectModel sm = new SelectModel();
            sm.ProName = this.tbName.Text;
            sm.TypeId = int.Parse (this.DropDownList1.SelectedValue.ToString()) ;
            sm.Price = double.Parse(this.tbprice.Text);
            sm.ProInfo = this.tbxaingqing.Text;
            sm.ProPic = this.lbimages.Text;
            if (SelectBLL.InsertUI(sm))
            {
                Response.Redirect("/SelectUI.aspx");
            }
            else {
                Response.Write("<script>alert('添加失败！')</script>");
            }

        }
        //上传图片
        protected void Button1_Click(object sender, EventArgs e)
        {
            string fileName = FileUpload1.FileName;
            string fileFix = fileName.Substring(fileName.LastIndexOf('.') + 1).ToLower();
            if (fileFix != "png" && fileFix != "jpg" && fileFix != "jpeg" && fileFix != "gif")
            {
                Response.Write("<script>alert('上传图片格式错误！')</script>");
            }
            else {
                FileUpload1.SaveAs(Server.MapPath(".") + "//Image//" + fileName);
                this.Image1.ImageUrl = "~/Image/" + fileName;
                this.lbimages.Text = fileName;
            }





        }
    }
}