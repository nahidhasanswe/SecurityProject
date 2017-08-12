<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Regestion.aspx.cs" Inherits="SecurityProject.Regestion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
 <head runat="server">
<meta charset="utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <title>Regstion From | Towru Khan</title>

    <!-- Bootstrap -->
    <link href="css/bootstrap.min.css" rel="stylesheet"/>

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
    <style type="text/css">
        body{
            background-size:cover;
        }
        .aa{
            width:500px;
            height:400px;
            background-color:rgba(0,0,0,0.5);
            margin:0 auto;
            margin-top:100px;
            padding-top:10px;
            padding-left:50px;
            border-right:15px;
            -webkit-border-radius:5px;
            -moz-border-radius:5px;
            color:white;
            font-weight:bolder;
        }


        .aa .txtcss{
           width:200px;
           height:30px;
           padding-left:5px;
           border:0px;
           border-radius:5px;
           -webkit-border-radius:5px;
           -moz-border-radius:5px;

        }

        .aa .btns{
           width:100px;
           height:35px;
           border:0px;
           border-radius:5px;
           -webkit-border-radius:5px;
           -moz-border-radius:5px;
           background-color:aquamarine;
           font-weight:bolder;

        }

    </style>
</head>
<body style="background-image:url('images/reg.jpg')">
    <form id="form1" runat="server">
    <div class="aa">
        <h2 style="text-align:center; text-decoration-color:black">Regstion</h2>
        <table align="center">
            <tr>
                <td>
                     <asp:Label ID="lblFName" runat="server" CssClass="txtcss" Text="First Name:"></asp:Label>
                </td>
                <td>
                <asp:TextBox ID="txtFname" runat="server" CssClass="txtcss" placeholder=""></asp:TextBox>
        
                </td>
            </tr>
       <tr>
                <td>
        
        <asp:Label ID="lblLName" runat="server" Text="Last Name:"></asp:Label>
                     </td>
                <td>
        <asp:TextBox ID="txtLName" runat="server" CssClass="txtcss" placeholder=""></asp:TextBox>

                    
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="lbtDoB" runat="server" Text="Date Of Birth:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDoB" runat="server"  CssClass="txtcss"></asp:TextBox>
                </td>
            </tr>


            <tr>
                <td>
                    <asp:Label ID="lblCountry" runat="server" Text="Country:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCountry" runat="server" CssClass="txtcss"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="lblState" runat="server" Text="State:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtState" runat="server" CssClass="txtcss"></asp:TextBox>
               </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="lblEmail" runat="server" Text="Email:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="txtcss"> </asp:TextBox>
                </td>

            </tr>

            <tr>
                <td>
                     <asp:Label ID="lblPhn" runat="server" Text="Phone No:"></asp:Label>
                </td>

                <td>
                    <asp:TextBox ID="txtPhn" runat="server" CssClass="txtcss"> </asp:TextBox>
                </td>
            </tr>

             <tr>
                <td>
                     <asp:Label ID="lblPass" runat="server" Text="Password:"></asp:Label>
                </td>

                <td>
                    <asp:TextBox ID="txtPass" runat="server" CssClass="txtcss" TextMode="Password" > </asp:TextBox>
                </td>
            </tr>


            <%-- <tr>
                <td>
                     <asp:Label ID="lblRePass" runat="server" Text="Retype Passsword:"></asp:Label>
                </td>

                <td>
                    <asp:TextBox ID="txtRePass" runat="server" CssClass="txtcss"> </asp:TextBox>
                </td>
            </tr>--%>
            <tr>
                <td>
                    <asp:CheckBox ID="CheckBox1" runat="server" Text="If You are Agree?" />
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Button ID="btnRegSub" runat="server" class="btns" align="center" Text="Registion" OnClick="btnRegSub_Click"/>
               
                </td>
            </tr>
         </table>
    </div>
    </form>

    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="js/bootstrap.min.js"></script>

</body>
</html>
