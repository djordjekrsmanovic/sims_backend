#pragma checksum "..\..\..\..\..\..\ViewDoctor\Dialogues\GeneratePDF\PDFReport.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DFF4A52EC153D5A48F0198F2EB18B68109F2D567"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SIMS.ViewDoctor.Dialogues.GeneratePDF;
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


namespace SIMS.ViewDoctor.Dialogues.GeneratePDF {
    
    
    /// <summary>
    /// PDFReport
    /// </summary>
    public partial class PDFReport : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\..\..\ViewDoctor\Dialogues\GeneratePDF\PDFReport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid print;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\..\..\ViewDoctor\Dialogues\GeneratePDF\PDFReport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelPatientName;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\..\..\ViewDoctor\Dialogues\GeneratePDF\PDFReport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelGender;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\..\..\ViewDoctor\Dialogues\GeneratePDF\PDFReport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelBirthDate;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\..\..\ViewDoctor\Dialogues\GeneratePDF\PDFReport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelDateReport;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\..\..\ViewDoctor\Dialogues\GeneratePDF\PDFReport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl dataGridAnamnesis;
        
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
            System.Uri resourceLocater = new System.Uri("/SIMS;component/viewdoctor/dialogues/generatepdf/pdfreport.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\ViewDoctor\Dialogues\GeneratePDF\PDFReport.xaml"
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
            this.print = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.LabelPatientName = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.LabelGender = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.LabelBirthDate = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.LabelDateReport = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.dataGridAnamnesis = ((System.Windows.Controls.ItemsControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

