﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertArtist.aspx.cs" Inherits="KpopZtation.View.InsertArtist" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <asp:Label ID="Label1" runat="server" Text="Artist Name"></asp:Label> <br />
        <asp:TextBox ID="artistNameBox" runat="server"></asp:TextBox> <br /><br />

        <asp:Label ID="Label2" runat="server" Text="Image"></asp:Label><br />
        <asp:FileUpload ID="imageUpload" runat="server" /><br /><br />

        <asp:Button ID="insertButton" runat="server" Text="Insert" OnClick="insertButton_Click" /><br />
        <asp:Label ID="warningLabel" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>