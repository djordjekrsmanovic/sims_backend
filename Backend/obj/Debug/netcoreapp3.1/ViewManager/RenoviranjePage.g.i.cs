#pragma checksum "..\..\..\..\ViewManager\RenoviranjePage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22848BEF5212FAE676A30F51A32CD5BCCE8B60C0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SIMS.UpravnikGUI;
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


namespace SIMS.UpravnikGUI {
    
    
    /// <summary>
    /// RenoviranjePage
    /// </summary>
    public partial class RenoviranjePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\..\ViewManager\RenoviranjePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker Pocetak;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\ViewManager\RenoviranjePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker Kraj;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\ViewManager\RenoviranjePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton NotMerge;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\ViewManager\RenoviranjePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton MergeInto;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\ViewManager\RenoviranjePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label RoomNumberLabel;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\ViewManager\RenoviranjePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RoomNumberTextBox;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\ViewManager\RenoviranjePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton NewRoom;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\ViewManager\RenoviranjePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Odustani;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\ViewManager\RenoviranjePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Otkaz;
        
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
            System.Uri resourceLocater = new System.Uri("/SIMS;component/viewmanager/renoviranjepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\ViewManager\RenoviranjePage.xaml"
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
            this.Pocetak = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 2:
            this.Kraj = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 3:
            this.NotMerge = ((System.Windows.Controls.RadioButton)(target));
            
            #line 19 "..\..\..\..\ViewManager\RenoviranjePage.xaml"
            this.NotMerge.Click += new System.Windows.RoutedEventHandler(this.NotMerge_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MergeInto = ((System.Windows.Controls.RadioButton)(target));
            
            #line 23 "..\..\..\..\ViewManager\RenoviranjePage.xaml"
            this.MergeInto.Click += new System.Windows.RoutedEventHandler(this.MergeInto_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.RoomNumberLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.RoomNumberTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.NewRoom = ((System.Windows.Controls.RadioButton)(target));
            
            #line 29 "..\..\..\..\ViewManager\RenoviranjePage.xaml"
            this.NewRoom.Click += new System.Windows.RoutedEventHandler(this.New_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Odustani = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\..\ViewManager\RenoviranjePage.xaml"
            this.Odustani.Click += new System.Windows.RoutedEventHandler(this.Odustani_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 34 "..\..\..\..\ViewManager\RenoviranjePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Ok_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Otkaz = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\..\ViewManager\RenoviranjePage.xaml"
            this.Otkaz.Click += new System.Windows.RoutedEventHandler(this.Otkaz_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

