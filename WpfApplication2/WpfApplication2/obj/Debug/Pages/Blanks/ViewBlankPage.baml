   M S B A M L   `   `   `  ����J  FWpfApplication2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:WpfApplication2.Pages.BlanksWpfApplication2.Pages.Blanks  5      ? ;Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1$clr-namespace:Data.DTO;assembly=DataData.DTO 5      0    *WpfApplication2.Pages.Blanks.ViewBlankPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:WpfApplication2.Pages.Blanks     5      4DTO$clr-namespace:Data.DTO;assembly=Data     5        N� Title$  ViewBlankPage��5
       � 	Resources 5         blankDTOViewSource��%   &	        �� 5   
   6   5      .��5      �  � DataContext# [  6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ blankDTODataGrid��5   %      
IsReadOnly .    RowDetailsVisibilityMode$ VisibleWhenSelected=�6?      EnableRowVirtualization .    AutoGenerateColumns .  ��6n   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        agentNameColumn��,  &System.Windows.Controls.DataGridColumn	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 SizeToHeader 5   >   
   Header$
 
Agent Name��6S   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6g   �� *	AgentName+  5      -   5        companyNameColumn��$	 SizeToHeader 5   @   $
 Company Name��6U    6k   �� *CompanyName+  5      -   5        idColumn��$	 SizeToHeader 5   7   $
 Id��6L    6X   �� *Id+4  .System.Windows.Controls.DataGridTemplateColumn  5      -   5        issueDateColumn��$	 SizeToHeader 5   B   $
 
Issue Date��6W      CellTemplate 5      �� 5      .R�5      (  "System.Windows.Controls.DatePicker     SelectedDate 6)   �� *	IssueDate+ �� Mode$ TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . 5      5        5      -   5        numberColumn��$	 SizeToHeader 5   ;   $
 Number��6P    6`   �� *Number+  5      -   5        policyNumberColumn��$	 SizeToHeader 5   A   $
 Policy Number��6V    6m   �� *PolicyNumber+  5       -   5        productIdColumn��$	 SizeToHeader 5    >   $
 
Product Id��6S    6g   �� *	ProductId+  5!      -	   5        productNameColumn��$	 SizeToHeader 5!   @   $
 Product Name��6U    6k   �� *ProductName+  5"      -
   5        statusColumn��$	 SizeToHeader 5"   ;   $
 Status��6P    6`   �� *Status+  5#      -   5        takenDateColumn��$	 SizeToHeader 5#   B   $
 
Taken Date��6W    5$      �� 5%      .R�5&         6)   �� *	TakenDate+$ TwoWay=� .  . 5'      5)      5+      5-      5.      