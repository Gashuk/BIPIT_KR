<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Бипит_3.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <p style="height: 38px; width: 881px">
        Код поставщика:
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
    </p>
    <p style="height: 38px; width: 881px">
        Сумма:
        <asp:TextBox ID="dateEx" runat="server" type="number" min="0" value ="0"/>
    </p>
    <p style="height: 38px; width: 881px">
        Дата:
        <asp:TextBox ID="dateEx0" runat="server" type="date" />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="dateEx0" Display="dynamic" ErrorMessage="Вы не выбрали дату!" ValidationGroup="Growp1">Вы не выбрали дату!
            </asp:RequiredFieldValidator>
    </p>
    <p style="height: 38px; width: 881px">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Добавить" ValidationGroup="Growp1" />
    </p>
    <p style="height: 38px; width: 881px">
        &nbsp;</p>
    <p style="height: 38px; width: 881px">
        &nbsp;</p>
    <p style="height: 38px; width: 881px">
        &nbsp;</p>
</asp:Content>
