<%@ Page Title="" Language="C#" MasterPageFile="~/SitePadrao.Master" AutoEventWireup="true" CodeBehind="Disciplinas.aspx.cs" Inherits="Prj_mural.Disciplinas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Crud Disciplinas</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server">
    <div class="row">
        <div class="form-group">
	        <label>
		        Disciplina
		    </label>
            <asp:TextBox ID="txtdisciplina" runat="server"></asp:TextBox>
	    </div>
         <div class="form-group">         
             <asp:Button ID="BtnCadastrar" CssClass="btn btn-primary" runat="server" Text="Salvar" OnClick="BtnCadastrar_Click" />                         
	    </div>     
    </div>
    <div class="row">
        <asp:GridView ID="GridView1" runat="server" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
            <Columns>
                <asp:CommandField ShowEditButton="True"></asp:CommandField>
                <asp:CommandField ShowDeleteButton="True"></asp:CommandField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
