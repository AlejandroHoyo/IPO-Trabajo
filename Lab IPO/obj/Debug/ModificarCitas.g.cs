﻿#pragma checksum "..\..\ModificarCitas.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3152ED8E38209FAFF2306E79D84604148A786C0E9AC6B29880229B0AD9E9F46B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Lab_IPO;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Lab_IPO {
    
    
    /// <summary>
    /// ModificarCitas
    /// </summary>
    public partial class ModificarCitas : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\ModificarCitas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button confirmarModificarCitasButton;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\ModificarCitas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancelarModificarCitasButton;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\ModificarCitas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker fechaModificarCitaDate;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\ModificarCitas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox horaModificarCitaTextbox;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\ModificarCitas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox duracionModificarCitaTextbox;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\ModificarCitas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox estadoModificarPersonalTextbox;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\ModificarCitas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox pacienteModificarPersonalTextbox;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\ModificarCitas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox doctorModificarCitaTextbox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Lab IPO;component/modificarcitas.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ModificarCitas.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.confirmarModificarCitasButton = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\ModificarCitas.xaml"
            this.confirmarModificarCitasButton.Click += new System.Windows.RoutedEventHandler(this.btnConfirmarCambiosCita_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cancelarModificarCitasButton = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\ModificarCitas.xaml"
            this.cancelarModificarCitasButton.Click += new System.Windows.RoutedEventHandler(this.btnBorrarCambiosCita_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.fechaModificarCitaDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.horaModificarCitaTextbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.duracionModificarCitaTextbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.estadoModificarPersonalTextbox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.pacienteModificarPersonalTextbox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.doctorModificarCitaTextbox = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

