﻿#pragma checksum "..\..\..\..\Other\Pages\FTP.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "014437D07B66CAD3F34E814384F025087E8FF45564BBBA443EE81DC7AB70B139"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using BuildServer.Other.Pages;
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


namespace BuildServer.Other.Pages {
    
    
    /// <summary>
    /// FTP
    /// </summary>
    public partial class FTP : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\Other\Pages\FTP.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbrootfoldet;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\Other\Pages\FTP.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btselectfolder;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\Other\Pages\FTP.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbnameroot;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\Other\Pages\FTP.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbport;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\Other\Pages\FTP.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbnameroot_Copy;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Other\Pages\FTP.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btselectcertificate;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\Other\Pages\FTP.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox tbnameroot_Copy1;
        
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
            System.Uri resourceLocater = new System.Uri("/BuildServer;component/other/pages/ftp.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Other\Pages\FTP.xaml"
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
            this.tbrootfoldet = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.btselectfolder = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\..\Other\Pages\FTP.xaml"
            this.btselectfolder.Click += new System.Windows.RoutedEventHandler(this.btselectfolder_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tbnameroot = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\..\..\Other\Pages\FTP.xaml"
            this.tbnameroot.SelectionChanged += new System.Windows.RoutedEventHandler(this.tbnameroot_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tbport = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\..\..\Other\Pages\FTP.xaml"
            this.tbport.SelectionChanged += new System.Windows.RoutedEventHandler(this.tbport_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 19 "..\..\..\..\Other\Pages\FTP.xaml"
            this.tbport.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbport_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tbnameroot_Copy = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\..\..\Other\Pages\FTP.xaml"
            this.tbnameroot_Copy.SelectionChanged += new System.Windows.RoutedEventHandler(this.tbnameroot_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btselectcertificate = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.tbnameroot_Copy1 = ((System.Windows.Controls.PasswordBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
