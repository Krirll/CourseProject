﻿#pragma checksum "..\..\WindowChoise.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CD5C1CF23419F91A6A50781D81D5EFA700CF803C295B5A8A350A186BA3A7D31E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using CourseProject;
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


namespace CourseProject {
    
    
    /// <summary>
    /// WindowChoise
    /// </summary>
    public partial class WindowChoise : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\WindowChoise.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton common;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\WindowChoise.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton worker;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\WindowChoise.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passAdmin;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\WindowChoise.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passWorker;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\WindowChoise.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label_admin;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\WindowChoise.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label_worker;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\WindowChoise.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Continue;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\WindowChoise.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Exit;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\WindowChoise.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton admin;
        
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
            System.Uri resourceLocater = new System.Uri("/CourseProject;component/windowchoise.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WindowChoise.xaml"
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
            this.common = ((System.Windows.Controls.RadioButton)(target));
            
            #line 19 "..\..\WindowChoise.xaml"
            this.common.Checked += new System.Windows.RoutedEventHandler(this.common_Checked);
            
            #line default
            #line hidden
            return;
            case 2:
            this.worker = ((System.Windows.Controls.RadioButton)(target));
            
            #line 20 "..\..\WindowChoise.xaml"
            this.worker.Checked += new System.Windows.RoutedEventHandler(this.worker_Checked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.passAdmin = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 4:
            this.passWorker = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 5:
            this.label_admin = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.label_worker = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.Continue = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\WindowChoise.xaml"
            this.Continue.Click += new System.Windows.RoutedEventHandler(this.Continue_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Exit = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\WindowChoise.xaml"
            this.Exit.Click += new System.Windows.RoutedEventHandler(this.Exit_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.admin = ((System.Windows.Controls.RadioButton)(target));
            
            #line 27 "..\..\WindowChoise.xaml"
            this.admin.Checked += new System.Windows.RoutedEventHandler(this.admin_Checked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
