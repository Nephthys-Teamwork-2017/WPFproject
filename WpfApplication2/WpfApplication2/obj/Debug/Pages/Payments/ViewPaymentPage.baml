   M S B A M L   `   `   `  ����J  FWpfApplication2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:WpfApplication2.Pages.PaymentsWpfApplication2.Pages.Payments  5      ? ;Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1$clr-namespace:Data.DTO;assembly=DataData.DTO 5      4    .WpfApplication2.Pages.Payments.ViewPaymentPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:WpfApplication2.Pages.Payments     5      4DTO$clr-namespace:Data.DTO;assembly=Data     5        N� Title$  ViewPaymentPage��5
       � 	Resources 5         paymentDTOViewSource��%   &	        �� 5   
   6   5      .��5      �  � DataContext# [  6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ paymentDTODataGrid��5   %      
IsReadOnly .    RowDetailsVisibilityMode$ VisibleWhenSelected=�6A      EnableRowVirtualization .    AutoGenerateColumns .  ��6p   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        agentNameColumn��,  &System.Windows.Controls.DataGridColumn	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 SizeToHeader 5   >   
   Header$
 
Agent Name��6S   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6g   �� *	AgentName+  5      -   5        blankNumberColumn��$	 SizeToHeader 5   @   $
 Blank Number��6U    6k   �� *BlankNumber+  5      -   5        companyNameColumn��$	 SizeToHeader 5   @   $
 Company Name��6U    6k   �� *CompanyName+4  .System.Windows.Controls.DataGridTemplateColumn  5      -   5        dateOfPaymentColumn��$	 SizeToHeader 5   F   $
 Date Of Payment��6[      CellTemplate 5      �� 5      .R�5      (  "System.Windows.Controls.DatePicker     SelectedDate 6)   �� *DateOfPayment+ �� Mode$ TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . 5      5        5      -   5        dueDateColumn��$	 SizeToHeader 5   @   $
 Due Date��6U    5      �� 5       .R�5!         6)   �� *	DueDate+$ TwoWay=� .  . 5"      5$        5%      -   5        finalPriceColumn��$	 SizeToHeader 5%   ?   $
 Final Price��6T    6i   �� *
FinalPrice+  5&      -   5        idColumn��$	 SizeToHeader 5&   7   $
 Id��6L    6X   �� *Id+  5'      -	   5        policyNumberColumn��$	 SizeToHeader 5'   A   $
 Policy Number��6V    6m   �� *PolicyNumber+  5(      -
   5        premiumColumn��$	 SizeToHeader 5(   <   $
 Premium��6Q    6b   �� *	Premium+  5)      -   5        priceColumn��$	 SizeToHeader 5)   :   $
 Price��6O    6^   �� *Price+  5*      -   5        statusColumn��$	 SizeToHeader 5*   ;   $
 Status��6P    6`   �� *Status+  5+      -   5        	taxColumn��$	 SizeToHeader 5+   8   $	
 Tax��6M    6Z   �� *Tax+5-      5/      50      