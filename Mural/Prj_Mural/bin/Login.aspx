<%@ Page Title="" Language="C#" MasterPageFile="~/SitePadrao.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Prj_mural.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server"> 
     <div class="form-group">
	    <label>
		    Email
		</label>
        <asp:TextBox ID="txtemail" TextMode="Email" Text="1170@cotemig.com.br" runat="server"></asp:TextBox>
	</div>   
    <div class="form-group">
	    <label>
		    Senha
		</label>
        <asp:TextBox ID="txtsenha" TextMode="Password" text="123" runat="server"></asp:TextBox>
	</div>      
     <div class="form-group">         
         <asp:Button ID="BtnLogar" CssClass="btn btn-primary" runat="server" Text="Logar" OnClick="BtnLogar_Click" />         
         <a href ="Index.aspx" class="btn btn-danger">Voltar</a>
	</div>     
</asp:Content>
