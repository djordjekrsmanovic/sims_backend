﻿#pragma checksum "..\..\..\..\..\..\ViewDoctor\Dialogues\Materijali i lekovi\MedicineDenialWriteMessage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8E06E98631884F93E447F63349D07A04CF5B1F16"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SIMS.LekarGUI.Dialogues.Materijali_i_lekovi;
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


namespace SIMS.LekarGUI.Dialogues.Materijali_i_lekovi {
    
    
    /// <summary>
    /// MedicineDenialWriteMessage
    /// </summary>
    public partial class MedicineDenialWriteMessage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\..\..\ViewDoctor\Dialogues\Materijali i lekovi\MedicineDenialWriteMessage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NotificationTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/SIMS;component/viewdoctor/dialogues/materijali%20i%20lekovi/medicinedenialwritem" +
                    "essage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\ViewDoctor\Dialogues\Materijali i lekovi\MedicineDenialWriteMessage.xaml"
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
            
            #line 8 "..\..\..\..\..\..\ViewDoctor\Dialogues\Materijali i lekovi\MedicineDenialWriteMessage.xaml"
            ((SIMS.LekarGUI.Dialogues.Materijali_i_lekovi.MedicineDenialWriteMessage)(target)).KeyDown += new System.Windows.Input.KeyEventHandler(this.WindowKeyListener);
            
            #line default
            #line hidden
            return;
            case 2:
            this.NotificationTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            
            #line 26 "..\..\..\..\..\..\ViewDoctor\Dialogues\Materijali i lekovi\MedicineDenialWriteMessage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CancelMessage);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 27 "..\..\..\..\..\..\ViewDoctor\Dialogues\Materijali i lekovi\MedicineDenialWriteMessage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AcceptMessage);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

