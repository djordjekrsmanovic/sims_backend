﻿#pragma checksum "..\..\..\..\..\ViewSecretary\Appointments\AddUrgentSurgery.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12A157D7DFEC93E0521DC118BAA776C7AEAB9F90"
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
using SIMS;
using SIMS.ViewSecretary;
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


namespace SIMS.ViewSecretary.Appointments {
    
    
    /// <summary>
    /// AddUrgentSurgery
    /// </summary>
    public partial class AddUrgentSurgery : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 66 "..\..\..\..\..\ViewSecretary\Appointments\AddUrgentSurgery.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox PatientComboBox;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\..\ViewSecretary\Appointments\AddUrgentSurgery.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SpecializationComboBox;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\..\ViewSecretary\Appointments\AddUrgentSurgery.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox DurationComboBox;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\..\..\ViewSecretary\Appointments\AddUrgentSurgery.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox AvailableComboBox;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\..\..\ViewSecretary\Appointments\AddUrgentSurgery.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button zakaziButton;
        
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
            System.Uri resourceLocater = new System.Uri("/SIMS;component/viewsecretary/appointments/addurgentsurgery.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\ViewSecretary\Appointments\AddUrgentSurgery.xaml"
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
            this.PatientComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 66 "..\..\..\..\..\ViewSecretary\Appointments\AddUrgentSurgery.xaml"
            this.PatientComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.PatientChange);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 68 "..\..\..\..\..\ViewSecretary\Appointments\AddUrgentSurgery.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Guest);
            
            #line default
            #line hidden
            return;
            case 3:
            this.SpecializationComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 73 "..\..\..\..\..\ViewSecretary\Appointments\AddUrgentSurgery.xaml"
            this.SpecializationComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SpecializationChange);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DurationComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 76 "..\..\..\..\..\ViewSecretary\Appointments\AddUrgentSurgery.xaml"
            this.DurationComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DurationChange);
            
            #line default
            #line hidden
            return;
            case 5:
            this.AvailableComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            
            #line 84 "..\..\..\..\..\ViewSecretary\Appointments\AddUrgentSurgery.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Quit);
            
            #line default
            #line hidden
            return;
            case 7:
            this.zakaziButton = ((System.Windows.Controls.Button)(target));
            
            #line 86 "..\..\..\..\..\ViewSecretary\Appointments\AddUrgentSurgery.xaml"
            this.zakaziButton.Click += new System.Windows.RoutedEventHandler(this.Button_Accept);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

