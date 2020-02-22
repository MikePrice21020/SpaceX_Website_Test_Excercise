<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RepeaterExample.aspx.cs" Inherits="Verto_Test._RepeaterExample" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div">  
    <table>  
    <tr>  
    <td>Enter Name:</td>  
    <td><asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>  
    </tr>  
      <tr>  
    <td>Enter Subject:</td>  
    <td><asp:TextBox ID="txtSubject" runat="server"></asp:TextBox></td>  
    </tr>  
      <tr>  
    <td valign="top">Enter Comments:</td>  
    <td><asp:TextBox ID="txtComment" runat="server" Rows="5" Columns="20" TextMode="MultiLine"></asp:TextBox></td>  
    </tr>  
      <tr>  
    <td></td>  
    <td><asp:Button ID="BtnSubmit" runat="server" Text="Summit" OnClick="BtnSubmit_click" /></td>  
    </tr>  
    </table>  
    </div>


    <asp:Repeater ID="VertoRepeater" runat="server">  
    <HeaderTemplate>  
    <table style="border:1px solid #0000FF; width:500px" cellpadding="0">  
    <tr style="background-color:#FF6600; color:#000000; font-size: large; font-weight: bold;">  
    <td colspan="2">  
    <b>Comments</b>  
    </td>  
    </tr>  
    </HeaderTemplate>  
    <ItemTemplate>  
    <tr style="background-color:#EBEFF0">  
    <td>  
    <table style="background-color:#EBEFF0;border-top:1px dotted #df5015; width:500px" >  
    <tr>  
    <td >  
    Subject:  
    <asp:Label ID="lblSubject" runat="server" Text='<%#Eval("Subject") %>' Font-Bold="true"/>  
    </td>  
    </tr>  
    </table>  
    </td>  
    </tr>  
    <tr>  
    <td>  
    <asp:Label ID="lblComment" runat="server" Text='<%#Eval("CommentOn") %>'/>  
    </td>  
    </tr>  
    <tr>  
    <td>  
    <table style="background-color:#EBEFF0;border-top:1px dotted #df5015;border-bottom:1px solid #df5015; width:500px" >  
    <tr>  
    <td >Post By: <asp:Label ID="lblUser" runat="server" Font-Bold="true" Text='<%#Eval("UserName") %>'/></td>  
    <td >Created Date:<asp:Label ID="lblDate" runat="server" Font-Bold="true" Text='<%#Eval("Post_Date") %>'/></td>  
    </tr>  
    </table>  
    </td>  
    </tr>  
    <tr>  
    <td colspan="2"> </td>  
    </tr>  
    </ItemTemplate>  
    <FooterTemplate>  
    </table>  
    </FooterTemplate>  
    </asp:Repeater>  

</asp:Content>

