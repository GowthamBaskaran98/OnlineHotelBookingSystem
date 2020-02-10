<%@ Page Title="" Language="C#" MasterPageFile="~/MainForm.Master" AutoEventWireup="true" CodeBehind="HotelOwnerPage.aspx.cs" Inherits="HotelBookingApplication.HotelOwnerPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Master" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Form" runat="server">
    <asp:Button ID="HotelRegistration" runat="server" Text="Register Hotel Detail" style="height: 26px"  OnClick ="RegisterButton_Click"/>
</asp:Content>
