﻿#pragma checksum "..\..\..\..\..\..\ViewDoctor\Pages\3 Istorija pregleda\LekarIstorijaPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8FED2C46A9FE51E8A16D053A9F174AF313E51FFD"
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
    /// AppointmentHistoryView
    /// </summary>
    public partial class AppointmentHistoryView : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 52 "..\..\..\..\..\..\ViewDoctor\Pages\3 Istorija pregleda\LekarIstorijaPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridAppointments;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\..\..\ViewDoctor\Pages\3 Istorija pregleda\LekarIstorijaPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridReports;
        
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
            System.Uri resourceLocater = new System.Uri("/SIMS;component/viewdoctor/pages/3%20istorija%20pregleda/lekaristorijapage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\ViewDoctor\Pages\3 Istorija pregleda\LekarIstorijaPage.xaml"
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
            
            #line 31 "..\..\..\..\..\..\ViewDoctor\Pages\3 Istorija pregleda\LekarIstorijaPage.xaml"
            ((System.Windows.Controls.Image)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ButtonHome);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dataGridAppointments = ((System.Windows.Controls.DataGrid)(target));
            
            #line 53 "..\..\..\..\..\..\ViewDoctor\Pages\3 Istorija pregleda\LekarIstorijaPage.xaml"
            this.dataGridAppointments.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.ButtonWriteReport);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 66 "..\..\..\..\..\..\ViewDoctor\Pages\3 Istorija pregleda\LekarIstorijaPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonWriteReport);
            
            #line default
            #line hidden
            return;
            case 4:
            this.dataGridReports = ((System.Windows.Controls.DataGrid)(target));
            
            #line 71 "..\..\..\..\..\..\ViewDoctor\Pages\3 Istorija pregleda\LekarIstorijaPage.xaml"
            this.dataGridReports.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.ButtonReadReport);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 84 "..\..\..\..\..\..\ViewDoctor\Pages\3 Istorija pregleda\LekarIstorijaPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonReadReport);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
