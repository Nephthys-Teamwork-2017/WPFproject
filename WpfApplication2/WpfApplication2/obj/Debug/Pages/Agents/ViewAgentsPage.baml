   M S B A M L   `   `   `  ����J  FWpfApplication2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:WpfApplication2.Pages.AgentsWpfApplication2.Pages.Agents  5      ? ;Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1$clr-namespace:Data.DTO;assembly=DataData.DTO 5      1    +WpfApplication2.Pages.Agents.ViewAgentsPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:WpfApplication2.Pages.Agents     5      4DTO$clr-namespace:Data.DTO;assembly=Data     5        N� Title$  ViewAgentsPage��5
       � 	Resources 5         agentDTOViewSource��%   &	        �� 5   
   6   5      .��5      �  � DataContext# [  6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ agentDTODataGrid��5         RowDetailsVisibilityMode$ VisibleWhenSelected=�6-   $��
0,0,-100,0q�6\      EnableRowVirtualization .    AutoGenerateColumns .  ��6p   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        idColumn��,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 5   7   	   Header$	 Id��6L   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6X   �� *Id+  5      -   5        
codeColumn��$ SizeToHeader 5   9   $
	 Code��6N   
 6\   �� *Code+  5      -   5        emailColumn��$ SizeToHeader 5   :   $	 Email��6O   
 6^   �� *Email+  5      -   5        
nameColumn��$ SizeToHeader 5   9   $
	 Name��6N   
 6\   �� *Name+  5      -   5        phoneColumn��$ SizeToHeader 5   :   $	 Phone��6O   
 6^   �� *Phone+5      5      5      