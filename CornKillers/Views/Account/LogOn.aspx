<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" 
Inherits="System.Web.Mvc.ViewPage<CornKillers.Models.LogOnModel>" %>

<asp:Content ID="loginTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Log On
</asp:Content>

<asp:Content ID="loginContent" ContentPlaceHolderID="MainContent" runat="server" >
        <%--<div id="InfoSlider" class="col-md-6">--%>
            <%--<div id="carousel-example-generic" class="carousel slide" data-ride="carousel">
                <!-- Indicators -->
                <ol class="carousel-indicators">
                <li data-target="#carousel-example-generic" data-slide-to="0" class="active"></li>
                <li data-target="#carousel-example-generic" data-slide-to="1"></li>
                <li data-target="#carousel-example-generic" data-slide-to="2"></li>
                </ol>

                <!-- Wrapper for slides -->
                <div class="carousel-inner">
                <div class="item active">
                    <img src="../../Content/Images/pop-corn11.jpg" alt="...">
                    <div class="carousel-caption">
                    ...
                    </div>
                </div>
                <div class="item">
                    <img src="../../Content/Images/pop-corn11.jpg" alt="...">
                    <div class="carousel-caption">
                    ...
                    </div>
                </div>
                <div class="item">
                    <img src="../../Content/Images/pop-corn11.jpg" alt="...">
                    <div class="carousel-caption">
                    ...
                    </div>
                </div>
                </div>

                <!-- Controls -->
                <a class="left carousel-control" href="#carousel-example-generic" role="button" data-slide="prev">
                <span class="glyphicon glyphicon-chevron-left"></span>
                </a>
                <a class="right carousel-control" href="#carousel-example-generic" role="button" data-slide="next">
                <span class="glyphicon glyphicon-chevron-right"></span>
                </a>
            </div>--%>
            <%--<img id="Img1" src="~/Content/Images/pop-corn1.png" alt="Newbie-Code-Logo" runat="server">--%>
            <%--<div id="ballWrapper">
                 <div id="ball">
                    <img id="popCorn" src="~/Content/Images/pop-corn1.png" alt="Newbie-Code-Logo" runat="server">
                 </div>
                 <div id="ballShadow"></div>
            </div>--%>
       <%-- </div>--%>
    <div class="row">
        <% using (Html.BeginForm("LogOn", "Account", FormMethod.Post,
                                  new { @id = "LoginForm", @class = "form-horizontal col-md-6 col-md-offset-3 col-sm-6 col-sm-offset-3 col-xs-8 col-xs-offset-2" }))
       { %>
        <%: Html.ValidationSummary(true, "Login was unsuccessful. Please correct the errors and try again.")%>

        

            <h2 class="text-center">Account Information</h2>

            <div class="input-group">
                <div class="input-group-addon"><span class="glyphicon glyphicon-user"></span></div>
                <%: Html.TextBoxFor(m => m.UserName, new { @class = "form-control", @placeholder = "Username" })%>
                <%: Html.ValidationMessageFor(m => m.UserName)%>
            </div>

            <br />
            <div class="input-group">
                <div class="input-group-addon">
                    <span class="glyphicon glyphicon-lock"></span>
                </div>
                <%: Html.PasswordFor(m => m.Password, new { @class = "form-control", @placeholder = "Password" })%>
                <%: Html.ValidationMessageFor(m => m.Password)%>
            </div>

            <div class="col-sm-12">
                <%: Html.CheckBoxFor(m => m.RememberMe) %>
                <%: Html.LabelFor(m => m.RememberMe) %>
            </div>

            <p class="col-sm-12">
                <input id="loginBtn" class="btn btn-success" type="submit" value="Login" />
                <%--<%: Html.ActionLink("Home", "Index", "Home")%>--%>
            </p>

            <p class="col-sm-12">
                Please enter your username and password.
                <%: Html.ActionLink("Register", "Register")%>
                if you don't have an account.
            </p>

        <% } %>
    </div>

    <%--<div id="infoGraphic" class="row info">
    </div>--%>
</asp:Content>
