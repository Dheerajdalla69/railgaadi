<%@ Page Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="Default6.aspx.cs" Inherits="Default6" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    <br />
    Enter Pnr Number&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="OK" />
</p>
<p>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="train_name" HeaderText="train_name" 
                SortExpression="train_name" />
            <asp:BoundField DataField="train_no" HeaderText="train_no" 
                SortExpression="train_no" />
            <asp:BoundField DataField="source" HeaderText="source" 
                SortExpression="source" />
            <asp:BoundField DataField="destination" HeaderText="destination" 
                SortExpression="destination" />
            <asp:BoundField DataField="boarding" HeaderText="boarding" 
                SortExpression="boarding" />
            <asp:BoundField DataField="receivingupto" HeaderText="receivingupto" 
                SortExpression="receivingupto" />
            <asp:BoundField DataField="pnr" HeaderText="pnr" SortExpression="pnr" />
            <asp:BoundField DataField="ticket_no" HeaderText="ticket_no" 
                SortExpression="ticket_no" />
            <asp:BoundField DataField="class" HeaderText="class" SortExpression="class" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True;User Instance=True" 
        ProviderName="System.Data.SqlClient" 
        SelectCommand="SELECT * FROM [reservation] WHERE ([pnr] LIKE '%' + @pnr + '%')">
        <SelectParameters>
            <asp:ControlParameter ControlID="TextBox1" Name="pnr" PropertyName="Text" 
                Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
</p>
</asp:Content>

