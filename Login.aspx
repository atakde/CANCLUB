<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="_382Project.giris" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <!-- form-group// -->
    <!-- form-group// -->
    <hr>
    <div class="d-flex justify-content-center">
        <div class="container">

            <div class="form-group input-group">
                <div class="input-group-prepend">
                    <span class="input-group-text"><i class="fa fa-envelope"></i></span>
                    <asp:TextBox ID="Username" runat="server" Placeholder="Username" CssClass="form-control" Width="150px" required> </asp:TextBox>

                </div>
            </div>
            <!-- form-group// -->
            <!-- form-group// -->
            <!-- form-group// -->
            <!-- form-group// -->
            <div class="form-group input-group">
                <div class="input-group-prepend">
                    <span class="input-group-text"><i class="fa fa-key"></i></span>
                    <asp:TextBox ID="Password" runat="server" Placeholder="Password" CssClass="form-control" Width="150px" TextMode="Password" required></asp:TextBox>
                </div>

            </div>
            <!-- form-group// -->
            <!-- form-group// -->
            <div class="form-group">
                <asp:Button ID="Kaydet" runat="server" CssClass="btn btn-primary btn-block" Text="Kaydet" Width="150px" OnClick="Kaydet_Click" />
            </div>
            <!-- form-group// -->
            Don't have an account? <a href="Register.aspx">Register</a> </p>      
                    <asp:Label ID="Durum" runat="server" ForeColor="Red"></asp:Label>
        </div>

    </div>
</asp:Content>
