<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_0615_Hello.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         
         <h1>
             <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
             <asp:Button ID="Button1" runat="server" BackColor="Silver" OnClick="Button1_Click" Text="OK" />
         </h1>
        <asp:Literal ID="Literal1" runat="server" Text="" ></asp:Literal>
    </div>
    </form>
         
         
</body>
</html>
