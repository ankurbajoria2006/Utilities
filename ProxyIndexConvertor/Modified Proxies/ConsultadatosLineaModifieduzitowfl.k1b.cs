//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace = "http://siebel.com.asi/", ConfigurationName = "_2426")]
public interface _2426
{

    // CODEGEN: Generating message contract since the operation ConsultaDatosLinea is neither RPC nor document wrapped.
    [System.ServiceModel.OperationContractAttribute(Action = "document/http://siebel.com.asi/:ConsultaDatosLinea", ReplyAction = "*")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    ConsultaDatosLineaResponse ConsultaDatosLinea(ConsultaDatosLineaRequest request);

    [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "document/http://siebel.com.asi/:ConsultaDatosLinea", ReplyAction = "*")]
    System.IAsyncResult BeginConsultaDatosLinea(ConsultaDatosLineaRequest request, System.AsyncCallback callback, object asyncState);

    ConsultaDatosLineaResponse EndConsultaDatosLinea(System.IAsyncResult result);
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://siebel.com.asi/")]
public partial class TP_Consulta_Datos_Linea_2426_WF_In_ConsultaDatosLinea_Input
{

    private string nroLineaField;

    /// <remarks/>
[System.Xml.Serialization.XmlElementAttribute("nroLinea")]
    public string nroLinea
    {
        get
        {
            return this.nroLineaField;
        }
        set
        {
            this.nroLineaField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.siebel.com/xml/IF%202426%20IO")]
public partial class Domicilio2
{

    private string calleField;

    private string barrioField;

    private string pisodeptoField;

    private string localidadField;

    private string dirLegalField;

    private string domNormalizadoField;

    private string numeroField;

    private string paisField;

    private string correoField;

    private string codpostalField;

    private string dirFacturacionField;

    private string provinciaField;

    /// <remarks/>
[System.Xml.Serialization.XmlElementAttribute("Calle")]
    public string Calle
    {
        get
        {
            return this.calleField;
        }
        set
        {
            this.calleField = value;
        }
    }

    /// <remarks/>
[System.Xml.Serialization.XmlElementAttribute("Barrio")]
    public string Barrio
    {
        get
        {
            return this.barrioField;
        }
        set
        {
            this.barrioField = value;
        }
    }

    /// <remarks/>
[System.Xml.Serialization.XmlElementAttribute("Pisodepto")]
    public string Pisodepto
    {
        get
        {
            return this.pisodeptoField;
        }
        set
        {
            this.pisodeptoField = value;
        }
    }

    /// <remarks/>
[System.Xml.Serialization.XmlElementAttribute("Localidad")]
    public string Localidad
    {
        get
        {
            return this.localidadField;
        }
        set
        {
            this.localidadField = value;
        }
    }

    /// <remarks/>
[System.Xml.Serialization.XmlElementAttribute("DirLegal")]
    public string DirLegal
    {
        get
        {
            return this.dirLegalField;
        }
        set
        {
            this.dirLegalField = value;
        }
    }

    /// <remarks/>
[System.Xml.Serialization.XmlElementAttribute("DomNormalizado")]
    public string DomNormalizado
    {
        get
        {
            return this.domNormalizadoField;
        }
        set
        {
            this.domNormalizadoField = value;
        }
    }

    /// <remarks/>
[System.Xml.Serialization.XmlElementAttribute("Numero")]
    public string Numero
    {
        get
        {
            return this.numeroField;
        }
        set
        {
            this.numeroField = value;
        }
    }

    /// <remarks/>
[System.Xml.Serialization.XmlElementAttribute("Pais")]
    public string Pais
    {
        get
        {
            return this.paisField;
        }
        set
        {
            this.paisField = value;
        }
    }

    /// <remarks/>
[System.Xml.Serialization.XmlElementAttribute("correo")]
    public string correo
    {
        get
        {
            return this.correoField;
        }
        set
        {
            this.correoField = value;
        }
    }

    /// <remarks/>
[System.Xml.Serialization.XmlElementAttribute("Codpostal")]
    public string Codpostal
    {
        get
        {
            return this.codpostalField;
        }
        set
        {
            this.codpostalField = value;
        }
    }

    /// <remarks/>
[System.Xml.Serialization.XmlElementAttribute("DirFacturacion")]
    public string DirFacturacion
    {
        get
        {
            return this.dirFacturacionField;
        }
        set
        {
            this.dirFacturacionField = value;
        }
    }

    /// <remarks/>
[System.Xml.Serialization.XmlElementAttribute("Provincia")]
    public string Provincia
    {
        get
        {
            return this.provinciaField;
        }
        set
        {
            this.provinciaField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.siebel.com/xml/IF%202426%20IO")]
public partial class Domicilio1
{

    private string calleField;

    private string barrioField;

    private string pisodeptoField;

    private string localidadField;

    private string codpostalField;

    private string dirLegalField;

    private string domNormalizadoField;

    private string numeroField;

    private string paisField;

    private string correoField;

    private string dirFacturacionField;

    private string provinciaField;

    /// <remarks/>
[System.Xml.Serialization.XmlElementAttribute("Calle")]
    public string Calle
    {
        get
        {
            return this.calleField;
        }
        set
        {
            this.calleField = value;
        }
    }

    /// <remarks/>
[System.Xml.Serialization.XmlElementAttribute("Barrio")]
    public string Barrio
    {
        get
        {
            return this.barrioField;
        }
        set
        {
            this.barrioField = value;
        }
    }

    /// <remarks/>
[System.Xml.Serialization.XmlElementAttribute("Pisodepto")]
    public string Pisodepto
    {
        get
        {
            return this.pisodeptoField;
        }
        set
        {
            this.pisodeptoField = value;
        }
    }

    /// <remarks/>
[System.Xml.Serialization.XmlElementAttribute("Localidad")]
    public string Localidad
    {
        get
        {
            return this.localidadField;
        }
        set
        {
            this.localidadField = value;
        }
    }

    /// <remarks/>
[System.Xml.Serialization.XmlElementAttribute("Codpostal")]
    public string Codpostal
    {
        get
        {
            return this.codpostalField;
        }
        set
        {
            this.codpostalField = value;
        }
    }

    /// <remarks/>
[System.Xml.Serialization.XmlElementAttribute("DirLegal")]
    public string DirLegal
    {
        get
        {
            return this.dirLegalField;
        }
        set
        {
            this.dirLegalField = value;
        }
    }

    /// <remarks/>
[System.Xml.Serialization.XmlElementAttribute("DomNormalizado")]
    public string DomNormalizado
    {
        get
        {
            return this.domNormalizadoField;
        }
        set
        {
            this.domNormalizadoField = value;
        }
    }

    /// <remarks/>
[System.Xml.Serialization.XmlElementAttribute("Numero")]
    public string Numero
    {
        get
        {
            return this.numeroField;
        }
        set
        {
            this.numeroField = value;
        }
    }

    /// <remarks/>
[System.Xml.Serialization.XmlElementAttribute("Pais")]
    public string Pais
    {
        get
        {
            return this.paisField;
        }
        set
        {
            this.paisField = value;
        }
    }

    /// <remarks/>
[System.Xml.Serialization.XmlElementAttribute("correo")]
    public string correo
    {
        get
        {
            return this.correoField;
        }
        set
        {
            this.correoField = value;
        }
    }

    /// <remarks/>
[System.Xml.Serialization.XmlElementAttribute("DirFacturacion")]
    public string DirFacturacion
    {
        get
        {
            return this.dirFacturacionField;
        }
        set
        {
            this.dirFacturacionField = value;
        }
    }

    /// <remarks/>
[System.Xml.Serialization.XmlElementAttribute("Provincia")]
    public string Provincia
    {
        get
        {
            return this.provinciaField;
        }
        set
        {
            this.provinciaField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.siebel.com/xml/IF%202426%20IO")]
public partial class Domicilio
{

    private Domicilio1 domicilio1Field;

    private Domicilio2 domicilio2Field;

    /// <remarks/>
[System.Xml.Serialization.XmlElementAttribute("Domicilio1")]
    public Domicilio1 Domicilio1
    {
        get
        {
            return this.domicilio1Field;
        }
        set
        {
            this.domicilio1Field = value;
        }
    }

    /// <remarks/>
[System.Xml.Serialization.XmlElementAttribute("Domicilio2")]
    public Domicilio2 Domicilio2
    {
        get
        {
            return this.domicilio2Field;
        }
        set
        {
            this.domicilio2Field = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.siebel.com/xml/IF%202426%20IO")]
public partial class ListOfIf2426Io
{

    private Domicilio domicilioField;

    /// <remarks/>
[System.Xml.Serialization.XmlElementAttribute("Domicilio")]
    public Domicilio Domicilio
    {
        get
        {
            return this.domicilioField;
        }
        set
        {
            this.domicilioField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://siebel.com.asi/")]
public partial class TP_Consulta_Datos_Linea_2426_WF_In_ConsultaDatosLinea_Output
{

    private string apellidoField;

    private string campanaField;

    private string categoriaClubField;

    private string cicloField;

    private string customerIdField;

    private string emailField;

    private string error_spcCodeField;

    private string error_spcMessageField;

    private string estadoField;

    private string fechaActivacionField;

    private string fechaNacimientoField;

    private string flagAtencionField;

    private string flagFacturaField;

    private string flagNoRehabilitaField;

    private string medioPagoField;

    private string mercadoField;

    private string nombresField;

    private string nroDocumentoField;

    private string nroSSField;

    private string nroTelefonoField;

    private string planField;

    private string referentePagoField;

    private ListOfIf2426Io listOfIf2426IoField;

    private string segmentoField;

    private string socioClubField;

    private string subsegmentoField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Apellido")]
    public string Apellido
    {
        get
        {
            return this.apellidoField;
        }
        set
        {
            this.apellidoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Campana")]
    public string Campana
    {
        get
        {
            return this.campanaField;
        }
        set
        {
            this.campanaField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CategoriaClub")]
    public string CategoriaClub
    {
        get
        {
            return this.categoriaClubField;
        }
        set
        {
            this.categoriaClubField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Ciclo")]
    public string Ciclo
    {
        get
        {
            return this.cicloField;
        }
        set
        {
            this.cicloField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CustomerId")]
    public string CustomerId
    {
        get
        {
            return this.customerIdField;
        }
        set
        {
            this.customerIdField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Email")]
    public string Email
    {
        get
        {
            return this.emailField;
        }
        set
        {
            this.emailField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Error_spcCode")]
    public string Error_spcCode
    {
        get
        {
            return this.error_spcCodeField;
        }
        set
        {
            this.error_spcCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Error_spcMessage")]
    public string Error_spcMessage
    {
        get
        {
            return this.error_spcMessageField;
        }
        set
        {
            this.error_spcMessageField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Estado")]
    public string Estado
    {
        get
        {
            return this.estadoField;
        }
        set
        {
            this.estadoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("FechaActivacion")]
    public string FechaActivacion
    {
        get
        {
            return this.fechaActivacionField;
        }
        set
        {
            this.fechaActivacionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("FechaNacimiento")]
    public string FechaNacimiento
    {
        get
        {
            return this.fechaNacimientoField;
        }
        set
        {
            this.fechaNacimientoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("FlagAtencion")]
    public string FlagAtencion
    {
        get
        {
            return this.flagAtencionField;
        }
        set
        {
            this.flagAtencionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("FlagFactura")]
    public string FlagFactura
    {
        get
        {
            return this.flagFacturaField;
        }
        set
        {
            this.flagFacturaField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("FlagNoRehabilita")]
    public string FlagNoRehabilita
    {
        get
        {
            return this.flagNoRehabilitaField;
        }
        set
        {
            this.flagNoRehabilitaField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("MedioPago")]
    public string MedioPago
    {
        get
        {
            return this.medioPagoField;
        }
        set
        {
            this.medioPagoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Mercado")]
    public string Mercado
    {
        get
        {
            return this.mercadoField;
        }
        set
        {
            this.mercadoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Nombres")]
    public string Nombres
    {
        get
        {
            return this.nombresField;
        }
        set
        {
            this.nombresField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("NroDocumento")]
    public string NroDocumento
    {
        get
        {
            return this.nroDocumentoField;
        }
        set
        {
            this.nroDocumentoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("NroSS")]
    public string NroSS
    {
        get
        {
            return this.nroSSField;
        }
        set
        {
            this.nroSSField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("NroTelefono")]
    public string NroTelefono
    {
        get
        {
            return this.nroTelefonoField;
        }
        set
        {
            this.nroTelefonoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Plan")]
    public string Plan
    {
        get
        {
            return this.planField;
        }
        set
        {
            this.planField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ReferentePago")]
    public string ReferentePago
    {
        get
        {
            return this.referentePagoField;
        }
        set
        {
            this.referentePagoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.siebel.com/xml/IF%202426%20IO", ElementName = "ListOfIf2426Io")]
    public ListOfIf2426Io ListOfIf2426Io
    {
        get
        {
            return this.listOfIf2426IoField;
        }
        set
        {
            this.listOfIf2426IoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Segmento")]
    public string Segmento
    {
        get
        {
            return this.segmentoField;
        }
        set
        {
            this.segmentoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SocioClub")]
    public string SocioClub
    {
        get
        {
            return this.socioClubField;
        }
        set
        {
            this.socioClubField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Subsegmento")]
    public string Subsegmento
    {
        get
        {
            return this.subsegmentoField;
        }
        set
        {
            this.subsegmentoField = value;
        }
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
public partial class ConsultaDatosLineaRequest
{

    [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://siebel.com.asi/", Order = 0)]
    public TP_Consulta_Datos_Linea_2426_WF_In_ConsultaDatosLinea_Input TP_Consulta_Datos_Linea_2426_WF_In_ConsultaDatosLinea_Input;

    public ConsultaDatosLineaRequest()
    {
    }

    public ConsultaDatosLineaRequest(TP_Consulta_Datos_Linea_2426_WF_In_ConsultaDatosLinea_Input TP_Consulta_Datos_Linea_2426_WF_In_ConsultaDatosLinea_Input)
    {
        this.TP_Consulta_Datos_Linea_2426_WF_In_ConsultaDatosLinea_Input = TP_Consulta_Datos_Linea_2426_WF_In_ConsultaDatosLinea_Input;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
public partial class ConsultaDatosLineaResponse
{

    [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://siebel.com.asi/", Order = 0)]
    public TP_Consulta_Datos_Linea_2426_WF_In_ConsultaDatosLinea_Output TP_Consulta_Datos_Linea_2426_WF_In_ConsultaDatosLinea_Output;

    public ConsultaDatosLineaResponse()
    {
    }

    public ConsultaDatosLineaResponse(TP_Consulta_Datos_Linea_2426_WF_In_ConsultaDatosLinea_Output TP_Consulta_Datos_Linea_2426_WF_In_ConsultaDatosLinea_Output)
    {
        this.TP_Consulta_Datos_Linea_2426_WF_In_ConsultaDatosLinea_Output = TP_Consulta_Datos_Linea_2426_WF_In_ConsultaDatosLinea_Output;
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface _2426Channel : _2426, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class _2426Client : System.ServiceModel.ClientBase<_2426>, _2426
{

    public _2426Client()
    {
    }

    public _2426Client(string endpointConfigurationName) :
        base(endpointConfigurationName)
    {
    }

    public _2426Client(string endpointConfigurationName, string remoteAddress) :
        base(endpointConfigurationName, remoteAddress)
    {
    }

    public _2426Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
        base(endpointConfigurationName, remoteAddress)
    {
    }

    public _2426Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
        base(binding, remoteAddress)
    {
    }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    ConsultaDatosLineaResponse _2426.ConsultaDatosLinea(ConsultaDatosLineaRequest request)
    {
        return base.Channel.ConsultaDatosLinea(request);
    }

    public TP_Consulta_Datos_Linea_2426_WF_In_ConsultaDatosLinea_Output ConsultaDatosLinea(TP_Consulta_Datos_Linea_2426_WF_In_ConsultaDatosLinea_Input TP_Consulta_Datos_Linea_2426_WF_In_ConsultaDatosLinea_Input)
    {
        ConsultaDatosLineaRequest inValue = new ConsultaDatosLineaRequest();
        inValue.TP_Consulta_Datos_Linea_2426_WF_In_ConsultaDatosLinea_Input = TP_Consulta_Datos_Linea_2426_WF_In_ConsultaDatosLinea_Input;
        ConsultaDatosLineaResponse retVal = ((_2426)(this)).ConsultaDatosLinea(inValue);
        return retVal.TP_Consulta_Datos_Linea_2426_WF_In_ConsultaDatosLinea_Output;
    }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.IAsyncResult _2426.BeginConsultaDatosLinea(ConsultaDatosLineaRequest request, System.AsyncCallback callback, object asyncState)
    {
        return base.Channel.BeginConsultaDatosLinea(request, callback, asyncState);
    }

    public System.IAsyncResult BeginConsultaDatosLinea(TP_Consulta_Datos_Linea_2426_WF_In_ConsultaDatosLinea_Input TP_Consulta_Datos_Linea_2426_WF_In_ConsultaDatosLinea_Input, System.AsyncCallback callback, object asyncState)
    {
        ConsultaDatosLineaRequest inValue = new ConsultaDatosLineaRequest();
        inValue.TP_Consulta_Datos_Linea_2426_WF_In_ConsultaDatosLinea_Input = TP_Consulta_Datos_Linea_2426_WF_In_ConsultaDatosLinea_Input;
        return ((_2426)(this)).BeginConsultaDatosLinea(inValue, callback, asyncState);
    }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    ConsultaDatosLineaResponse _2426.EndConsultaDatosLinea(System.IAsyncResult result)
    {
        return base.Channel.EndConsultaDatosLinea(result);
    }

    public TP_Consulta_Datos_Linea_2426_WF_In_ConsultaDatosLinea_Output EndConsultaDatosLinea(System.IAsyncResult result)
    {
        ConsultaDatosLineaResponse retVal = ((_2426)(this)).EndConsultaDatosLinea(result);
        return retVal.TP_Consulta_Datos_Linea_2426_WF_In_ConsultaDatosLinea_Output;
    }
}
