<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertUI.aspx.cs" Inherits="WebUI.InsertUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h2>添加菜品</h2>
        菜品名称：<asp:TextBox ID="tbName" runat="server"></asp:TextBox>
        <br />
        菜品类型：
         
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <br />
        图片：
         
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:Button ID="Button1" runat="server" Text="上传" OnClick="Button1_Click" />
        <asp:Label ID="lbimages" runat="server"></asp:Label>
        <br />
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Image/" />
        <br />
        价格：
         
        <asp:TextBox ID="tbprice" runat="server"></asp:TextBox>
        <br />
        详情： 
        <asp:TextBox ID="tbxaingqing" runat="server" Height="91px" Width="222px"></asp:TextBox>
        <br />
        <asp:Button ID="Button2" runat="server" Text="确定" Height="35px" Width="91px" OnClick="Button2_Click" />    
        &nbsp; &nbsp;
        <asp:Button ID="Button3" runat="server" Text="取消" Height="35px" Width="89px" />








    </div>
    </form>
</body>
</html>
