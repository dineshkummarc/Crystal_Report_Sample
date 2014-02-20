<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GroupReports.aspx.cs" Inherits="GroupReports" %>

<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table style="text-align:center;padding-top:50px;font-family:Verdana,tahoma,calibri;font-size:18px;font-weight:bold;" align="center">
    <tr style="height:35px;"><td><a href="MasterReports.aspx" >Back</a></td></tr>
    </table>
        <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" 
            AutoDataBind="true" />
    
    </div>
    </form>
</body>
</html>
