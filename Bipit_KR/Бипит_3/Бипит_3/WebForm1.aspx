<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Бипит_3.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <asp:GridView ID="GridView2" runat="server">
    </asp:GridView>
    </p>
<p style="height: 33px; width: 881px">
        Поставщик:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox1" Display="dynamic" ErrorMessage="Поле должно быть заполнено!!!" ValidationGroup="Growp1">Поле должно быть заполнено!!!</asp:RequiredFieldValidator>
</p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Добавить" ValidationGroup="Growp1" />
</p>
<p>
    &nbsp;</p>
</asp:Content>
