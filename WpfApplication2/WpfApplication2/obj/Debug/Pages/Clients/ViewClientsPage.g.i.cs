﻿#pragma checksum "..\..\..\..\Pages\Clients\ViewClientsPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "ABE1F6A586DCEDD4D90C820F5CB0FA48"
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
using WpfApplication2.Pages.Clients;


namespace WpfApplication2.Pages.Clients {
    
    
    /// <summary>
    /// ViewClientsPage
    /// </summary>
    public partial class ViewClientsPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\..\Pages\Clients\ViewClientsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid customerDTODataGrid;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\Pages\Clients\ViewClientsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn idColumn;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Pages\Clients\ViewClientsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn nameColumn;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\Pages\Clients\ViewClientsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn addressColumn;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Pages\Clients\ViewClientsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn emailColumn;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Pages\Clients\ViewClientsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn notesColumn;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\Pages\Clients\ViewClientsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn phoneColumn;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Pages\Clients\ViewClientsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn statePersonalNumberColumn;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApplication2;component/pages/clients/viewclientspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Clients\ViewClientsPage.xaml"
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
            this.customerDTODataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 24 "..\..\..\..\Pages\Clients\ViewClientsPage.xaml"
            this.customerDTODataGrid.RowEditEnding += new System.EventHandler<System.Windows.Controls.DataGridRowEditEndingEventArgs>(this.CustomerDataGrid_RowEditEnding);
            
            #line default
            #line hidden
            
            #line 25 "..\..\..\..\Pages\Clients\ViewClientsPage.xaml"
            this.customerDTODataGrid.AddingNewItem += new System.EventHandler<System.Windows.Controls.AddingNewItemEventArgs>(this.CustomerDataGrid_AddingNewItem);
            
            #line default
            #line hidden
            
            #line 26 "..\..\..\..\Pages\Clients\ViewClientsPage.xaml"
            this.customerDTODataGrid.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.CustomerDataGrid_PreviewKeyDown);
            
            #line default
            #line hidden
            
            #line 27 "..\..\..\..\Pages\Clients\ViewClientsPage.xaml"
            this.customerDTODataGrid.BeginningEdit += new System.EventHandler<System.Windows.Controls.DataGridBeginningEditEventArgs>(this.CustomerDataGrid_BeginningEdit);
            
            #line default
            #line hidden
            return;
            case 2:
            this.idColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 3:
            this.nameColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 4:
            this.addressColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 5:
            this.emailColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 6:
            this.notesColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 7:
            this.phoneColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 8:
            this.statePersonalNumberColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

