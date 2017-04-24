<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="FishLand_FrontEnd.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div id="content">
        <h1>Contact Us Today</h1>
        <p>For any complaints or suggestions on how we can better improve our service; that is: serve you better, please leave 
		   a message below by filling in our contact form.
        </p>
        <br /><br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        <br />
        <textarea id="TextArea1" cols="45" rows="5"></textarea>
        <br /><br />
        <asp:Button ID="Button1" runat="server" Text="Button" />

    </div>
</asp:Content>
