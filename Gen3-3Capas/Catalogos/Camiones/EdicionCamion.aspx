<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EdicionCamion.aspx.cs" Inherits="Gen3_3Capas.Catalogos.Camiones.EdicionCamion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <h3>Edición de camión 
                    <asp:Label ID="idCamion" runat="server"></asp:Label>
                </h3>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <div class="form-group">
                    <label for="<%=txtMatricula.ClientID %>">Matrícula</label>

                    <asp:TextBox ID="txtMatricula" runat="server" CssClass="form-control" placeholder="XXX-0000" MaxLength="8"></asp:TextBox>

                    <div class="col-md-12" style="margin-bottom: 30px;">
                        <div style="position: absolute; top: 0; left: 0;">
                            <asp:RequiredFieldValidator ControlToValidate="txtMatricula" ID="RFV1" runat="server" CssClass="text-danger" ErrorMessage=";Matricula es obligatoria">

                            </asp:RequiredFieldValidator>
                        </div>

                        <div style="position: absolute; top: 0; left: 0;">
                            <asp:RegularExpressionValidator runat="server" ErrorMessage="El formato de matrícula es XXX-0000" ControlToValidate="txtMatricula" ValidationExpression="^[a-zA-Z]{3}-[0-9]{4}$"></asp:RegularExpressionValidator>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <div class="checkbox" style="margin: 30px;">
                        <label>
                            <asp:CheckBox ID="chkDisponibilidad" runat="server" />Disponibilidad
                        </label>
                    </div>
                </div>
                <div class="form-group">
                    <label for="<%=subeImagen.ClientID%>">Seleccionar foto</label>
                    <div class="row">
                        <div class="col-md-3">
                            <input type="file" id="subeImagen" class="btn btn-file" runat="server" />
                        </div>
                        <div class="col-md-9">
                            <asp:Button ID="btnSubeImagen" CssClass="btn btn-primary" runat="server" Text="Subir" OnClick="btnSubeImagen_Click" />
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <label>Foto</label>
                    <asp:Image ID="imgFotoCamion" Width="150" Height="100" runat="server" />
                    <label id="urlFoto" runat="server"></label>
                </div>

                <div class="col-md-12">
                    <div class="form-group">
                        <asp:Button ID="btnGuardar" CssClass="btn btn-primary" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
                    </div>

                </div>
                <div class="col-md-12">
                    <div class="form-group">
                        <asp:Button ID="btnCancelar" CssClass="btn btn-danger" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
