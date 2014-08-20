<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <h2 class="col-sm-12 text-center">
            <%: ViewData["Message"] %></h2>
        <h2 class="col-sm-12 text-center">
            <%: ViewData["PopCorn"] %></h2>
        <p class="col-sm-12 text-center">
            To learn more about ASP.NET MVC visit <a class="btn btn-danger" href="http://asp.net/mvc"
                title="ASP.NET MVC Website">http://asp.net/mvc</a>.
        </p>
    </div>
    <div class="container">
        <div class="row">
            <div class="col-sm-6 col-sm-4 col-sm-offset-4">
                <h1 class="text-center login-title">
                    Sign in to continue to Bootsnipp</h1>
                <div class="account-wall">
                    <img class="profile-img" src="https://lh5.googleusercontent.com/-b0-k99FZlyE/AAAAAAAAAAI/AAAAAAAAAAA/eu7opA4byxI/photo.jpg?sz=120"
                        alt="">
                    <form class="form-signin">
                    <input type="text" class="form-control" placeholder="Email" required autofocus>
                    <input type="password" class="form-control" placeholder="Password" required>
                    <button class="btn btn-lg btn-primary btn-block" type="submit">
                        Sign in</button>
                    <label class="checkbox pull-left">
                        <input type="checkbox" value="remember-me">
                        Remember me
                    </label>
                    <a href="#" class="pull-right need-help">Need help? </a><span class="clearfix"></span>
                    </form>
                </div>
                <a href="#" class="text-center new-account">Create an account </a>
            </div>
        </div>
    </div>
</asp:Content>
