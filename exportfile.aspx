﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="exportfile.aspx.cs" Inherits="exportfile" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
  <title>Java Friends</title>
</head>
<body>
  <table style="font-weight: bold">
    <tr style="background-color:red"><td>a</td><td>b</td></tr>
    <tr><td>1</td><td>2</td></tr>
    <tr>
      <td colspan="2">
        <button onclick="window.open('data:application/vnd.ms-excel,'+document.documentElement.innerHTML);">
            Get as Excel spreadsheet
        </button>
      </td>
    </tr>
  </table>    
</body>
</html>
