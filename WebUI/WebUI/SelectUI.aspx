<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SelectUI.aspx.cs" Inherits="WebUI.SelectUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" Text="添加菜品" OnClick="Button1_Click" />
        <asp:GridView ID="GridView1" runat="server" OnRowDeleting="GridView1_RowDeleting">
            <Columns>
                <asp:BoundField DataField="Prold" HeaderText="菜品编号" />
                <asp:ImageField DataImageUrlField="ProPic" HeaderText="菜品图片" DataImageUrlFormatString="~/Image/{0}">
                </asp:ImageField>
                <asp:BoundField DataField="ProName" HeaderText="菜品名称" />
                <asp:BoundField DataField="Price" HeaderText="菜品价格" />
                <asp:BoundField DataField="ProInfo" HeaderText="菜品详情" />
                <asp:CommandField HeaderText="操作" ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
