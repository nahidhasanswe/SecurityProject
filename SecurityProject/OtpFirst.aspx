<%@ Page Language="C#" Async="true"  AutoEventWireup="true" CodeBehind="OtpFirst.aspx.cs" Inherits="SecurityProject.OtpFirst" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        body{
            background-size:cover;
        }

        .aa{
            width:400px;
            height:300px;
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
<body style="background-image:url('images/secur.jpg')">
    <form id="form1" runat="server">
    <div class="aa">
        <h2 style="text-align:left; text-decoration-color:black">Create One Time Password</h2>
    <tr>
            <td>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Text="5" Value="5" />
                <asp:ListItem Text="8" Value="8" />
                <asp:ListItem Text="10" Value="10" />

            </asp:DropDownList>
                </td>
            <td>
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">

                    <asp:ListItem Text="Alphanumaric"  Value="1" Selected="True"/>
                    <asp:ListItem Text="Numaric"  Value="2" Selected="True"/>


                </asp:RadioButtonList>
            </td>
             <td>
                 <asp:Button ID="btngenerate" runat="server" Text="Generate OTP" class="btns" OnClick="GenerateOtp"/>


             </td>
        </tr>

        <tr>
            <td>
                &nbsp;
            </td>
            <td>
                OTP:
         <asp:Label ID="Label1" runat="server"></asp:Label>
            </td>
        </tr>
    
    </div>
    </form>
</body>
</html>
