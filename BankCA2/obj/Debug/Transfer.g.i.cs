﻿#pragma checksum "..\..\Transfer.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "33C7F63849187F70DD75A097FC9BB3D2188095B1B8135E50DFD807CBEB6384D4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BankCA2;
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


namespace BankCA2 {
    
    
    /// <summary>
    /// Transfer
    /// </summary>
    public partial class Transfer : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\Transfer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbofrom;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Transfer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboto;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Transfer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtfn;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Transfer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtsn;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Transfer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtaccnofrom;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Transfer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtname;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Transfer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtaccnoto;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Transfer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtsortcode;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Transfer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtdes;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\Transfer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtamount;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\Transfer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btntransfer;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\Transfer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbal;
        
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
            System.Uri resourceLocater = new System.Uri("/BankCA2;component/transfer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Transfer.xaml"
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
            this.cbofrom = ((System.Windows.Controls.ComboBox)(target));
            
            #line 12 "..\..\Transfer.xaml"
            this.cbofrom.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbofrom_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cboto = ((System.Windows.Controls.ComboBox)(target));
            
            #line 22 "..\..\Transfer.xaml"
            this.cboto.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cboto_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtfn = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtsn = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtaccnofrom = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtaccnoto = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.txtsortcode = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.txtdes = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.txtamount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.btntransfer = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\Transfer.xaml"
            this.btntransfer.Click += new System.Windows.RoutedEventHandler(this.btntransfer_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.txtbal = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

