<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EdicionChofer.aspx.cs" Inherits="Gen3_3Capas.Catalogos.Choferes.EdicionChofer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <h3>Edición de chofer
                    <asp:Label ID="idChofer" runat="server"></asp:Label>
                </h3>

            </div>
        </div>

        <div class="row">
            <div class="col-md-12">
               
                <div class="form-group">
                    <label for="<%=txtLicencia.ClientID%>">Licencia</label>

                    <asp:TextBox ID="txtLicencia" placeholder="X-00000" CssClass="form-control" runat="server" MaxLength="7"></asp:TextBox>

                    <div class="col-md-12" style="margin-bottom: 30px;">

                        <div style="position: absolute; top: 0; left: 0;">

                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="txtLicencia" CssClass="text-danger" runat="server" ErrorMessage="Licencia requerida"></asp:RequiredFieldValidator>

                        </div>
                        <div style="position: absolute; top: 0; left: 0;">
                            <asp:RegularExpressionValidator ID="revtxtLicencia" ControlToValidate="txtLicencia" CssClass="text-danger" ValidationExpression="^[a-zA-Z]{1}-[0-9]{5}$" runat="server" ErrorMessage="El formato de la licencia no es correcto, favor de revisar: X-00000"></asp:RegularExpressionValidator>
                        </div>

                    </div>

                </div>
                <div class="form-group">
                    <label for="<%=txtTelefono.ClientID%>">Teléfono</label>

                    <asp:TextBox ID="txtTelefono" placeholder="" CssClass="form-control" runat="server" MaxLength="10"></asp:TextBox>

                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="txtTelefono" CssClass="text-danger" runat="server" ErrorMessage="Teléfono de chofer requerido"></asp:RequiredFieldValidator>

                    <%-- Acá colocaremos una máscara --%>
                    <ajaxToolkit:MaskedEditExtender ID="MEEtxtTelefono" TargetControlID="txtTelefono" Mask="(999) 999-9999" ClearMaskOnLostFocus="false" runat="server" />
                </div>
                <div class="form-group">
                    <label for="<%=fechaNacimiento.ClientID%>">Fecha Nacimiento</label>

                    <input id="fechaNacimiento" name="fechaNacimiento" type="text" class="form-control" runat="server" />


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
                    <asp:Image ID="imgFotoChofer" Width="150" Height="100" runat="server" />
                    <label id="urlFoto" runat="server"></label>
                </div>
            </div>
            <div class="col-md-12 col-md-offset-5">
                <div class="form-group">
                    <asp:Button OnClick="btnGurdar_Click" ID="btnGurdar" CssClass="btn btn-success" runat="server" Text="Guardar" />
                </div>
            </div>
        </div>
    </div>

    <script>
        $(document).ready(function () {
            console.log("documento listo");
            //Declarar al time picker en español con momentjs
            $.datetimepicker.setLocale('es');
            //Asignamo el calendario a los inputs de fecha
            $("#<%=fechaNacimiento.ClientID%>").datetimepicker({
                format: 'd/m/Y'
            });
        });
    </script>

</asp:Content>
