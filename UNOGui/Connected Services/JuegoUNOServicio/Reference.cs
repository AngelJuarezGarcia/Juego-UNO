﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UNOGui.JuegoUNOServicio {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Jugador", Namespace="http://schemas.datacontract.org/2004/07/UNO.Dominio")]
    [System.SerializableAttribute()]
    public partial class Jugador : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ClaveValidacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContraseñaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CorreoElectronicoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ExperienciaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NicknameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NivelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PartidasGanadasField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PartidasJugadasField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PuntajeTotalField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ClaveValidacion {
            get {
                return this.ClaveValidacionField;
            }
            set {
                if ((object.ReferenceEquals(this.ClaveValidacionField, value) != true)) {
                    this.ClaveValidacionField = value;
                    this.RaisePropertyChanged("ClaveValidacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Contraseña {
            get {
                return this.ContraseñaField;
            }
            set {
                if ((object.ReferenceEquals(this.ContraseñaField, value) != true)) {
                    this.ContraseñaField = value;
                    this.RaisePropertyChanged("Contraseña");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CorreoElectronico {
            get {
                return this.CorreoElectronicoField;
            }
            set {
                if ((object.ReferenceEquals(this.CorreoElectronicoField, value) != true)) {
                    this.CorreoElectronicoField = value;
                    this.RaisePropertyChanged("CorreoElectronico");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Experiencia {
            get {
                return this.ExperienciaField;
            }
            set {
                if ((this.ExperienciaField.Equals(value) != true)) {
                    this.ExperienciaField = value;
                    this.RaisePropertyChanged("Experiencia");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nickname {
            get {
                return this.NicknameField;
            }
            set {
                if ((object.ReferenceEquals(this.NicknameField, value) != true)) {
                    this.NicknameField = value;
                    this.RaisePropertyChanged("Nickname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Nivel {
            get {
                return this.NivelField;
            }
            set {
                if ((this.NivelField.Equals(value) != true)) {
                    this.NivelField = value;
                    this.RaisePropertyChanged("Nivel");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PartidasGanadas {
            get {
                return this.PartidasGanadasField;
            }
            set {
                if ((this.PartidasGanadasField.Equals(value) != true)) {
                    this.PartidasGanadasField = value;
                    this.RaisePropertyChanged("PartidasGanadas");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PartidasJugadas {
            get {
                return this.PartidasJugadasField;
            }
            set {
                if ((this.PartidasJugadasField.Equals(value) != true)) {
                    this.PartidasJugadasField = value;
                    this.RaisePropertyChanged("PartidasJugadas");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PuntajeTotal {
            get {
                return this.PuntajeTotalField;
            }
            set {
                if ((this.PuntajeTotalField.Equals(value) != true)) {
                    this.PuntajeTotalField = value;
                    this.RaisePropertyChanged("PuntajeTotal");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ResultadoRegistro", Namespace="http://schemas.datacontract.org/2004/07/UNO.Contratos.AdministrarJugador")]
    public enum ResultadoRegistro : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        RegistroExitoso = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ErrorRegistro = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        UsuarioYaExiste = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        CorreoYaExiste = 4,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ResultadoLogin", Namespace="http://schemas.datacontract.org/2004/07/UNO.Contratos.Login")]
    public enum ResultadoLogin : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        NoExisteNickname = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ContraseñaIncorrecta = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ExisteJugador = 3,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Sala", Namespace="http://schemas.datacontract.org/2004/07/UNO.Contratos.AdministrarSala")]
    [System.SerializableAttribute()]
    public partial class Sala : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContraseñaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.Dictionary<object, UNOGui.JuegoUNOServicio.Jugador> JugadoresEnSalaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NumeroTotalDeJugadoresField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Contraseña {
            get {
                return this.ContraseñaField;
            }
            set {
                if ((object.ReferenceEquals(this.ContraseñaField, value) != true)) {
                    this.ContraseñaField = value;
                    this.RaisePropertyChanged("Contraseña");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.Dictionary<object, UNOGui.JuegoUNOServicio.Jugador> JugadoresEnSala {
            get {
                return this.JugadoresEnSalaField;
            }
            set {
                if ((object.ReferenceEquals(this.JugadoresEnSalaField, value) != true)) {
                    this.JugadoresEnSalaField = value;
                    this.RaisePropertyChanged("JugadoresEnSala");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NumeroTotalDeJugadores {
            get {
                return this.NumeroTotalDeJugadoresField;
            }
            set {
                if ((this.NumeroTotalDeJugadoresField.Equals(value) != true)) {
                    this.NumeroTotalDeJugadoresField = value;
                    this.RaisePropertyChanged("NumeroTotalDeJugadores");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ResultadoUnionSala", Namespace="http://schemas.datacontract.org/2004/07/UNO.Contratos.AdministrarSala")]
    public enum ResultadoUnionSala : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        NoExisteId = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ContraseñaIncorrecta = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        NoHayCupo = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        UnionExitosa = 4,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="JuegoUNOServicio.IRegistrarJugador", CallbackContract=typeof(UNOGui.JuegoUNOServicio.IRegistrarJugadorCallback))]
    public interface IRegistrarJugador {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IRegistrarJugador/RegistrarJugador")]
        void RegistrarJugador(UNOGui.JuegoUNOServicio.Jugador jugador);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IRegistrarJugador/RegistrarJugador")]
        System.Threading.Tasks.Task RegistrarJugadorAsync(UNOGui.JuegoUNOServicio.Jugador jugador);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IRegistrarJugador/VerificarClave")]
        void VerificarClave(string clave);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IRegistrarJugador/VerificarClave")]
        System.Threading.Tasks.Task VerificarClaveAsync(string clave);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IRegistrarJugador/CancelarRegistro")]
        void CancelarRegistro();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IRegistrarJugador/CancelarRegistro")]
        System.Threading.Tasks.Task CancelarRegistroAsync();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IRegistrarJugador/EnviarClaveDeNuevo")]
        void EnviarClaveDeNuevo();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IRegistrarJugador/EnviarClaveDeNuevo")]
        System.Threading.Tasks.Task EnviarClaveDeNuevoAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRegistrarJugadorCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IRegistrarJugador/NotificarRegistro")]
        void NotificarRegistro(UNOGui.JuegoUNOServicio.ResultadoRegistro resultado);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IRegistrarJugador/NotificarResultadoClave")]
        void NotificarResultadoClave(bool claveValida);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IRegistrarJugador/NotificarCancelacionRegistro")]
        void NotificarCancelacionRegistro();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IRegistrarJugador/NotificarEnvioDeClave")]
        void NotificarEnvioDeClave();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRegistrarJugadorChannel : UNOGui.JuegoUNOServicio.IRegistrarJugador, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RegistrarJugadorClient : System.ServiceModel.DuplexClientBase<UNOGui.JuegoUNOServicio.IRegistrarJugador>, UNOGui.JuegoUNOServicio.IRegistrarJugador {
        
        public RegistrarJugadorClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public RegistrarJugadorClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public RegistrarJugadorClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public RegistrarJugadorClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public RegistrarJugadorClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void RegistrarJugador(UNOGui.JuegoUNOServicio.Jugador jugador) {
            base.Channel.RegistrarJugador(jugador);
        }
        
        public System.Threading.Tasks.Task RegistrarJugadorAsync(UNOGui.JuegoUNOServicio.Jugador jugador) {
            return base.Channel.RegistrarJugadorAsync(jugador);
        }
        
        public void VerificarClave(string clave) {
            base.Channel.VerificarClave(clave);
        }
        
        public System.Threading.Tasks.Task VerificarClaveAsync(string clave) {
            return base.Channel.VerificarClaveAsync(clave);
        }
        
        public void CancelarRegistro() {
            base.Channel.CancelarRegistro();
        }
        
        public System.Threading.Tasks.Task CancelarRegistroAsync() {
            return base.Channel.CancelarRegistroAsync();
        }
        
        public void EnviarClaveDeNuevo() {
            base.Channel.EnviarClaveDeNuevo();
        }
        
        public System.Threading.Tasks.Task EnviarClaveDeNuevoAsync() {
            return base.Channel.EnviarClaveDeNuevoAsync();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="JuegoUNOServicio.ILogin", CallbackContract=typeof(UNOGui.JuegoUNOServicio.ILoginCallback))]
    public interface ILogin {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ILogin/IniciarSesion")]
        void IniciarSesion(string nickname, string contraseña);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ILogin/IniciarSesion")]
        System.Threading.Tasks.Task IniciarSesionAsync(string nickname, string contraseña);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILoginCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ILogin/NotificarResultadoLogin")]
        void NotificarResultadoLogin(UNOGui.JuegoUNOServicio.ResultadoLogin resultado);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILoginChannel : UNOGui.JuegoUNOServicio.ILogin, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LoginClient : System.ServiceModel.DuplexClientBase<UNOGui.JuegoUNOServicio.ILogin>, UNOGui.JuegoUNOServicio.ILogin {
        
        public LoginClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public LoginClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public LoginClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public LoginClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public LoginClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void IniciarSesion(string nickname, string contraseña) {
            base.Channel.IniciarSesion(nickname, contraseña);
        }
        
        public System.Threading.Tasks.Task IniciarSesionAsync(string nickname, string contraseña) {
            return base.Channel.IniciarSesionAsync(nickname, contraseña);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="JuegoUNOServicio.IAdministrarSala", CallbackContract=typeof(UNOGui.JuegoUNOServicio.IAdministrarSalaCallback))]
    public interface IAdministrarSala {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IAdministrarSala/CrearSala")]
        void CrearSala(UNOGui.JuegoUNOServicio.Sala nuevaSala, UNOGui.JuegoUNOServicio.Jugador jugador);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IAdministrarSala/CrearSala")]
        System.Threading.Tasks.Task CrearSalaAsync(UNOGui.JuegoUNOServicio.Sala nuevaSala, UNOGui.JuegoUNOServicio.Jugador jugador);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IAdministrarSala/UnirseASala")]
        void UnirseASala(UNOGui.JuegoUNOServicio.Sala salaAUnirse, UNOGui.JuegoUNOServicio.Jugador jugador);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IAdministrarSala/UnirseASala")]
        System.Threading.Tasks.Task UnirseASalaAsync(UNOGui.JuegoUNOServicio.Sala salaAUnirse, UNOGui.JuegoUNOServicio.Jugador jugador);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IAdministrarSala/SalirDeSala")]
        void SalirDeSala(string idSala);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IAdministrarSala/SalirDeSala")]
        System.Threading.Tasks.Task SalirDeSalaAsync(string idSala);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAdministrarSalaCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IAdministrarSala/NotificarCreacionDeSala")]
        void NotificarCreacionDeSala(UNOGui.JuegoUNOServicio.Sala salaCreada);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IAdministrarSala/NotificarUnionASala")]
        void NotificarUnionASala(UNOGui.JuegoUNOServicio.ResultadoUnionSala resultado);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IAdministrarSala/ActualizarSala")]
        void ActualizarSala(string[] jugadores);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAdministrarSalaChannel : UNOGui.JuegoUNOServicio.IAdministrarSala, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AdministrarSalaClient : System.ServiceModel.DuplexClientBase<UNOGui.JuegoUNOServicio.IAdministrarSala>, UNOGui.JuegoUNOServicio.IAdministrarSala {
        
        public AdministrarSalaClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public AdministrarSalaClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public AdministrarSalaClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public AdministrarSalaClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public AdministrarSalaClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void CrearSala(UNOGui.JuegoUNOServicio.Sala nuevaSala, UNOGui.JuegoUNOServicio.Jugador jugador) {
            base.Channel.CrearSala(nuevaSala, jugador);
        }
        
        public System.Threading.Tasks.Task CrearSalaAsync(UNOGui.JuegoUNOServicio.Sala nuevaSala, UNOGui.JuegoUNOServicio.Jugador jugador) {
            return base.Channel.CrearSalaAsync(nuevaSala, jugador);
        }
        
        public void UnirseASala(UNOGui.JuegoUNOServicio.Sala salaAUnirse, UNOGui.JuegoUNOServicio.Jugador jugador) {
            base.Channel.UnirseASala(salaAUnirse, jugador);
        }
        
        public System.Threading.Tasks.Task UnirseASalaAsync(UNOGui.JuegoUNOServicio.Sala salaAUnirse, UNOGui.JuegoUNOServicio.Jugador jugador) {
            return base.Channel.UnirseASalaAsync(salaAUnirse, jugador);
        }
        
        public void SalirDeSala(string idSala) {
            base.Channel.SalirDeSala(idSala);
        }
        
        public System.Threading.Tasks.Task SalirDeSalaAsync(string idSala) {
            return base.Channel.SalirDeSalaAsync(idSala);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="JuegoUNOServicio.IRecuperarCuenta", CallbackContract=typeof(UNOGui.JuegoUNOServicio.IRecuperarCuentaCallback))]
    public interface IRecuperarCuenta {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IRecuperarCuenta/VerificarClaveRecuperacion")]
        void VerificarClaveRecuperacion(string clave);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IRecuperarCuenta/VerificarClaveRecuperacion")]
        System.Threading.Tasks.Task VerificarClaveRecuperacionAsync(string clave);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IRecuperarCuenta/EnviarClaveRecuperacion")]
        void EnviarClaveRecuperacion(UNOGui.JuegoUNOServicio.Jugador infoJugador);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IRecuperarCuenta/EnviarClaveRecuperacion")]
        System.Threading.Tasks.Task EnviarClaveRecuperacionAsync(UNOGui.JuegoUNOServicio.Jugador infoJugador);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IRecuperarCuenta/ActualizarContrasenia")]
        void ActualizarContrasenia(string contrasenia);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IRecuperarCuenta/ActualizarContrasenia")]
        System.Threading.Tasks.Task ActualizarContraseniaAsync(string contrasenia);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRecuperarCuentaCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IRecuperarCuenta/NotificarEnvioClave")]
        void NotificarEnvioClave(bool resultado);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IRecuperarCuenta/NotificarResultadoVerificación")]
        void NotificarResultadoVerificación(bool resultado);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IRecuperarCuenta/NotificarResultadoRecuperacion")]
        void NotificarResultadoRecuperacion(bool recuperada);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRecuperarCuentaChannel : UNOGui.JuegoUNOServicio.IRecuperarCuenta, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RecuperarCuentaClient : System.ServiceModel.DuplexClientBase<UNOGui.JuegoUNOServicio.IRecuperarCuenta>, UNOGui.JuegoUNOServicio.IRecuperarCuenta {
        
        public RecuperarCuentaClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public RecuperarCuentaClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public RecuperarCuentaClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public RecuperarCuentaClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public RecuperarCuentaClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void VerificarClaveRecuperacion(string clave) {
            base.Channel.VerificarClaveRecuperacion(clave);
        }
        
        public System.Threading.Tasks.Task VerificarClaveRecuperacionAsync(string clave) {
            return base.Channel.VerificarClaveRecuperacionAsync(clave);
        }
        
        public void EnviarClaveRecuperacion(UNOGui.JuegoUNOServicio.Jugador infoJugador) {
            base.Channel.EnviarClaveRecuperacion(infoJugador);
        }
        
        public System.Threading.Tasks.Task EnviarClaveRecuperacionAsync(UNOGui.JuegoUNOServicio.Jugador infoJugador) {
            return base.Channel.EnviarClaveRecuperacionAsync(infoJugador);
        }
        
        public void ActualizarContrasenia(string contrasenia) {
            base.Channel.ActualizarContrasenia(contrasenia);
        }
        
        public System.Threading.Tasks.Task ActualizarContraseniaAsync(string contrasenia) {
            return base.Channel.ActualizarContraseniaAsync(contrasenia);
        }
    }
}
