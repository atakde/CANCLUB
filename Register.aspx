<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="_382Project.regdeneme" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <div class="d-flex justify-content-center">
        <div class="container">
            <br>
            <p class="text-center">
                Please write your information correctly.
            </p>
            <hr>
            <div class="form-group input-group">
                <div class="input-group-prepend">
                    <span class="input-group-text"><i class="fa fa-user"></i></span>
                    <asp:TextBox ID="FirstName" CssClass="form-control" Placeholder="First Name" ValidationGroup="Submit" Width="150px" runat="server"></asp:TextBox>
                </div>


            </div>
            <!-- form-group// -->
            <div class="form-group input-group">
                <div class="input-group-prepend">
                    <span class="input-group-text"><i class="fa fa-envelope"></i></span>
                    <asp:TextBox ID="Email" runat="server" Placeholder="Email" CssClass="form-control" ValidationGroup="Submit" Width="150px" TextMode="Email"> </asp:TextBox>

                </div>
            </div>
            <!-- form-group// -->
            <!-- form-group// -->
            <div class="form-group input-group">
                <div class="input-group-prepend">
                    <span class="input-group-text"><i class="fa fa-user"></i></span>
                    <asp:TextBox ID="LastName" runat="server" Placeholder="LastName" CssClass="form-control" ValidationGroup="Submit" Width="150px"> </asp:TextBox>
                </div>
            </div>
            <!-- form-group// -->
            <!-- form-group// -->
            <div class="form-group input-group">
                <div class="input-group-prepend">
                    <span class="input-group-text"><i class="fa fa-user"></i></span>
                    <asp:TextBox ID="Username" runat="server" Placeholder="UserName" CssClass="form-control" ValidationGroup="Submit" Width="150px"> </asp:TextBox>
                </div>

            </div>
            <!-- form-group// -->
            <!-- form-group// -->
            <!-- form-group// -->
            <div class="form-group input-group">
                <div class="input-group-prepend">
                    <span class="input-group-text"><i class="fa fa-home"></i></span>
                    <asp:TextBox ID="Department" runat="server" Placeholder="Department" CssClass="form-control" ValidationGroup="Submit" Width="150px"> </asp:TextBox>

                </div>
            </div>
            <!-- form-group// -->
            <!-- form-group// -->
            <div class="form-group input-group">
                <div class="input-group-prepend">
                    <span class="input-group-text"><i class="fa fa-key"></i></span>
                    <asp:TextBox ID="Password" runat="server" Placeholder="Password" CssClass="form-control" Width="150px" ValidationGroup="Submit" TextMode="Password"></asp:TextBox>
                </div>

            </div>
            <!-- form-group// -->
            <!-- form-group// -->
            <div class="form-group input-group">
                <div class="input-group-prepend">
                    <span class="input-group-text"><i class="fa fa-birthday-cake"></i></span>
                    <asp:TextBox ID="dttpTarih" runat="server" type="date" CssClass="form-control" ValidationGroup="Submit" Width="150px"></asp:TextBox>
                </div>

            </div>
            <!-- form-group// -->
            <!-- form-group// -->
            <div class="form-group input-group">
                <div class="input-group-prepend">
                    <span class="input-group-text"><i class="fa fa-upload"></i></span>
                    <asp:FileUpload ID="fluDosya" CssClass="btn btn-primary btn-sm" ValidationGroup="Submit" runat="server" />

                </div>
            </div>
            <!-- form-group// -->

            <div class="form-group">
                <asp:Button ID="Kaydet" runat="server" CssClass="btn btn-primary btn-block" ValidationGroup="Submit" Width="150px" Text="Kaydet" OnClick="Kaydet_Click" />
                
    <p>


        <asp:Label ID="Durum" runat="server" Text=""></asp:Label>
    </p>
                <p>
                    <asp:RequiredFieldValidator ID="RequiredFieldFirstName" runat="server" ValidationGroup="Submit" ErrorMessage="Please enter your name." ControlToValidate="FirstName"></asp:RequiredFieldValidator></p>
                <p>
                    <asp:RequiredFieldValidator ID="RequiredFieldEmail" ValidationGroup="Submit" runat="server" ErrorMessage="Please enter your Email." ControlToValidate="Email"></asp:RequiredFieldValidator></p>
                <p>
                    <asp:RequiredFieldValidator ID="RequiredFieldLastName" ValidationGroup="Submit" runat="server" ErrorMessage="Please enter your last name." ControlToValidate="LastName"></asp:RequiredFieldValidator></p>
                <p>
                    <asp:RequiredFieldValidator ID="RequiredFieldUserName" ValidationGroup="Submit" runat="server" ErrorMessage="Please enter your user name." ControlToValidate="UserName"></asp:RequiredFieldValidator></p>
                <p>
                    <asp:RequiredFieldValidator ID="RequiredFieldDepartment" ValidationGroup="Submit" runat="server" ErrorMessage="Please enter your department name." ControlToValidate="Department"></asp:RequiredFieldValidator></p>
                <p>
                    <asp:RequiredFieldValidator ID="RequiredFieldUploadFile" ValidationGroup="Submit" runat="server" ErrorMessage="Please enter your profile photo." ControlToValidate="fluDosya"></asp:RequiredFieldValidator></p>
                <p>
                    <asp:RequiredFieldValidator ID="RequiredFieldPassword" ValidationGroup="Submit" runat="server" ErrorMessage="Please enter your password." ControlToValidate="Password"></asp:RequiredFieldValidator></p>
                <p>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ValidationGroup="Submit" runat="server" ErrorMessage="Please enter your birthdate." ControlToValidate="dttpTarih"></asp:RequiredFieldValidator></p>
            </div>
            <!-- form-group// -->

        </div>

    </div></asp:Content>



