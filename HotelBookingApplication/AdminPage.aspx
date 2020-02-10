<%@ Page Title="" Language="C#" MasterPageFile="~/MainForm.Master" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="HotelBookingApplication.AdminPage" %>
<asp:Content ID="Master" ContentPlaceHolderID="Master" runat="server">
</asp:Content>
<asp:Content ID="AdminPages" ContentPlaceHolderID="Form" runat="server">
    <asp:Button ID="btnUserDetail" runat="server" Text="User_detail" style="height: 26px"  OnClick ="User_Detail"/>
    <asp:Button ID="btnHotelDetail" runat="server" Text="Hotel_detail" style="height: 26px"  OnClick ="Hotel_Detail"/>
</asp:Content>
