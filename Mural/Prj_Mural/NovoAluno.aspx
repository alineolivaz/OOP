<%@ Page Title="" Language="C#" MasterPageFile="~/SitePadrao.Master" AutoEventWireup="true" CodeBehind="NovoAluno.aspx.cs" Inherits="Prj_mural.NovoAluno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server">
     <div class="form-group">
	    <label>
		    Nome
		</label>
        <asp:TextBox ID="txtnome" runat="server"></asp:TextBox>
	</div>    
     <div class="form-group">
	    <label>
		    Email
		</label>
        <asp:TextBox ID="txtemail" TextMode="Email" runat="server"></asp:TextBox>
	</div>   
    <div class="form-group">
	    <label>
		    Senha
		</label>
        <asp:TextBox ID="txtsenha" TextMode="Password" runat="server"></asp:TextBox>
	</div>  
    <div class="form-group">        
	    <label>
		    Turma
		</label>
        <asp:DropDownList ID="ddlTurma" runat="server"></asp:DropDownList>
	</div>  
     <div class="form-group">         
         <asp:Button ID="BtnCadastrar" CssClass="btn btn-primary" runat="server" Text="Cadastrar" OnClick="BtnEditar_Click" />         
         <a href ="Alunos.aspx" class="btn btn-danger">Voltar</a>
	</div> 
</asp:Content>
