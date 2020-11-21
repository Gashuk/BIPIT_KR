<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Бипит_3.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
        a:visited
        {
            /*color: darkblue;
            text-decoration: none;*/
        }
        A 
        {
             color: black;
             text-decoration: none; /* Убирает подчеркивание для ссылок */
             font-size: 20pt;
        } 
        A:hover 
        { 
            text-decoration: underline; /* Добавляем подчеркивание при наведении курсора на ссылку */
            color: deepskyblue; /* Ссылка красного цвета */
        }
        div
        {
            padding:10pt;
        }
    </style>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin:auto; width: 300px; height: 100px; background-color:  #cce9bb; text-align: center;">
            <a href="WebForm1.aspx">Открыть проект</a>
        </div>
    </form>
</body>
</html>
