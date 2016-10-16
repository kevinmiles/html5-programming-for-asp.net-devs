﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="DrawLine.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <script type="text/javascript" src="Script/jquery-1.7.2.min.js"></script>
    <script type="text/javascript" src="Script/modernizr-2.5.3.js"></script>
    <script type="text/javascript">
      $(document).ready(function () {
        if (!Modernizr.canvas) {
          alert("This browser doesn't support HTML5 Canvas!");
        }

        var canvas = $("#MyCanvas").get(0);
        var context = canvas.getContext("2d");

        context.lineWidth = 10;

        context.beginPath();
        context.moveTo(20, 100);
        context.lineTo(180, 100);
        context.lineCap = "butt";
        context.stroke();

        context.beginPath();
        context.moveTo(20, 120);
        context.lineTo(180, 120);
        context.lineCap = "round";
        context.stroke();

        context.beginPath();
        context.lineCap = "square";
        context.moveTo(20, 140);
        context.lineTo(180, 140);
        context.stroke();

      });
    </script>
    <style>
      canvas {
        border: 2px solid #808080;
      }
    </style>
</head>
<body>
    <form id="form1" runat="server">
      <canvas id="MyCanvas" height="200" width="200"></canvas>
    </form>
</body>
</html>
