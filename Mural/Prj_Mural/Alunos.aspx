<%@ Page Title="" Language="C#" MasterPageFile="~/SitePadrao.Master" AutoEventWireup="true" CodeBehind="Alunos.aspx.cs" Inherits="Prj_mural.alunos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">  
    <title>Crud Alunos</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server">
    <div class="form-group">         
             <a href="NovoAluno.aspx" class="btn btn-primary">Novo aluno</a>  
	</div>  
    <asp:GridView ID="GridView1" runat="server">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <a href='Aluno.aspx?id=<%# Eval("idAluno") %>'>Detalhes</a>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>        
    </asp:GridView>
</asp:Content>
