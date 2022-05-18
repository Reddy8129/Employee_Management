<%@ Page Title="" Language="C#" MasterPageFile="~/Emp_leave_MasterPage.Master" AutoEventWireup="true" CodeBehind="AddLeaves_Master.aspx.cs" Inherits="EmployeeManagement.AddLeaves_Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Assets/Bootstrap/Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Assets/css/LeaveTypeMaster.css" rel="stylesheet" />
    <script src="Assets/Bootstrap/Scripts/jquery-3.2.1.min.js"></script>
    <script src="Assets/Bootstrap/Scripts/bootstrap.min.js"></script>
    <script src="Assets/js/LeaveTypeMaster.js"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="form-body">
        <div class="row">
            <div class="form-holder">
                <div class="form-content">
                    <div class="form-items">
                        <h3>Add Holidays in the Year</h3>
                                                <p>Fill in the data below.</p>
                        <form class="requires-validation" runat="server">
                            <div class="col-md-12">
                                <asp:TextBox ID="txtDate" type="date" runat="server" class="form-control" placeholder="Select Date"></asp:TextBox>
                            </div> 
                            <div class="col-md-12">
                                <asp:TextBox ID="txtName" runat="server" class="form-control" type="text" placeholder="Name of the holiday"></asp:TextBox>
                            </div>

                            <div class="form-button mt-3">
                                <asp:Button ID="btnAdd" runat="server" class="btn btn-primary" Text="Add" OnClick="btnAdd_Click" />
                            </div>

                             <asp:GridView ID="gvEduDetails" runat="server"
                                    CssClass="mydatagrid" PagerStyle-CssClass="pager" HeaderStyle-CssClass="header" RowStyle-CssClass="rows" AllowPaging="True" >
                                    <Columns>
                                        <asp:CommandField SelectImageUrl="Assets/images/icons8-edit-24.png" ButtonType="Image" ShowSelectButton="true" />
                                    </Columns>
                                </asp:GridView>

                            <div class="form-button mt-3">
                                <asp:Button ID="txtSubmit" runat="server" class="btn btn-primary" Text="Submit" OnClick="btnSubmit_Click" />
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
