using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
namespace WebUI
{
    public partial class SelectUI : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            this.GridView1.AutoGenerateColumns = false;
            this.GridView1.DataSource = SelectBLL.SelectUI();
            this.GridView1.DataBind();
        }
        //删除
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int ID = int.Parse(this.GridView1.Rows[e.RowIndex].Cells[0].Text.ToString());

            if (SelectBLL.UpdataUI(ID))
            {
                Response.Redirect("/SelectUI.aspx");
            }
            else
            {
                Response.Write("<script>alert('删除失败！')</script>");
            }




        }
        //添加菜品
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/InsertUI.aspx");
        }






    }
}