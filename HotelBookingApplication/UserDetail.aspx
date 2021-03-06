﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MainForm.Master" AutoEventWireup="true" CodeBehind="UserDetail.aspx.cs" Inherits="HotelBookingApplication.UserDetail" %>
<asp:Content ID="Master" ContentPlaceHolderID="Master" runat="server">
</asp:Content>
<asp:Content ID="UserDetail" ContentPlaceHolderID="Form" runat="server">
    <div>
        <h1>as</h1>
    <asp:GridView ID="UserProfile" runat="server" AutoGenerateColumns="False" DataKeyNames="userId" AutoGenerateEditButton="true" AutoGenerateDeleteButton="true"
      OnRowDeleting="UserProfile_RowDeleting" OnRowEditing="UserProfile_RowEditing" OnRowCancelingEdit="UserProfile_RowCancelingEdit" OnRowUpdating="UserProfile_RowUpdating">
        <Columns>
            <asp:TemplateField HeaderText="FirstName" runat="server">
                <ItemTemplate>
                    <asp:Label ID="txtFirstName" runat="server" Text='<%# Bind("firstName") %>'></asp:Label>
                </ItemTemplate> 
                <EditItemTemplate>
                    <asp:TextBox ID="txtFirstName" runat="server" Text='<%# Bind("firstName") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="LastName" runat="server">
                <ItemTemplate>
                    <asp:Label ID="txtLastName" runat="server" Text='<%# Bind("lastName") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtLastName" runat="server" Text='<%# Bind("lastName") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="MobilePhone" runat="server">
                <ItemTemplate>
                    <asp:Label ID="txtMobileNumber" runat="server" Text='<%# Bind("mobileNumber") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtMobileNumber" runat="server" Text='<%# Bind("mobileNumber") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="password" runat="server">
                <ItemTemplate>
                    <asp:Label ID="txtPassword" runat="server" Text='<%# Bind("password") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtPassword" runat="server" Text='<%# Bind("password") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Mail ID" runat="server">
                <ItemTemplate>
                    <asp:Label ID="txtMail" runat="server" Text='<%# Bind("gmail") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtMail" runat="server" Text='<%# Bind("gmail") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="User Type" runat="server">
                <ItemTemplate>
                    <asp:Label ID="txtUserType" runat="server" Text='<%# Bind("userType") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtUserType" runat="server" Text='<%# Bind("userType") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
        </div>
</asp:Content>