<%@ Page Title="" Language="C#" MasterPageFile="~/SitePadrao.Master" AutoEventWireup="true" CodeBehind="Recado.aspx.cs" Inherits="Prj_mural.recado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Detalhe</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server">
    <div class="form-group">
	    <label>
		    Recado
		</label>
        <asp:TextBox ID="txtRecado" runat="server"></asp:TextBox>
	</div>    
     <div class="form-group">
	    <label>
		    Aluno
		</label>
        <asp:TextBox ID="txtAluno" runat="server"></asp:TextBox>
	</div>    
    <div class="form-group">
	    <label>
		    Disciplinas
		</label>
        <asp:ListBox ID="listDisciplinas" runat="server"></asp:ListBox>
	</div> 
</asp:Content>
