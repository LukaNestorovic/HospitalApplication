﻿#pragma checksum "..\..\..\..\..\View\SecretaryView\ShowPatient.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D754FA91DF7B961A15EF4A06965940639A104ADD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ProjekatSIMS.View.SecretaryView;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace ProjekatSIMS.View.SecretaryView {
    
    
    /// <summary>
    /// ShowPatient
    /// </summary>
    public partial class ShowPatient : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\..\View\SecretaryView\ShowPatient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgDataBinding;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\..\View\SecretaryView\ShowPatient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateAccount;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\..\View\SecretaryView\ShowPatient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ShowAccount;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\..\View\SecretaryView\ShowPatient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditAccount;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\..\View\SecretaryView\ShowPatient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteAccount;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ProjekatSIMS;component/view/secretaryview/showpatient.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\SecretaryView\ShowPatient.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.dgDataBinding = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.CreateAccount = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\..\..\View\SecretaryView\ShowPatient.xaml"
            this.CreateAccount.Click += new System.Windows.RoutedEventHandler(this.CreateAccount_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ShowAccount = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\..\..\View\SecretaryView\ShowPatient.xaml"
            this.ShowAccount.Click += new System.Windows.RoutedEventHandler(this.ShowAccount_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.EditAccount = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\..\..\View\SecretaryView\ShowPatient.xaml"
            this.EditAccount.Click += new System.Windows.RoutedEventHandler(this.EditAccount_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.DeleteAccount = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\..\..\View\SecretaryView\ShowPatient.xaml"
            this.DeleteAccount.Click += new System.Windows.RoutedEventHandler(this.DeleteAccount_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

