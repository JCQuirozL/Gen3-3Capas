<%@ Page Title="Listado de choferes" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListadoChoferes.aspx.cs" Inherits="Gen3_3Capas.Catalogos.Choferes.ListadoChoferes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-md-10 col-md-offset-1" style="scroll-margin-left: 40px;">
                <h3>Listado de Choferes
                </h3>
                <asp:GridView ID="GVChoferes" CssClass="table table-bordered table-striped table-condensed" runat="server" AutoGenerateColumns="false" OnRowDeleting="GVChoferes_RowDeleting" DataKeyNames="IdChofer" OnRowEditing="GVChoferes_RowEditing" OnRowUpdating="GVChoferes_RowUpdating" OnRowCancelingEdit="GVChoferes_RowCancelingEdit" OnRowCommand="GVChoferes_RowCommand">
                    <Columns>
                        <asp:ButtonField Text="Seleccionar" CommandName="Select" ButtonType="Button" ControlStyle-CssClass="btn btn-info btn-xs" ControlStyle-Width="80px" ControlStyle-Height="40px" >

<ControlStyle CssClass="btn btn-info btn-xs" Height="40px" Width="80px"></ControlStyle>
                        </asp:ButtonField>

                        <asp:CommandField ShowDeleteButton="true" ButtonType="Button" ControlStyle-CssClass="btn btn-danger btn-xs" ControlStyle-Width="80px" ControlStyle-Height="40px" >

<ControlStyle CssClass="btn btn-danger btn-xs" Height="40px" Width="80px"></ControlStyle>
                        </asp:CommandField>

                        <asp:CommandField ShowEditButton="true" ButtonType="Button" ControlStyle-CssClass="btn btn-warning btn-xs" ControlStyle-Width="80px" ControlStyle-Height="40px" >

<ControlStyle CssClass="btn btn-warning btn-xs" Height="40px" Width="80px"></ControlStyle>
                        </asp:CommandField>

                        <asp:ImageField HeaderText="Foto" ReadOnly="true" ItemStyle-Width="120px" ControlStyle-Width="120px" ControlStyle-Height="90px" DataImageUrlField="UrlFoto">
<ControlStyle Height="90px" Width="120px"></ControlStyle>

<ItemStyle Width="120px"></ItemStyle>
                        </asp:ImageField>

                        <asp:BoundField HeaderText="Chofer" ItemStyle-Width="150px" DataField="IdChofer" readonly="true">

<ItemStyle Width="150px"></ItemStyle>
                        </asp:BoundField>

                        <asp:BoundField HeaderText="Nombre" ItemStyle-Width="150px" DataField="Nombre" >

<ItemStyle Width="150px"></ItemStyle>
                        </asp:BoundField>

                        <asp:BoundField HeaderText="Apellido Paterno" ItemStyle-Width="250px" DataField="ApPaterno" >

<ItemStyle Width="250px"></ItemStyle>
                        </asp:BoundField>

                        <asp:BoundField HeaderText="Apellido Materno" ItemStyle-Width="250px" DataField="ApMaterno" >

<ItemStyle Width="250px"></ItemStyle>
                        </asp:BoundField>

                        <asp:BoundField HeaderText="Licencia" ItemStyle-Width="150px" DataField="Licencia" readonly="true">

<ItemStyle Width="150px"></ItemStyle>
                        </asp:BoundField>

                        <asp:TemplateField HeaderText="Disponible" ItemStyle-Width="50px">
                            <ItemTemplate>
                                <div style=""width:100%;">
                                    <div style="width:25%; margin: 0 auto;">
                                        <asp:CheckBox ID="ChkDisponible" runat="server" Checked='<%#Eval("Disponibilidad") %>' Enabled="false"/>

                                    </div>

                                </div>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <div style=""width:100%;">
                                   <div style="width:25%; margin: 0 auto;">
                                            <asp:CheckBox ID="ChkEditDisponible" runat="server" Checked='<%#Eval("Disponibilidad") %>' />
                                   </div>

                                </div>
                            </EditItemTemplate>

<ItemStyle Width="50px"></ItemStyle>
                        </asp:TemplateField>

                    </Columns>
                </asp:GridView>

            </div>

        </div>

    </div>
</asp:Content>
