<%@ Page Title="" Language="C#" MasterPageFile="~/SitePadrao.Master" AutoEventWireup="true" CodeBehind="Aluno.aspx.cs" Inherits="Prj_mural.Aluno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Detalhe Aluno</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server">
    <div class="form-group">
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
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
         <asp:Button ID="BtnEditar" CssClass="btn btn-primary" runat="server" Text="Editar" OnClick="BtnEditar_Click" />
         <asp:Button ID="BtnExcluir" CssClass="btn btn-danger" runat="server" Text="Excluir" OnClick="BtnExcluir_Click" />
         <a href ="Alunos.aspx" class="btn btn-danger">Voltar</a>
	</div>     
</asp:Content>
