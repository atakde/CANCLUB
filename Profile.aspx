<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="_382Project.profil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <hr>
    <div class="container bootstrap snippet">
        <div class="row">
        </div>
        <div class="row">
            <div class="col-sm-3">
                <!--left col-->


                <div class="text-center">
                    <asp:Image ID="ProfilResmi" runat="server" Height="300px" Width="300px" CssClass="avatar img-circle img-thumbnail" alt="avatar" />
                    <h6>
                        <asp:Label ID="User" CssClass="form-control" runat="server" Text="Label"></asp:Label>
                        </h6>
                    <asp:FileUpload ID="fluDosya" CssClass="text-center center-block file-upload" runat="server" required />
                </div>
                <br>

                <ul class="list-group">
                    <li class="list-group-item text-muted">Status <i class="fa fa-dashboard fa-1x"></i></li>
                    <li class="list-group-item text-right"><span style="float: left"><strong>Activities</strong></span>
                        <asp:Label ID="Aktivite" runat="server" Text=""></asp:Label></li>
                    <li class="list-group-item text-right"><span style="float: left"><strong>Likes</strong></span><asp:Label ID="Like" runat="server" Text=""></asp:Label></li>
                    <li class="list-group-item text-right"><span style="float: left"><strong>Dislikes</strong></span>
                        <asp:Label ID="Dislike" runat="server" Text=""></asp:Label></li>
                </ul>

                <div class="panel panel-default">
                </div>

            </div>
            <!--/col-3-->
            <div class="col-sm-9">


                <div class="tab-content">
                    <div class="tab-pane active" id="home">
                        <hr>
                        <div class="form-group">

                            <div class="col-xs-6">
                                <label for="first_name">
                                    <h4>First name</h4>
                                </label>
                                <asp:TextBox ID="FirstName" CssClass="form-control" Placeholder="First Name" runat="server" required></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">

                            <div class="col-xs-6">
                                <label for="last_name">
                                    <h4>Last name</h4>
                                </label>
                                <asp:TextBox ID="LastName" runat="server" Placeholder="LastName" CssClass="form-control" required> </asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">

                            <div class="col-xs-6">
                                <label for="email">
                                    <h4>Email</h4>
                                </label>
                                <asp:TextBox ID="Email" runat="server" Placeholder="Email" CssClass="form-control" TextMode="Email" required> </asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">

                            <div class="col-xs-6">
                                <label for="last_name">
                                    <h4>Department</h4>
                                </label>
                                <asp:TextBox ID="Department" runat="server" Placeholder="Department" CssClass="form-control" required> </asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">

                            <div class="col-xs-6">
                                <label for="password">
                                    <h4>Password</h4>
                                </label>
                                <asp:TextBox ID="Password" runat="server" Placeholder="Password" CssClass="form-control" TextMode="Password" required></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-xs-12">
                                <asp:Button ID="Kaydet" runat="server" CssClass="btn btn-lg btn-primary pull-right" Text="Kaydet" OnClick="Kaydet_Click" />
                            </div>
                        </div>
                        <asp:Label ID="Durum" runat="server" Text=""></asp:Label>
                        <hr>
                    </div>
                    <!--/tab-pane-->
                </div>
            </div>
        </div>
</div>          
       
</asp:Content>
