﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MainForm.Master" AutoEventWireup="true" CodeBehind="HotelOwnerPage.aspx.cs" Inherits="HotelBookingApplication.HotelOwnerPage" %>
<asp:Content ID="Master" ContentPlaceHolderID="Master" runat="server">
</asp:Content>
<asp:Content ID="HotelOwnerPage" ContentPlaceHolderID="Form" runat="server">
    <asp:Button ID="HotelRegistration" runat="server" Text="Register Hotel Detail" style="height: 26px"  OnClick ="RegisterButton_Click"/>
</asp:Content>
