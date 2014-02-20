<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MasterReports.aspx.cs" Inherits="MasterReports" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <meta http-equiv="Page-Exit" content="progid:DXImageTransform.Microsoft.Fade(duration=.5)" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table style="text-align:center;padding-top:50px;font-family:Verdana,tahoma,calibri;font-size:12px;" align="center">
    <tr style="height:35px;"><td><a href="simplecrystal.aspx" >Simple Report</a></td></tr>
    <tr style="height:35px;"><td><a href="groupreports.aspx" >Group Report</a></td></tr>
    <tr style="height:35px;"><td><a href="Graph.aspx" >Graph Report</a></td></tr>
    <tr style="height:35px;"><td><a href="crosstabreport.aspx" >Cross Tab Report</a></td></tr>
    <tr style="height:35px;"><td><a href="SubReport.aspx" >Group Sub Report</a></td></tr>
    </table>
    </div>
    </form>
</body>
</html>
