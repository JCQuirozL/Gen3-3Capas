//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gen3_3Capas.WSReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WSReference.WSRutasSoap")]
    public interface WSRutasSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento calle del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insDireccion", ReplyAction="*")]
        Gen3_3Capas.WSReference.insDireccionResponse insDireccion(Gen3_3Capas.WSReference.insDireccionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/insDireccion", ReplyAction="*")]
        System.Threading.Tasks.Task<Gen3_3Capas.WSReference.insDireccionResponse> insDireccionAsync(Gen3_3Capas.WSReference.insDireccionRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento descripcion del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InsertarCargamento", ReplyAction="*")]
        Gen3_3Capas.WSReference.InsertarCargamentoResponse InsertarCargamento(Gen3_3Capas.WSReference.InsertarCargamentoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InsertarCargamento", ReplyAction="*")]
        System.Threading.Tasks.Task<Gen3_3Capas.WSReference.InsertarCargamentoResponse> InsertarCargamentoAsync(Gen3_3Capas.WSReference.InsertarCargamentoRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class insDireccionRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="insDireccion", Namespace="http://tempuri.org/", Order=0)]
        public Gen3_3Capas.WSReference.insDireccionRequestBody Body;
        
        public insDireccionRequest() {
        }
        
        public insDireccionRequest(Gen3_3Capas.WSReference.insDireccionRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class insDireccionRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string calle;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string numero;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string colonia;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string ciudad;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string estado;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string cp;
        
        public insDireccionRequestBody() {
        }
        
        public insDireccionRequestBody(string calle, string numero, string colonia, string ciudad, string estado, string cp) {
            this.calle = calle;
            this.numero = numero;
            this.colonia = colonia;
            this.ciudad = ciudad;
            this.estado = estado;
            this.cp = cp;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class insDireccionResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="insDireccionResponse", Namespace="http://tempuri.org/", Order=0)]
        public Gen3_3Capas.WSReference.insDireccionResponseBody Body;
        
        public insDireccionResponse() {
        }
        
        public insDireccionResponse(Gen3_3Capas.WSReference.insDireccionResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class insDireccionResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int insDireccionResult;
        
        public insDireccionResponseBody() {
        }
        
        public insDireccionResponseBody(int insDireccionResult) {
            this.insDireccionResult = insDireccionResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertarCargamentoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertarCargamento", Namespace="http://tempuri.org/", Order=0)]
        public Gen3_3Capas.WSReference.InsertarCargamentoRequestBody Body;
        
        public InsertarCargamentoRequest() {
        }
        
        public InsertarCargamentoRequest(Gen3_3Capas.WSReference.InsertarCargamentoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InsertarCargamentoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public long idruta;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string descripcion;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public double peso;
        
        public InsertarCargamentoRequestBody() {
        }
        
        public InsertarCargamentoRequestBody(long idruta, string descripcion, double peso) {
            this.idruta = idruta;
            this.descripcion = descripcion;
            this.peso = peso;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertarCargamentoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertarCargamentoResponse", Namespace="http://tempuri.org/", Order=0)]
        public Gen3_3Capas.WSReference.InsertarCargamentoResponseBody Body;
        
        public InsertarCargamentoResponse() {
        }
        
        public InsertarCargamentoResponse(Gen3_3Capas.WSReference.InsertarCargamentoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InsertarCargamentoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InsertarCargamentoResult;
        
        public InsertarCargamentoResponseBody() {
        }
        
        public InsertarCargamentoResponseBody(string InsertarCargamentoResult) {
            this.InsertarCargamentoResult = InsertarCargamentoResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WSRutasSoapChannel : Gen3_3Capas.WSReference.WSRutasSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSRutasSoapClient : System.ServiceModel.ClientBase<Gen3_3Capas.WSReference.WSRutasSoap>, Gen3_3Capas.WSReference.WSRutasSoap {
        
        public WSRutasSoapClient() {
        }
        
        public WSRutasSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSRutasSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSRutasSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSRutasSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Gen3_3Capas.WSReference.insDireccionResponse Gen3_3Capas.WSReference.WSRutasSoap.insDireccion(Gen3_3Capas.WSReference.insDireccionRequest request) {
            return base.Channel.insDireccion(request);
        }
        
        public int insDireccion(string calle, string numero, string colonia, string ciudad, string estado, string cp) {
            Gen3_3Capas.WSReference.insDireccionRequest inValue = new Gen3_3Capas.WSReference.insDireccionRequest();
            inValue.Body = new Gen3_3Capas.WSReference.insDireccionRequestBody();
            inValue.Body.calle = calle;
            inValue.Body.numero = numero;
            inValue.Body.colonia = colonia;
            inValue.Body.ciudad = ciudad;
            inValue.Body.estado = estado;
            inValue.Body.cp = cp;
            Gen3_3Capas.WSReference.insDireccionResponse retVal = ((Gen3_3Capas.WSReference.WSRutasSoap)(this)).insDireccion(inValue);
            return retVal.Body.insDireccionResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Gen3_3Capas.WSReference.insDireccionResponse> Gen3_3Capas.WSReference.WSRutasSoap.insDireccionAsync(Gen3_3Capas.WSReference.insDireccionRequest request) {
            return base.Channel.insDireccionAsync(request);
        }
        
        public System.Threading.Tasks.Task<Gen3_3Capas.WSReference.insDireccionResponse> insDireccionAsync(string calle, string numero, string colonia, string ciudad, string estado, string cp) {
            Gen3_3Capas.WSReference.insDireccionRequest inValue = new Gen3_3Capas.WSReference.insDireccionRequest();
            inValue.Body = new Gen3_3Capas.WSReference.insDireccionRequestBody();
            inValue.Body.calle = calle;
            inValue.Body.numero = numero;
            inValue.Body.colonia = colonia;
            inValue.Body.ciudad = ciudad;
            inValue.Body.estado = estado;
            inValue.Body.cp = cp;
            return ((Gen3_3Capas.WSReference.WSRutasSoap)(this)).insDireccionAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Gen3_3Capas.WSReference.InsertarCargamentoResponse Gen3_3Capas.WSReference.WSRutasSoap.InsertarCargamento(Gen3_3Capas.WSReference.InsertarCargamentoRequest request) {
            return base.Channel.InsertarCargamento(request);
        }
        
        public string InsertarCargamento(long idruta, string descripcion, double peso) {
            Gen3_3Capas.WSReference.InsertarCargamentoRequest inValue = new Gen3_3Capas.WSReference.InsertarCargamentoRequest();
            inValue.Body = new Gen3_3Capas.WSReference.InsertarCargamentoRequestBody();
            inValue.Body.idruta = idruta;
            inValue.Body.descripcion = descripcion;
            inValue.Body.peso = peso;
            Gen3_3Capas.WSReference.InsertarCargamentoResponse retVal = ((Gen3_3Capas.WSReference.WSRutasSoap)(this)).InsertarCargamento(inValue);
            return retVal.Body.InsertarCargamentoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Gen3_3Capas.WSReference.InsertarCargamentoResponse> Gen3_3Capas.WSReference.WSRutasSoap.InsertarCargamentoAsync(Gen3_3Capas.WSReference.InsertarCargamentoRequest request) {
            return base.Channel.InsertarCargamentoAsync(request);
        }
        
        public System.Threading.Tasks.Task<Gen3_3Capas.WSReference.InsertarCargamentoResponse> InsertarCargamentoAsync(long idruta, string descripcion, double peso) {
            Gen3_3Capas.WSReference.InsertarCargamentoRequest inValue = new Gen3_3Capas.WSReference.InsertarCargamentoRequest();
            inValue.Body = new Gen3_3Capas.WSReference.InsertarCargamentoRequestBody();
            inValue.Body.idruta = idruta;
            inValue.Body.descripcion = descripcion;
            inValue.Body.peso = peso;
            return ((Gen3_3Capas.WSReference.WSRutasSoap)(this)).InsertarCargamentoAsync(inValue);
        }
    }
}
