<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="Activitylist.aspx.cs" Inherits="_382Project.activitylist" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
        <div class="align-self-start">
<asp:GridView ID="GridView1" runat="server" 
       
        AutoGenerateColumns="False"
      
        DataKeyNames="id" CssClass="table table-striped" Width="997px">

        <Columns>
            <asp:TemplateField HeaderText="ID">
               
                <ItemTemplate>
                    <asp:Label ID="Id" Text='<%#Bind("id")%>' runat="server"></asp:Label>
                     
                </ItemTemplate>
            </asp:TemplateField>
  <asp:TemplateField HeaderText="Type">
               
                <ItemTemplate>
                    <asp:Label ID="type" Text='<%#Bind("type")%>' runat="server"></asp:Label>
                     
                </ItemTemplate>
            </asp:TemplateField>
              <asp:TemplateField HeaderText="Title">
               
                <ItemTemplate>
                    <asp:Label ID="Labeltitle" Text='<%#Bind("title")%>' runat="server"></asp:Label>
                     
                </ItemTemplate>
            </asp:TemplateField>
              <asp:TemplateField HeaderText="Activity">
               
                <ItemTemplate>
                    <asp:Label ID="Labelactivity" Text='<%#Bind("activity")%>' runat="server"></asp:Label>
                     
                </ItemTemplate>
            </asp:TemplateField>
              <asp:TemplateField HeaderText="Date">
               
                <ItemTemplate>
                    <asp:Label ID="Labeldate" Text='<%#Bind("date")%>' runat="server"></asp:Label>
                     
                </ItemTemplate>
            </asp:TemplateField>
               <asp:TemplateField HeaderText="Score">
             
                <ItemTemplate>
                    <asp:Label ID="Total" Text='<%#Bind("score")%>' runat="server"></asp:Label>
                     
                </ItemTemplate>
            </asp:TemplateField>

             <asp:TemplateField HeaderText="Vote">
                <ItemTemplate>
              <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                 
                  <asp:ListItem Value="1">Like</asp:ListItem>
                <asp:ListItem Value="0">Disslike</asp:ListItem>

              </asp:RadioButtonList>
                  
                </ItemTemplate>
            </asp:TemplateField>


           

        </Columns>
    </asp:GridView>
                                        <p>  <asp:Button ID="Button1" runat="server" Text="Kaydet" CssClass="btn btn-primary" OnClick="Button1_Click" />       </p>

               <br>
                <p class="text-center">
                </p>
                <hr>
                  

                <asp:SqlDataSource ID="Activity_List" runat="server" ConnectionString="<%$ ConnectionStrings:WebProjectConnectionString %>" SelectCommand="SELECT [type], [date], [activity_by], [activity], [totalLikes], [totalDisslike], [id] FROM [Activities] ORDER BY [totalLikes] DESC"></asp:SqlDataSource>
        </div>
               
                        

    </form>

</asp:Content>
