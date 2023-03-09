<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="MainSite.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

  
    <br />

    <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate" ></asp:Login>

    <asp:TextBox ID="TextBoxNewPassword" Visible="false" runat="server"></asp:TextBox>
    <br /> 
    <asp:TextBox ID="TextBoxConfirmPassword" Visible="false" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btn_SavePassword" Visible="false" runat="server" Text="Reset Password" OnClick="btn_SavePassword_Click" />
       <br />
       <br />
       <asp:Label id="lblMsg" Font-Name="Verdana" Font-Size="10" Visible ="false" runat="server"/>
       <br />
       <br />
       <asp:LoginStatus ID="LoginStatus1" Visible="false" runat="server" />


</asp:Content>
