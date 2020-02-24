<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gridView.aspx.cs" Inherits="week3.gridView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:GridView runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Font-Names="Arial">
                 <Columns>
                  
                     <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                     <asp:BoundField DataField="ShortDescription" HeaderText="Description" SortExpression="ShortDescription" />
                 
                     <asp:BoundField DataField="ImageFile" HeaderText="Image" SortExpression="ImageFile" />
                     <asp:BoundField DataField="UnitPrice" HeaderText="Price" SortExpression="UnitPrice" />
                     <asp:BoundField DataField="OnHand" HeaderText="Avaliable" SortExpression="OnHand" />
                 </Columns>
                 <FooterStyle BackColor="White" ForeColor="#000066" />
                 <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                 <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                 <RowStyle ForeColor="#000066" />
                 <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                 <SortedAscendingCellStyle BackColor="#F1F1F1" />
                 <SortedAscendingHeaderStyle BackColor="#007DBB" />
                 <SortedDescendingCellStyle BackColor="#CAC9C9" />
                 <SortedDescendingHeaderStyle BackColor="#00547E" />
             </asp:GridView>
             <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [Products]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
