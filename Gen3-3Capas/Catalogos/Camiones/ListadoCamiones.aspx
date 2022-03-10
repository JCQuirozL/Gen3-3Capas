<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListadoCamiones.aspx.cs" Inherits="Gen3_3Capas.Catalogos.Camiones.ListadoCamiones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-md-10 col-md-offset-1">
                <h3>Listado de camiones</h3>
                acá pintar el grid
                <asp:GridView ID="GVCamiones" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered table-striped table-condensed" DataKeyNames="Id" OnRowCancelingEdit="GVCamiones_RowCancelingEdit" OnRowCommand="GVCamiones_RowCommand" OnRowDeleting="GVCamiones_RowDeleting" OnRowEditing="GVCamiones_RowEditing" OnRowUpdating="GVCamiones_RowUpdating" OnRowDataBound="GVCamiones_RowDataBound">
                    <Columns>
                        <asp:ButtonField ButtonType="Button" CommandName="Select" Text="Seleccionar">
                            <ControlStyle CssClass="btn btn-success btn-xs" />
                            <ItemStyle Width="70px" />
                        </asp:ButtonField>
                        <asp:CommandField ButtonType="Button" ShowDeleteButton="True">
                            <ControlStyle CssClass="btn btn-danger btn-xs" />
                            <ItemStyle Width="70px" />
                        </asp:CommandField>
                        <asp:CommandField ButtonType="Button" ShowEditButton="True">
                            <ControlStyle CssClass="btn btn-primary bn-xs" />
                            <ItemStyle Width="70px" />
                        </asp:CommandField>
                        <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True">
                            <ItemStyle Width="50px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Matricula" HeaderText="Matrícula" ReadOnly="True">
                            <ItemStyle Width="150px" />
                        </asp:BoundField>
                        <asp:TemplateField HeaderText="Tipo Camión">
                            <ItemStyle Width="150px" />
                            <ItemTemplate>
                                <asp:Label ID="lblTipoCamion" runat="server" Text='<%#Eval("TipoCamion") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:DropDownList ID="DDLTipoCamion" CssClass="form-control" runat="server"></asp:DropDownList>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Modelo">
                            <ItemStyle Width="100px" />
                            <ItemTemplate>
                                <asp:Label ID="lblModelo" runat="server" Text='<%#Eval("Modelo") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:DropDownList ID="DDLModelo" CssClass="form-control" runat="server"></asp:DropDownList>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Marca">
                            <ItemStyle Width="150px" />
                             <ItemTemplate>
                                <asp:Label ID="lblMarca" runat="server" Text='<%#Eval("Marca") %>'></asp:Label>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:DropDownList ID="DDLMarca" CssClass="form-control" runat="server"></asp:DropDownList>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="Capacidad" HeaderText="Capacidad">
                            <ItemStyle Width="100px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Kilometraje" HeaderText="Km">
                            <ItemStyle Width="100px" />
                        </asp:BoundField>
                        <asp:CheckBoxField DataField="Disponibilidad" Text="Disponible">
                            <ItemStyle Width="70px" />
                        </asp:CheckBoxField>
                        <asp:ImageField DataImageUrlField="UrlFoto" HeaderText="Foto" ReadOnly="True">
                            <ControlStyle Height="90px" Width="120px" />
                            <ItemStyle Width="120px" />
                        </asp:ImageField>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
