﻿#pragma checksum "..\..\..\..\..\..\ViewDoctor\Dialogues\Recepti i terapije\PrikazRecepta.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34136AC794B149099813025E57191ABD6A61E5BE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SIMS.LekarGUI;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace SIMS.LekarGUI {
    
    
    /// <summary>
    /// PrikazRecepta
    /// </summary>
    public partial class PrikazRecepta : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 37 "..\..\..\..\..\..\ViewDoctor\Dialogues\Recepti i terapije\PrikazRecepta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelDoktor;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\..\..\ViewDoctor\Dialogues\Recepti i terapije\PrikazRecepta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelPacijent;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\..\..\ViewDoctor\Dialogues\Recepti i terapije\PrikazRecepta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelDatum;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\..\..\ViewDoctor\Dialogues\Recepti i terapije\PrikazRecepta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label NazivLeka;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\..\..\ViewDoctor\Dialogues\Recepti i terapije\PrikazRecepta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Kolicina;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\..\..\ViewDoctor\Dialogues\Recepti i terapije\PrikazRecepta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Dijagnoza;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SIMS;component/viewdoctor/dialogues/recepti%20i%20terapije/prikazrecepta.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\ViewDoctor\Dialogues\Recepti i terapije\PrikazRecepta.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 9 "..\..\..\..\..\..\ViewDoctor\Dialogues\Recepti i terapije\PrikazRecepta.xaml"
            ((SIMS.LekarGUI.PrikazRecepta)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.WindowKeyListener);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LabelDoktor = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.LabelPacijent = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.LabelDatum = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.NazivLeka = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.Kolicina = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.Dijagnoza = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            
            #line 69 "..\..\..\..\..\..\ViewDoctor\Dialogues\Recepti i terapije\PrikazRecepta.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonCloseWindow);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
