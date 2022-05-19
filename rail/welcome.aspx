<%@ Page Language="C#" AutoEventWireup="true" CodeFile="welcome.aspx.cs" Inherits="welcome" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style3
        {
            width: 127%;
            height: 92px;
            margin-bottom: 0px;
        }
        .style4
        {
            width: 281px;
        }
        .style5
        {
            width: 724px;
        }
    </style>
</head>
<body background="color_light_blue_154.gif">
    <form id="form1" runat="server">
    <div style="height: 232px; width: 981px;">
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Image ID="Image4" runat="server" Height="331px" 
            ImageUrl="~/New-Delhi-Railway-Station_lightboxA_918x612_Ministry-of-Railways.ashx.jpg" 
            Width="685px" style="margin-left: 174px" />
    
        <table class="style3">
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td class="style5">
                    <asp:Image ID="Image5" runat="server" Height="36px" 
                        ImageUrl="~/cooltext920386535.png" Width="418px" />
                    <asp:Image ID="Image6" runat="server" Height="30px" 
                        ImageUrl="~/cooltext920387049.png" Width="113px" />
                </td>
                <td class="style4">
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td class="style5">
                    <marquee direction"left" style="width: 846px"><asp:Image ID="Image3" runat="server" Height="60px" 
                        ImageUrl="~/cooltext920387424.png" Width="891px" /></marquee>
                </td>
                <td class="style4">
                    <br />
                    <br />
                </td>
                <td class="style4">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td class="style5">
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <br />
                            <asp:ScriptManager ID="ScriptManager1" runat="server">
                            </asp:ScriptManager>
                            <asp:Timer ID="Timer1" runat="server" Interval="150" ontick="Timer1_Tick">
                            </asp:Timer>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
                <td class="style4">
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
