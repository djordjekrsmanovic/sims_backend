﻿#pragma checksum "..\..\..\..\..\..\ViewDoctor\Dialogues\Termini CRUD\UputCreate.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6837BB647AC8E5C2BAD8F561D7082D61C9411987"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SIMS.LekarGUI.Dialogues.Termini_CRUD;
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


namespace SIMS.LekarGUI.Dialogues.Termini_CRUD {
    
    
    /// <summary>
    /// WriteReferral
    /// </summary>
    public partial class WriteReferral : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\..\..\..\..\ViewDoctor\Dialogues\Termini CRUD\UputCreate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelPatientName;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\..\..\ViewDoctor\Dialogues\Termini CRUD\UputCreate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelDate;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\..\..\ViewDoctor\Dialogues\Termini CRUD\UputCreate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SpecijalizationComboBox;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\..\..\ViewDoctor\Dialogues\Termini CRUD\UputCreate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox DoctorComboBox;
        
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
            System.Uri resourceLocater = new System.Uri("/SIMS;component/viewdoctor/dialogues/termini%20crud/uputcreate.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\ViewDoctor\Dialogues\Termini CRUD\UputCreate.xaml"
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
            
            #line 8 "..\..\..\..\..\..\ViewDoctor\Dialogues\Termini CRUD\UputCreate.xaml"
            ((SIMS.LekarGUI.Dialogues.Termini_CRUD.WriteReferral)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.WindowKeyListener);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LabelPatientName = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.LabelDate = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.SpecijalizationComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 57 "..\..\..\..\..\..\ViewDoctor\Dialogues\Termini CRUD\UputCreate.xaml"
            this.SpecijalizationComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SpecializationChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.DoctorComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            
            #line 66 "..\..\..\..\..\..\ViewDoctor\Dialogues\Termini CRUD\UputCreate.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AcceptButton);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

