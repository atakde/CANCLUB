<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="Activity.aspx.cs" Inherits="_382Project.Activity" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <div class="d-flex justify-content-center">
  <div class="container">
        <div class="form-group input-group">
    	<div class="input-group-prepend">
		    <span class="input-group-text"> <i class="fa fa-user"></i> </span>
            <asp:TextBox ID="TitleTextBox" runat="server"  ValidationGroup="Submit" Placeholder="Title" CssClass="form-control"  Width="150px"></asp:TextBox>
		 </div>
            </div>
    <div class="form-group input-group">
    	<div class="input-group-prepend">
		    <span class="input-group-text"> <i class="fa fa-user"></i> </span>
            <asp:TextBox ID="ActivityType" runat="server" ValidationGroup="Submit" Placeholder="Type" CssClass="form-control"  Width="150px"></asp:TextBox>
		 </div>
            </div>
    <div class="form-group input-group">
    	<div class="input-group-prepend">
		    <span class="input-group-text"> <i class="fa fa-user"></i> </span>
            <asp:TextBox ID="ActivityDescription" runat="server"  ValidationGroup="Submit" Placeholder="Description" CssClass="form-control" TextMode="MultiLine" Width="350px" Height="100px"> </asp:TextBox>
		 </div>
            </div>
    <div class="form-group input-group">
    	<div class="input-group-prepend">
		    <span class="input-group-text"> <i class="fa fa-birthday-cake"></i> </span>
             <asp:TextBox ID="dttpTarih"  ValidationGroup="Submit" runat="server" type ="date" CssClass="form-control"  Width="150px"></asp:TextBox>
		 </div>
        </div>
    <div class="form-group">
   <asp:Button ID="Kaydet" runat="server" CssClass="btn btn-primary btn-block" Width="150px"  ValidationGroup="Submit" Text="Kaydet" OnClick="Kaydet_Click" />
       <p> <asp:RequiredFieldValidator ID="RequiredFieldTitleTextBoxt" ValidationGroup="Submit" runat="server" ErrorMessage="Please enter your TitleTextBox." ControlToValidate="TitleTextBox"></asp:RequiredFieldValidator></p>
           <p> <asp:RequiredFieldValidator ID="RequiredFielddttpTarih" ValidationGroup="Submit" runat="server" ErrorMessage="Please enter your Date." ControlToValidate="dttpTarih"></asp:RequiredFieldValidator></p>
          <p>  <asp:RequiredFieldValidator ID="RequiredFieldActivityType" ValidationGroup="Submit" runat="server" ErrorMessage="Please enter your ActivityType." ControlToValidate="ActivityType"></asp:RequiredFieldValidator></p>
          <p>  <asp:RequiredFieldValidator ID="RequiredFieldActivityDescription" ValidationGroup="Submit" runat="server" ErrorMessage="Please enter your ActivityDescription." ControlToValidate="ActivityDescription"></asp:RequiredFieldValidator></p>
                <asp:Label ID="Durum" runat="server" Text=""></asp:Label>

    </div> <!-- form-group// -->  
        </div>
        </div>
</asp:Content>
