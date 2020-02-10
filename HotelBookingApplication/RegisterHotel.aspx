<%@ Page Title="" Language="C#" MasterPageFile="~/MainForm.Master" AutoEventWireup="true" CodeBehind="RegisterHotel.aspx.cs" Inherits="HotelBookingApplication.RegisterHotel" %>
<asp:Content ID="Master" ContentPlaceHolderID="Master" runat="server">
</asp:Content>
<asp:Content ID="RegisterHotel" ContentPlaceHolderID="Form" runat="server">
       <div>
        <h2 style="background-color : cornflowerblue ">Sign Up</h2>
        <table align ="center" >
                <tr>  
                    <td>Hotel Name :</td>  
                    <td>  
                        <asp:TextBox ID="txtHotelName" runat="server"></asp:TextBox>  
                    </td>  
                     <td>
                        <asp:RequiredFieldValidator runat="server" ID="requiredHotelName" ControlToValidate="txtHotelName" ErrorMessage="Hotel Name Required" Style="color :royalblue "></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="rgvHotelName" runat="server" ControlToValidate="txtHotelName" ErrorMessage="Enter a valid Hotel name" ValidationExpression="^[A-Za-z]+$"></asp:RegularExpressionValidator>
                    </td>
               </tr> 
                <tr>  
                    <td>Hotel Address :</td>  
                    <td>  
                        <asp:TextBox ID="txtHotelAddress" runat="server"></asp:TextBox>  
                    </td>  
                     <td>
                        <asp:RequiredFieldValidator runat="server" ID="requiredHotelAddress" ControlToValidate="txtHotelAddress" ErrorMessage="Hotel Address Required" Style="color :royalblue "></asp:RequiredFieldValidator>
                       <asp:RegularExpressionValidator ID="rgvHotelAddress" runat="server" ControlToValidate="txtHotelAddress" ErrorMessage="Enter a valid address" ValidationExpression="^[A-Za-z]+$"></asp:RegularExpressionValidator>  
                     </td>
               </tr> 
                <tr>  
                    <td>Total Rooms :</td>  
                    <td>  
                        <asp:TextBox ID="txtTotalRoom" runat="server"></asp:TextBox>  
                    </td> 
                    <td> 
                    <asp:RequiredFieldValidator runat="server" ID="requiredTotalRoom" ControlToValidate="txtTotalRoom" ErrorMessage="Number of Rooms Required" Style="color: palevioletred"></asp:RequiredFieldValidator>                            
                        </td>
               </tr> 
                <tr>  
                    <td>Booked Rooms :</td>  
                    <td>  
                        <asp:TextBox ID="txtBookedRoom" runat="server"></asp:TextBox>  
                    </td> 
                    <td> 
                    <asp:RequiredFieldValidator runat="server" ID="RequiredBookedRoom" ControlToValidate="txtBookedRoom" ErrorMessage="Number of Rooms Required" Style="color: palevioletred"></asp:RequiredFieldValidator>                            
                    </td>
               </tr> 
                 <tr>  
                    <td>Available Rooms :</td>  
                    <td>  
                        <asp:TextBox ID="txtAvailableRoom" runat="server"></asp:TextBox>  
                    </td>  
 
                    <td> 
                    <asp:RequiredFieldValidator runat="server" ID="RequiredAvailableRoom" ControlToValidate="txtAvailableRoom" ErrorMessage="Number of Rooms Required" Style="color: palevioletred"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>  
                    <td>Enter Room Amenities :</td>  
                    <td>  
                        <asp:TextBox ID="txtRoomAmenities" runat="server"></asp:TextBox>  
                    </td>  
 
                    <td> 
                    <asp:RequiredFieldValidator runat="server" ID="RequiredRoomAmenities" ControlToValidate="txtRoomAmenities" ErrorMessage="Room Amenities Required" Style="color: palevioletred"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>  
                    <td>Price Per Day :</td>  
                    <td>  
                        <asp:TextBox ID="txtPricePerDay" runat="server"></asp:TextBox>  
                    </td>  
 
                    <td> 
                    <asp:RequiredFieldValidator runat="server" ID="RequiredPrice" ControlToValidate="txtPricePerDay" ErrorMessage="Price Per Day Required" Style="color: palevioletred"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" style="height: 26px"  OnClick ="Submit_Click"/>
                    </td>              
                </tr>  
            </table>
    </div>
</asp:Content>