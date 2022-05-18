<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="EmpDetails.aspx.cs" Inherits="EmployeeManagement.EmpDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- Mobile Specific Metas -->
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
    <!-- Font-->

    <link rel="stylesheet" type="text/css" href="Assets/css/nunito-font.css">
    <link rel="stylesheet" type="text/css" href="Assets/fonts/material-design-iconic-font/css/material-design-iconic-font.min.css">
    <!-- Main Style Css -->
    <link rel="stylesheet" href="Assets/css/style.css" />
    <style>
        .myButton {
            box-shadow: inset 0px 1px 0px 0px #ffffff;
            background: linear-gradient(to bottom, #f9f9f9 5%, #e9e9e9 100%);
            background-color: #f9f9f9;
            border-radius: 6px;
            border: 1px solid #dcdcdc;
            display: inline-block;
            cursor: pointer;
            color: #666666;
            font-family: Arial;
            font-size: 17px;
            font-weight: bold;
            padding: 12px 48px ;
            
            text-decoration: none;
            text-shadow: 0px 1px 0px #ffffff;
        }

            .myButton:hover {
                background: linear-gradient(to bottom, #e9e9e9 5%, #f9f9f9 100%);
                background-color: #e9e9e9;
            }

            .myButton:active {
                position: relative;
                top: 1px;
            }
            .button{
                padding:22px 22px 22px 22px;
            }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="page-content">
        <div class="wizard-v5-content">
            <div class="wizard-form">
                <form class="form-register" id="form1" runat="server">
                    <div id="form-total">
                        <!--Section-1-->
                        <h2>
                            <span class="step-icon"><i class="zmdi zmdi-check"></i></span>
                            <span class="step-text">Personal Info</span>
                        </h2>
                        <section>
                            <div class="inner">
                                <div class="form-row">
                                    <div class="form-holder">
                                        <label for="first_name">First Name</label>
                                        <asp:TextBox runat="server" type="text" placeholder="" class="form-control firstname" ID="txtFirstName" name="first_name"></asp:TextBox>
                                    </div>
                                    <div class="form-holder">
                                        <label for="last_name">Last Name</label>
                                        <asp:TextBox runat="server" type="text" placeholder="" class="form-control lastname" ID="txtLastName" name="last_name"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-row">
                                    <div id="radio">
                                        <label for="gender">Gender:</label>
                                        <asp:RadioButtonList runat="server" ID="radioGender" class="gender">
                                            <asp:ListItem>Male</asp:ListItem>
                                            <asp:ListItem>Female</asp:ListItem>
                                        </asp:RadioButtonList>
                                    </div>
                                </div>
                                <div class="form-row">
                                    <div class="form-holder form-holder-2">
                                        <label for="address">Address Location</label>
                                        <asp:TextBox runat="server" type="text" placeholder="" class="form-control address" ID="txtAddress" name="address"></asp:TextBox>
                                        <span><i class="zmdi zmdi-pin"></i></span>
                                    </div>
                                </div>
                                <div class="form-row">
                                    <div class="form-holder form-holder-3">
                                        <label for="phone">Phone Number</label>
                                        <asp:TextBox runat="server" type="number" placeholder="" class="form-control phno" ID="txtPhone" name="phone"></asp:TextBox>
                                    </div>
                                    <div class="form-holder">
                                        <label for="code">Zip Code</label>
                                        <asp:TextBox runat="server" type="number" class="form-control zipcode" ID="txtCode" name="code"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-row">
                                    <div class="form-holder form-holder-3">
                                        <label for="email">Email Address</label>
                                        <asp:TextBox runat="server" type="email" placeholder="" class="form-control email" ID="txtEmail"></asp:TextBox>
                                    </div>
                                    <div class="form-holder">
                                        <label for="code">Date of Birth</label>
                                        <asp:TextBox runat="server" type="date" class="form-control dob" ID="txtDob"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </section>
                        <!--Section 2-->
                        <h2>
                            <span class="step-icon"><i class="zmdi zmdi-check"></i></span>
                            <span class="step-text">Emloyment</span>
                        </h2>
                        <section>
                            <div class="inner">
                                <div class="form-row">
                                    <div class="form-holder">
                                        <label for="designation">Designation:</label>
                                        <asp:DropDownList runat="server" class="form-control designation" ID="txtDesignation">
                                            <asp:ListItem></asp:ListItem>
                                            <asp:ListItem>A</asp:ListItem>
                                            <asp:ListItem>B</asp:ListItem>
                                            <asp:ListItem>C</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <div class="form-holder">
                                        <label for="Department">Department:</label>
                                        <asp:DropDownList runat="server" class="form-control department" ID="txtDepartment">
                                            <asp:ListItem></asp:ListItem>
                                            <asp:ListItem>X</asp:ListItem>
                                            <asp:ListItem>Y</asp:ListItem>
                                            <asp:ListItem>Z</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="form-row">
                                    <div class="form-holder">
                                        <label for="location">Location:</label>
                                        <asp:TextBox runat="server" type="text" placeholder="" class="form-control location" ID="txtLocation"></asp:TextBox>
                                    </div>
                                    <div class="form-holder">
                                        <label for="manager">Reporting Manager:</label>
                                        <asp:TextBox runat="server" type="text" placeholder="" class="form-control manager" ID="txtManager"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-row">
                                    <div class="form-holder">
                                        <label for="doj">Date of Joining:</label>
                                        <asp:TextBox runat="server" type="date" placeholder="" class="form-control doj" ID="txtDOJ"></asp:TextBox>
                                    </div>
                                    <div class="form-holder">
                                        <label for="pre-employment">Previous Employment:</label>
                                        <asp:TextBox runat="server" type="text" placeholder="" class="form-control prevemp" ID="txtPreviousEmployment"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </section>
                        <!--Section 3-->
                        <h2>
                            <span class="step-icon"><i class="zmdi zmdi-check"></i></span>
                            <span class="step-text">Education</span>
                        </h2>
                        <section>
                            <div class="inner" style="padding: 0px 220px 0px 40px">
                                <div class="form-row">
                                    <div class="form-holder form-holder-2">
                                        <label for="address">School/College Name</label>
                                        <asp:TextBox runat="server" type="text" placeholder="" class="form-control" ID="txtSchool" name="School"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-row">
                                    <div class="form-holder">
                                        <label for="designation">University:</label>
                                        <asp:TextBox runat="server" type="text" placeholder="" class="form-control" ID="txtUniversity"></asp:TextBox>
                                    </div>
                                    <div class="form-holder">
                                        <label for="Degree">Degree:</label>
                                        <asp:DropDownList runat="server" class="form-control" ID="txtDegree">
                                            <asp:ListItem></asp:ListItem>
                                            <asp:ListItem>10</asp:ListItem>
                                            <asp:ListItem>12</asp:ListItem>
                                            <asp:ListItem>Diploma</asp:ListItem>
                                            <asp:ListItem>UG</asp:ListItem>
                                            <asp:ListItem>PG</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="form-row">
                                    <div class="form-holder">
                                        <label for="location">Course:</label>
                                        <asp:TextBox runat="server" type="text" placeholder="" class="form-control input-step-2" ID="txtCourse"></asp:TextBox>
                                    </div>
                                    <div class="form-holder">
                                        <label for="manager">Percentage/CGPA:</label>
                                        <asp:TextBox type="text" placeholder="" class="form-control input-step-2" ID="txtPercentageCgpa" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-row">
                                    <div class="form-holder">
                                        <label for="location">Start-Date:</label>
                                        <asp:TextBox type="date" class="form-control input-step-2" ID="txtStartDate" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="form-holder">
                                        <label for="manager">Ending-Date:</label>
                                        <asp:TextBox type="date" class="form-control input-step-2" ID="txtEndingDate" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <center>
                                    <div class="button">
                                        <asp:Button ID="btnAddEduDet" runat="server" Text="Add" CssClass="myButton" OnClick="btnAddEduDet_Click" />
                                    </div>
                                </center>
                            </div>
                            <center>
                                <asp:GridView ID="gvEduDetails" runat="server" OnSelectedIndexChanged="gvEduDetails_SelectedIndexChanged" OnRowDeleting="gvEduDetails_RowDeleting"
                                    CssClass="mydatagrid" PagerStyle-CssClass="pager" HeaderStyle-CssClass="header" RowStyle-CssClass="rows" AllowPaging="True" OnPageIndexChanging="gvEduDetails_PageIndexChanging">
                                    <Columns>
                                        <asp:CommandField DeleteImageUrl="Assets/images/icons8-delete-trash-24.png" ButtonType="Image" ShowDeleteButton="true" />
                                        <asp:CommandField SelectImageUrl="Assets/images/icons8-edit-24.png" ButtonType="Image" ShowSelectButton="true" />
                                    </Columns>
                                </asp:GridView>
                            </center>
                        </section>
                        <!--Section 4-->
                        <h2>
                            <span class="step-icon"><i class="zmdi zmdi-check"></i></span>
                            <span class="step-text">Confirm Details</span>
                        </h2>
                        <section>
                            <div class="inner">
                                <h3>Personal Details</h3>
                                <div class="form-row table-responsive">
                                    <table class="table">
                                        <tbody>
                                            <tr class="space-row">
                                                <th>Full Name:</th>
                                                <td id="fullname-val"></td>
                                            </tr>
                                            <tr class="space-row">
                                                <th>Gender:</th>
                                                <td id="gender-val"></td>
                                            </tr>
                                            <tr class="space-row">
                                                <th>Address Location:</th>
                                                <td id="address-val"></td>
                                            </tr>
                                            <tr class="space-row">
                                                <th>Phone Number:</th>
                                                <td id="phone-val"></td>
                                            </tr>
                                            <tr class="space-row">
                                                <th>Email Address:</th>
                                                <td id="email-val"></td>
                                            </tr>
                                            <tr class="space-row">
                                                <th>Zipcode:</th>
                                                <td id="code-val"></td>
                                            </tr>
                                            <tr class="space-row">
                                                <th>Date of Birth:</th>
                                                <td id="dob-val"></td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                                <h3>Employment Details</h3>
                                <div class="form-row table-responsive">
                                    <table class="table">
                                        <tbody>
                                            <tr class="space-row">
                                                <th>Designation:</th>
                                                <td id="designation-val"></td>
                                            </tr>
                                            <tr class="space-row">
                                                <th>Department:</th>
                                                <td id="department-val"></td>
                                            </tr>
                                            <tr class="space-row">
                                                <th>Location:</th>
                                                <td id="loc-val"></td>
                                            </tr>
                                            <tr class="space-row">
                                                <th>Reporting Manager:</th>
                                                <td id="manager-val"></td>
                                            </tr>
                                            <tr class="space-row">
                                                <th>Date of Joining:</th>
                                                <td id="doj-val"></td>
                                            </tr>
                                            <tr class="space-row">
                                                <th>Previous Employment:</th>
                                                <td id="prevemp-val"></td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                                <h3>Education Details</h3>
                                <center>
                                    <asp:GridView ID="gvConfirmDet" runat="server" CssClass="mydatagrid" PagerStyle-CssClass="pager" HeaderStyle-CssClass="header" RowStyle-CssClass="rows" AllowPaging="True">
                                    </asp:GridView>
                                    <div class="button">
                                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="myButton" OnClick="btnSubmit_Click" />
                                    </div>
                                </center>
                            </div>
                        </section>
                    </div>
                </form>
            </div>
        </div>
    </div>

    <script src="Assets/js/jquery-3.3.1.min.js"></script>
    <script src="Assets/js/jquery.steps.js"></script>
    <script src="Assets/js/main.js"></script>
</asp:Content>
