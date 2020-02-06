<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterationForm.aspx.cs" Inherits="StudentRegisterationWebApp.RegisterationForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration</title>
    <style>
        #form1 {
            position: absolute;
            left: 50%;
            top: 40%;
            transform: translate(-40%, -50%);
        }

        .card {
            width: 60rem;
        }

        .row {
            margin-bottom: 15px;
        }
        .custom-checkbox{
            margin-left:15px;
        }
    </style>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous" />
</head>
<body>
    <form id="form1" class="container align-middle" runat="server">
        <div class="card">
            <div class="card-body" style="padding: 0px;">
                <h5 class="card-header bg-dark text-light">Registration</h5>
                <div class="card-text">
                    <div class="row justify-content-center" style="margin-top:30px;">
                        <div class="col-sm-2">
                            <asp:Label ID="Lbl_FirstName" CssClass="font-weight-bold" runat="server" Text="First Name"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:TextBox ID="Tb_FirstName" runat="server" required="true" ></asp:TextBox>
                        </div>
                    </div>

                    <div class="row justify-content-center">
                        <div class="col-sm-2">
                            <asp:Label ID="Lbl_LastName"  CssClass="font-weight-bold" runat="server" Text="Last Name" ></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:TextBox ID="Tb_LastName" runat="server" required="true"></asp:TextBox>
                        </div>
                    </div>

                    <div class="row justify-content-center">
                        <div class="col-sm-2">
                            <asp:Label ID="Lbl_Email"  CssClass="font-weight-bold" runat="server" Text="Email address"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:TextBox ID="Tb_Email" runat="server" TextMode="Email" required="true"></asp:TextBox><br />
                        </div>
                    </div>

                    <div class="row justify-content-center">
                        <div class="col-sm-2">
                            <asp:Label ID="Lbl_Contact"  CssClass="font-weight-bold" runat="server" Text="Contact Number"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:TextBox ID="Tb_Contact" runat="server" TextMode="Number" required="true"></asp:TextBox>
                        </div>
                    </div>

                    <div class="row justify-content-center">
                        <div class="col-sm-2">
                            <asp:Label ID="Lbl_DOB"  CssClass="font-weight-bold" runat="server" Text="Date of Birth"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:TextBox ID="Tb_DOB" runat="server" TextMode="Date" required="true"></asp:TextBox>
                        </div>
                    </div>

                    <div class="row justify-content-center">
                        <div class="col-sm-2">
                            <asp:Label ID="Lbl_Gender"  CssClass="font-weight-bold" Text="Gender" runat="server"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:RadioButton GroupName="gender" runat="server" Text="Male" CssClass="custom-checkbox" ></asp:RadioButton>
                            <asp:RadioButton GroupName="gender" runat="server" Text="Female" CssClass="custom-checkbox" ></asp:RadioButton>
                        </div>
                    </div>

                    <div class="row justify-content-center">
                        <div class="col-sm-2">
                            <asp:Label ID="Lbl_Streams"  CssClass="font-weight-bold" Text="Stream" runat="server"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:CheckBox ID="Cb_Java" Text="Java" runat="server" CssClass="custom-checkbox" />
                            <asp:CheckBox ID="Cb_DotNet" Text="Dot Net" runat="server"  CssClass="custom-checkbox" />
                            <asp:CheckBox ID="Cb_SDET" Text="SDET" runat="server"  CssClass="custom-checkbox" />
                            <asp:CheckBox ID="Cb_DEP" Text="DEP" runat="server"  CssClass="custom-checkbox" />
                            <asp:CheckBox ID="Cb_DevOps" Text="DevOps" runat="server"  CssClass="custom-checkbox" />
                        </div>
                    </div>

                    <div class="row justify-content-center">
                        <div class="col-sm-2">
                            <asp:Label ID="Lbl_country"  CssClass="font-weight-bold" Text="Country" runat="server"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:DropDownList ID="Ddl_Country" runat="server" AutoPostBack="True" OnSelectedIndexChanged="Ddl_Country_SelectedIndexChanged"></asp:DropDownList>
                        </div>
                    </div>

                    <div class="row justify-content-center">
                        <div class="col-sm-2">
                            <asp:Label ID="Lbl_State"  CssClass="font-weight-bold" Text="State" runat="server"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:DropDownList ID="Ddl_State" runat="server" AutoPostBack="True" OnSelectedIndexChanged="Ddl_State_SelectedIndexChanged"></asp:DropDownList>
                        </div>
                    </div>

                    <div class="row justify-content-center"  style="margin-bottom:30px;">
                        <div class="col-sm-2">
                            <asp:Label ID="Lbl_City"  CssClass="font-weight-bold" Text="City" runat="server"></asp:Label>
                        </div>
                        <div class="col-sm-4">
                            <asp:DropDownList ID="Ddl_City" runat="server" AutoPostBack="True" OnSelectedIndexChanged="Ddl_City_SelectedIndexChanged"></asp:DropDownList>
                        </div>
                    </div>

                </div>
                <div class="card-footer">
                    <div class="row justify-content-md-center">
                        <div class="col-sm-auto">
                            <input class="btn btn-success btn-lg" type="submit" />
                        </div>
                        <div class="col-sm-auto">
                            <input class="btn btn-secondary btn-lg" type="reset" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
