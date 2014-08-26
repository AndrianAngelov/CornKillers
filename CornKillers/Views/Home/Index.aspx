<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" 
Inherits="System.Web.Mvc.ViewPage<IEnumerable<CornKillers.Models.Serial>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <%--<div class="row">
        
        <h2 class="col-sm-12 text-center">
            <%: ViewData["Message"] %></h2>
        <h2 class="col-sm-12 text-center">
            <%: ViewData["PopCorn"] %></h2>
        <p class="col-sm-12 text-center">
            To learn more about ASP.NET MVC visit <a class="btn btn-danger" href="http://asp.net/mvc"
                title="ASP.NET MVC Website">http://asp.net/mvc</a>.
        </p>
    </div>--%>
   
    <div class="container grayOpacity">
        <p class="textwhitebold"><%: Membership.GetUser().UserName %></p>
        <p class="textwhitebold"><%: Membership.GetUser().ProviderUserKey %></p>
        <%--<p class="textwhitebold"><%: Membership.GetUser().ProviderUserKey %></p>--%>
        <%: Html.ActionLink("LogOut", "LogOff", "Account",new{}, new { @class = "textWhiteBold" })%>
        <table class="table">
            <thead>
                <tr>
                    <th>Serial ID</th>
                    <th>Serial Name</th>
                    <th>Description</th>
                    <th>Users</th>
                </tr>
            </thead>
            <tbody>
            <%foreach (var item in Model) 
                {%>
                <tr class="serialsPosters">
                    <td><%=item.SerialID%></td>
                    <td><%=item.Name%></td>
                    <td><%=item.Description%></td>
                    <td>
                        <%foreach (var user in item.ApplicationUsers) 
                        {%>
                            <p><%=user.Name%></p>
                        <%}%>
                    </td>
                </tr>
            <%}%>
            </tbody>
        </table>
        <%: Html.ActionLink("Add new serial", "Create", "Serials", new { }, new { @class = "textWhiteBold btn btn-danger" })%>
        
    </div>
</asp:Content>
