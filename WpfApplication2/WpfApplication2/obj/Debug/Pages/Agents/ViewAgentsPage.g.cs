﻿#pragma checksum "..\..\..\..\Pages\Agents\ViewAgentsPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "66EFDF7B2DBA1A51C0C0877EF842277F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Data.DTO;
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
using WpfApplication2.Pages.Agents;


namespace WpfApplication2.Pages.Agents {
    
    
    /// <summary>
    /// ViewAgentsPage
    /// </summary>
    public partial class ViewAgentsPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\..\Pages\Agents\ViewAgentsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid agentDTODataGrid;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\Pages\Agents\ViewAgentsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn idColumn;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\Pages\Agents\ViewAgentsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn codeColumn;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\Pages\Agents\ViewAgentsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn emailColumn;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Pages\Agents\ViewAgentsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn nameColumn;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Pages\Agents\ViewAgentsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn phoneColumn;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApplication2;component/pages/agents/viewagentspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Agents\ViewAgentsPage.xaml"
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
            this.agentDTODataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.idColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 3:
            this.codeColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 4:
            this.emailColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 5:
            this.nameColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 6:
            this.phoneColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

