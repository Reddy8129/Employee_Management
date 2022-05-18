<%@ Page Title="" Language="C#" MasterPageFile="~/Emp_leave_MasterPage.Master" AutoEventWireup="true" CodeBehind="LeaveType_Master.aspx.cs" Inherits="EmployeeManagement.LeaveType_Master" %>

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
                        <h3>Add New Leave Type</h3>
                        <p>Fill in the data below.</p>
                        <form class="requires-validation" runat="server">

                            <div class="col-md-12">
                                <label>Enter Leave Type:</label>
                                <asp:TextBox ID="txtLeaveType" runat="server" class="form-control"></asp:TextBox>
                            </div>
                            <div class="col-md-12">
                                <label>Enter Number of Leaves:</label>
                                <asp:TextBox ID="txtNoOfLeaves" runat="server" class="form-control"></asp:TextBox>
                            </div>

                            <div class="form-button mt-3">
                                <asp:Button ID="btnSubmit" runat="server" class="btn btn-primary" Text="Register" OnClick="btnSubmit_Click" />
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
