<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ViewEmpDetails.aspx.cs" Inherits="EmployeeManagement.ViewEmpDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Assets/Bootstrap/Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Assets/Bootstrap/Scripts/bootstrap.min.js"></script>
    <!-- Mobile Specific Metas -->
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
    <!-- Font-->

    <link rel="stylesheet" type="text/css" href="Assets/css/nunito-font.css">
    <link rel="stylesheet" type="text/css" href="Assets/fonts/material-design-iconic-font/css/material-design-iconic-font.min.css">
    <!-- Main Style Css -->
    <link rel="stylesheet" href="Assets/css/style.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <center>
        <form runat="server">
            <asp:GridView ID="gvEmpDetails" runat="server"
            CssClass="mydatagrid" PagerStyle-CssClass="pager" HeaderStyle-CssClass="header" RowStyle-CssClass="rows" AllowPaging="True" OnSelectedIndexChanged="gvEmpDetails_SelectedIndexChanged">
            <columns>
                <asp:CommandField SelectImageUrl="Assets/images/icons8-edit-24.png" ButtonType="Image" ShowSelectButton="true" />
            </columns>
        </asp:GridView>
        </form>
        
    </center>
    </div>
    
    <script src="Assets/js/jquery-3.3.1.min.js"></script>
    <script src="Assets/js/jquery.steps.js"></script>
    <script src="Assets/js/main.js"></script>
</asp:Content>
