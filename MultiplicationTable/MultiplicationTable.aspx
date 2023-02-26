<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MultiplicationTable.aspx.cs" Inherits="MultiplicationTable._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">Multiplication Table</h1>
        </section>

        <div class="row" style="float:left">
             <section class="col-md-4" aria-labelledby="gettingStartedTitle">
                 <asp:Label ID="Label1" runat="server" Text="Size: "></asp:Label>
                 <asp:DropDownList ID="TableSizeList" runat="server"
                      AutoPostBack="True"
                      OnSelectedIndexChanged="Size_Selection_Change">
                        <asp:ListItem Value="3"> 3</asp:ListItem>
                        <asp:ListItem Value="4"> 4 </asp:ListItem>
                        <asp:ListItem Value="5"> 5 </asp:ListItem>
                        <asp:ListItem Value="6"> 6 </asp:ListItem>
                        <asp:ListItem Value="7"> 7 </asp:ListItem>
                        <asp:ListItem Value="8"> 8 </asp:ListItem>
                        <asp:ListItem Value="9"> 9 </asp:ListItem>
                        <asp:ListItem Value="10"> 10 </asp:ListItem>
                        <asp:ListItem Value="11"> 11 </asp:ListItem>
                        <asp:ListItem Value="12"> 12 </asp:ListItem>
                        <asp:ListItem Value="13"> 13 </asp:ListItem>
                        <asp:ListItem Value="14"> 14 </asp:ListItem>
                        <asp:ListItem Value="15"> 15 </asp:ListItem>
                 </asp:DropDownList>
              </section>
              <section class="col-md-4" aria-labelledby="gettingStartedTitle">
                 <asp:Label ID="Label2" runat="server" Text="Format: "></asp:Label>
                 <asp:DropDownList ID="FormatList" runat="server"
                      AutoPostBack="True"
                      OnSelectedIndexChanged="Format_Selection_Change">
                      <asp:ListItem Selected="True" Value="1"> Int</asp:ListItem>
                     <asp:ListItem  Value="2"> Decimal</asp:ListItem>
                      <asp:ListItem Value="3"> Binary </asp:ListItem>
                      <asp:ListItem Value="4"> Hex </asp:ListItem>
                 </asp:DropDownList>
              </section>
        </div>
        <div class="row">
             <section class="col-md-4" aria-labelledby="gettingStartedTitle">
               <asp:Table ID="MultiplicationTbl" runat="server" BorderStyle="Solid" CellPadding="5" CellSpacing="5" BorderWidth="2" BorderColor="#3399FF" BackColor="White" ></asp:Table>
              </section>
        </div>
    </main>
</asp:Content>

