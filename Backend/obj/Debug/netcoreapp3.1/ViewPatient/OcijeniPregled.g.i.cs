﻿#pragma checksum "..\..\..\..\ViewPatient\OcijeniPregled.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "474C91019CB3698A674A027CB88D83CE51073168"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using SIMS.PacijentGUI;
using SIMS.Repositories.SecretaryRepo;
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


namespace SIMS.PacijentGUI {
    
    
    /// <summary>
    /// OcijeniPregled
    /// </summary>
    public partial class OcijeniPregled : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\..\ViewPatient\OcijeniPregled.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Nazad;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\ViewPatient\OcijeniPregled.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.RatingBar BasicRatingBar;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\ViewPatient\OcijeniPregled.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer Scroler;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\ViewPatient\OcijeniPregled.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border debugPanel;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\ViewPatient\OcijeniPregled.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox KomentarPregleda;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\..\ViewPatient\OcijeniPregled.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Posalji;
        
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
            System.Uri resourceLocater = new System.Uri("/SIMS;component/viewpatient/ocijenipregled.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\ViewPatient\OcijeniPregled.xaml"
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
            this.Nazad = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\..\ViewPatient\OcijeniPregled.xaml"
            this.Nazad.Click += new System.Windows.RoutedEventHandler(this.Nazad_OnClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BasicRatingBar = ((MaterialDesignThemes.Wpf.RatingBar)(target));
            return;
            case 3:
            this.Scroler = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 4:
            this.debugPanel = ((System.Windows.Controls.Border)(target));
            return;
            case 5:
            this.KomentarPregleda = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Posalji = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\..\..\ViewPatient\OcijeniPregled.xaml"
            this.Posalji.Click += new System.Windows.RoutedEventHandler(this.Posalji_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

