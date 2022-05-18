<%@ Page Title="" Language="C#" MasterPageFile="~/Emp_leave_MasterPage.Master" AutoEventWireup="true" CodeBehind="RequestLeave.aspx.cs" Inherits="EmployeeManagement.RequestLeave" %>
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
                        <h3>Request Leaves</h3>
                        <p>Fill in the data below.</p>
                        <form class="requires-validation" runat="server">
                            <div class="col-md-12">
                                <label>Enter Employee Id</label>
                                <asp:TextBox ID="txtEmpId" type="number" runat="server" class="form-control" placeholder="Employee Id"></asp:TextBox>
                            </div> 
                            <div class="col-md-12">
                                <label>Select Leave Type</label>
                                <asp:DropDownList runat="server" class="form-control" ID="ddLeavetype">
                                            <asp:ListItem></asp:ListItem>
                                        </asp:DropDownList>
                            </div>
                            <div class="col-md-12">
                                <label>Select From Date</label>
                                <asp:TextBox ID="txtFromDate" runat="server" class="form-control" type="date" placeholder="Leave From"></asp:TextBox>
                            </div>
                            <div class="col-md-12">
                                <label>Select To Date</label>
                                <asp:TextBox ID="txtToDate" runat="server" class="form-control" type="date" placeholder="Leave To"></asp:TextBox>
                            </div>

                            <div class="form-button mt-3">
                                <asp:Button ID="btnAdd" runat="server" class="btn btn-primary" Text="Submit" OnClick="btnAdd_Click"  />
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
