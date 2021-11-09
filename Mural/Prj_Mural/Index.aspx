<%@ Page Title="" Language="C#" MasterPageFile="~/SitePadrao.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Prj_mural.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">  
    <title>Mural</title>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server">
    <a href="NovoRecado.aspx">Novo Recado</a>
    <a href="NovoAluno.aspx">Novo Aluno</a>
    <a href="logout.aspx">Sair</a>
    <asp:GridView ID="GridView1" runat="server">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <a href='recado.aspx?id=<%# Eval("idRecado") %>'>Visualizar</a>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>        
    </asp:GridView>
</asp:Content>
