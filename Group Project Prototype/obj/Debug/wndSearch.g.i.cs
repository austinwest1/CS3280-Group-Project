#pragma checksum "..\..\wndSearch.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "61A28D8786CC002100A30F64667CC1B8F22FE643893A5F7397EA5B6103C1AF40"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using groupProject;


namespace groupProject {
    
    
    /// <summary>
    /// wndSearch
    /// </summary>
    public partial class wndSearch : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\wndSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblStart;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\wndSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblEnd;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\wndSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dateStart;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\wndSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dateEnd;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\wndSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboNumber;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\wndSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboCharge;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\wndSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClearFilters;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\wndSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgrdInvoices;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\wndSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSelect;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\wndSearch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancel;
        
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
            System.Uri resourceLocater = new System.Uri("/Group Project Prototype;component/wndsearch.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\wndSearch.xaml"
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
            this.lblStart = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.lblEnd = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.dateStart = ((System.Windows.Controls.DatePicker)(target));
            
            #line 36 "..\..\wndSearch.xaml"
            this.dateStart.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.dateStart_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.dateEnd = ((System.Windows.Controls.DatePicker)(target));
            
            #line 37 "..\..\wndSearch.xaml"
            this.dateEnd.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.dateEnd_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cboNumber = ((System.Windows.Controls.ComboBox)(target));
            
            #line 44 "..\..\wndSearch.xaml"
            this.cboNumber.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cboNumber_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.cboCharge = ((System.Windows.Controls.ComboBox)(target));
            
            #line 45 "..\..\wndSearch.xaml"
            this.cboCharge.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cboCharge_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnClearFilters = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\wndSearch.xaml"
            this.btnClearFilters.Click += new System.Windows.RoutedEventHandler(this.btnClearFilters_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.dgrdInvoices = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 9:
            this.btnSelect = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\wndSearch.xaml"
            this.btnSelect.Click += new System.Windows.RoutedEventHandler(this.btnSelect_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\wndSearch.xaml"
            this.btnCancel.Click += new System.Windows.RoutedEventHandler(this.btnCancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

