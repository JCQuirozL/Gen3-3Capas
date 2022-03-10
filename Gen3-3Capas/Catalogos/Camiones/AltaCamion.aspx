<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AltaCamion.aspx.cs" Inherits="Gen3_3Capas.Catalogos.Camiones.AltaCamion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <h3>Alta de camión</h3>
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
                    <label for="<%=txtCapacidad.ClientID %>">Capacidad</label>

                    <asp:TextBox ID="txtCapacidad" runat="server" CssClass="form-control"></asp:TextBox>

                    <div class="col-md-12" style="margin-bottom: 30px;">
                        <div style="position: absolute; top: 0; left: 0;">
                            <asp:RequiredFieldValidator ControlToValidate="txtCapacidad" ID="RequiredFieldValidator1" runat="server" CssClass="text-danger" ErrorMessage="Capacidad es obligatoria">

                            </asp:RequiredFieldValidator>
                        </div>

                        <div style="position: absolute; top: 0; left: 0;">
                            <asp:RegularExpressionValidator runat="server" ErrorMessage="Capacidad debe ser numérica" ControlToValidate="txtCapacidad" ValidationExpression="^\s*(?=.*[1-9])\d*(?:\.\d{1,2})?\s*$" CssClass="text-danger"></asp:RegularExpressionValidator>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <label for="<%=txtKilometraje.ClientID %>">Kilometraje</label>

                    <asp:TextBox ID="txtKilometraje" runat="server" CssClass="form-control"></asp:TextBox>

                    <div class="col-md-12" style="margin-bottom: 30px;">
                        <div style="position: absolute; top: 0; left: 0;">
                            <asp:RequiredFieldValidator ControlToValidate="txtKilometraje" ID="RequiredFieldValidator2" runat="server" CssClass="text-danger" ErrorMessage="Kilometraje es obligatorio">

                            </asp:RequiredFieldValidator>
                        </div>

                        <div style="position: absolute; top: 0; left: 0;">
                            <asp:RegularExpressionValidator runat="server" ErrorMessage="Kilometraje debe ser numérico" ControlToValidate="txtKilometraje" ValidationExpression="^[0-9]*\.?[0-9]+$" CssClass="text-danger"></asp:RegularExpressionValidator>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <label for="<%=DDLTipoCamion.ClientID %>">Tipo Camión</label>
                    <asp:DropDownList ID="DDLTipoCamion" CssClass="form-control" runat="server"></asp:DropDownList>

                    <asp:RequiredFieldValidator ControlToValidate="DDLTipoCamion" ID="RequiredFieldValidator3" runat="server" CssClass="text-danger" ErrorMessage="Selecciona el tipo de camion">

                    </asp:RequiredFieldValidator>


                </div>
                <div class="form-group">
                    <label for="<%=DDLModelo.ClientID %>">Modelo</label>
                    <asp:DropDownList ID="DDLModelo" CssClass="form-control" runat="server"></asp:DropDownList>

                    <asp:RequiredFieldValidator ControlToValidate="DDLModelo" ID="RequiredFieldValidator4" runat="server" CssClass="text-danger" ErrorMessage="Selecciona el modelo">

                    </asp:RequiredFieldValidator>


                </div>
                <div class="form-group">
                    <label for="<%=DDLMarca.ClientID %>">Marca</label>
                    <asp:DropDownList ID="DDLMarca" CssClass="form-control" runat="server"></asp:DropDownList>

                    <asp:RequiredFieldValidator ControlToValidate="DDLMarca" ID="RequiredFieldValidator5" runat="server" CssClass="text-danger" ErrorMessage="Selecciona la marca">

                    </asp:RequiredFieldValidator>


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
            </div>
        </div>
    </div>
</asp:Content>
