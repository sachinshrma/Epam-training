<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationForm.aspx.cs" Inherits="StudentRegisterationWebApp.RegisterationForm" ClientIDMode="Static" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration</title>
    <style>
        .inForm {
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

        .custom-checkbox {
            margin-left: 15px;
        }
    </style>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous" />
    <script src="//cdnjs.cloudflare.com/ajax/libs/moment.js/2.4.0/moment.min.js"></script>
    <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>
</head>
<body>


    <form id="form1" class="container align-middle" runat="server">
        <!-- Modal -->
        <div class="modal fade" id="exampleModal" tabindex="1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="exampleModalLabel">Congratulations</h5>
                    </div>
                    <div class="modal-body">
                        <p>Account created successfully!!</p>
                    </div>
                    <div class="modal-footer">
                        <asp:Button ID="Btn_Close" CssClass="btn btn-secondary" runat="server" data-dismiss="modal" Text="Close" OnClick="Btn_Reset_Click" UseSubmitBehavior="False" />
                    </div>
                </div>
            </div>
        </div>
        <div class="inForm">
            <div class="card">
                <div class="card-body" style="padding: 0px;">
                    <h5 class="card-header bg-dark text-light">Registration</h5>
                    <div class="card-text">
                        <div class="row justify-content-center" style="margin-top: 30px;">
                            <div class="col-sm-2">
                                <asp:Label ID="Lbl_FirstName" CssClass="font-weight-bold" runat="server" Text="First Name"></asp:Label>
                            </div>
                            <div class="col-sm-4">
                                <asp:TextBox ID="Tb_FirstName" runat="server" required="true"></asp:TextBox>
                            </div>
                        </div>

                        <div class="row justify-content-center">
                            <div class="col-sm-2">
                                <asp:Label ID="Lbl_LastName" CssClass="font-weight-bold" runat="server" Text="Last Name"></asp:Label>
                            </div>
                            <div class="col-sm-4">
                                <asp:TextBox ID="Tb_LastName" runat="server" required="true"></asp:TextBox>
                            </div>
                        </div>

                        <div class="row justify-content-center">
                            <div class="col-sm-2">
                                <asp:Label ID="Lbl_Email" CssClass="font-weight-bold" runat="server" Text="Email address"></asp:Label>
                            </div>
                            <div class="col-sm-4">
                                <asp:TextBox ID="Tb_Email" runat="server" TextMode="Email" required="true"></asp:TextBox><br />
                            </div>
                        </div>

                        <div class="row justify-content-center">
                            <div class="col-sm-2">
                                <asp:Label ID="Lbl_Contact" CssClass="font-weight-bold" runat="server" Text="Contact Number"></asp:Label>
                            </div>
                            <div class="col-sm-4">
                                <asp:TextBox ID="Tb_Contact" runat="server" TextMode="Number" required="true"></asp:TextBox>
                            </div>
                        </div>

                        <div class="row justify-content-center">
                            <div class="col-sm-2">
                                <asp:Label ID="Lbl_DOB" CssClass="font-weight-bold" runat="server" Text="Date of Birth"></asp:Label>
                            </div>
                            <div class="col-sm-4">
                                <asp:TextBox ID="Tb_DOB" runat="server" TextMode="Date" required="true"></asp:TextBox>
                            </div>
                        </div>

                        <div class="row justify-content-center">
                            <div class="col-sm-2">
                                <asp:Label ID="Lbl_Gender" CssClass="font-weight-bold" Text="Gender" runat="server"></asp:Label>
                            </div>
                            <div class="col-sm-4">
                                <asp:RadioButton ID="Cb_Male" GroupName="gender" runat="server" Text="Male" CssClass="custom-checkbox"></asp:RadioButton>
                                <asp:RadioButton ID="Cb_Female" GroupName="gender" runat="server" Text="Female" CssClass="custom-checkbox"></asp:RadioButton>
                            </div>
                        </div>

                        <div class="row justify-content-center">
                            <div class="col-sm-2">
                                <asp:Label ID="Lbl_Streams" CssClass="font-weight-bold" Text="Stream" runat="server"></asp:Label>
                            </div>
                            <div class="col-sm-4">
                                <asp:CheckBox ID="Cb_Java" Text="Java" runat="server" CssClass="custom-checkbox" />
                                <asp:CheckBox ID="Cb_DotNet" Text="Dot Net" runat="server" CssClass="custom-checkbox" />
                                <asp:CheckBox ID="Cb_SDET" Text="SDET" runat="server" CssClass="custom-checkbox" />
                                <asp:CheckBox ID="Cb_DEP" Text="DEP" runat="server" CssClass="custom-checkbox" />
                                <asp:CheckBox ID="Cb_DevOps" Text="DevOps" runat="server" CssClass="custom-checkbox" />
                            </div>
                        </div>

                        <div class="row justify-content-center">
                            <div class="col-sm-2">
                                <asp:Label ID="Lbl_country" CssClass="font-weight-bold" Text="Country" runat="server"></asp:Label>
                            </div>
                            <div class="col-sm-4">
                                <asp:DropDownList ID="Ddl_Country" runat="server" AutoPostBack="True" OnSelectedIndexChanged="Ddl_Country_SelectedIndexChanged"></asp:DropDownList>
                            </div>
                        </div>

                        <div class="row justify-content-center">
                            <div class="col-sm-2">
                                <asp:Label ID="Lbl_State" CssClass="font-weight-bold" Text="State" runat="server"></asp:Label>
                            </div>
                            <div class="col-sm-4">
                                <asp:DropDownList ID="Ddl_State" runat="server" AutoPostBack="True" OnSelectedIndexChanged="Ddl_State_SelectedIndexChanged"></asp:DropDownList>
                            </div>
                        </div>

                        <div class="row justify-content-center" style="margin-bottom: 30px;">
                            <div class="col-sm-2">
                                <asp:Label ID="Lbl_City" CssClass="font-weight-bold" Text="City" runat="server"></asp:Label>
                            </div>
                            <div class="col-sm-4">
                                <asp:DropDownList ID="Ddl_City" runat="server" AutoPostBack="True" OnSelectedIndexChanged="Ddl_City_SelectedIndexChanged"></asp:DropDownList>
                            </div>
                        </div>

                    </div>
                    <div class="card-footer">
                        <div class="row justify-content-md-center">
                            <div class="col-sm-auto">
                                <input class="btn btn-success btn-lg" type="submit" id="submitBtn" />
                            </div>
                            <div class="col-sm-auto">
                                <asp:Button ID="Btn_Reset" CssClass="btn btn-secondary btn-lg" runat="server" Text="Reset" OnClick="Btn_Reset_Click" UseSubmitBehavior="False" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>

</body>
<script type="text/javascript" src="Scripts/js/RegistrationForm.js"></script>
</html>
