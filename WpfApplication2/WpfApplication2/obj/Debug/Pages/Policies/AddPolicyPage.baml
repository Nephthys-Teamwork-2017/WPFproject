   M S B A M L   `   `   `  ����p  lSystem.Windows.Controls.Input.Toolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35pTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.ToolkitSystem.Windows.Controls  5      J FWpfApplication2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:WpfApplication2.Pages.PoliciesWpfApplication2.Pages.Policies 5      2   ,WpfApplication2.Pages.Policies.AddPolicyPage   5      `toolkitTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.Toolkit  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:WpfApplication2.Pages.Policies     5        N� Title$  AddPolicyPage��5
      .��5      � 
�������$��0,0,-345,10q�6"   .+�5   
   �� -   5         ��Name$ PolicyNumberLabel��5      $��Policy Number��6+   $
��Left=�6C   $��	10,10,0,0q�6^   $	��Top=�6q   �� 5   
   -   5         ��Name$ PolicyNumberTextBox��5      $
��Left=�6/   $��23��6J   $��
110,10,0,0q�6V    �� TextWrapping$
 Wrap=�6j   $�� ��6~   $	��Top=�6�   $	��120��6�   �� 5   
   -   5         ��Name$ CompaniesComboBox��5   3   $
��Left=�6N   $��
110,44,0,0q�6i   $	��Top=�6}   $	��120��6�   �� 5   
   -   5        $ CompanyLabel��5      $��Company��6&   $
��Left=�68   $��	30,44,0,0q�6S   $	��Top=�6f   �� 5   
   -   5        $ ProductsComboBox��5      $
��Left=�6-   $��
110,80,0,0q�6H   $	��Top=�6\   $	��120��6t   �� 5   
   -   5        $ ProductLabel��5      $��Product��6&   $
��Left=�68   $��	30,80,0,0q�6S   $	��Top=�6f   $��74��6~   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ issueDatePicker��5      $
��Left=�6.   $��
385,10,0,0q�6I   $	��Top=�6]     5   
   -   5        $ startDatePicker��5      $
��Left=�6.   $��
385,44,0,0q�6I   $	��Top=�6]     5   
   -	   5        $ endDatePicker��5      $
��Left=�6,   $��
385,78,0,0q�6G   $	��Top=�6[   �� 5   
   -
   5        $ 	IssueDate��5      $��	IssueDate��6#   $
��Left=�67   $��
302,13,0,0q�6R   $	��Top=�6f   �� 5   
   -   5        $ startDateLabel��5      $��	StartDate��6(   $
��Left=�6<   $��
303,44,0,0q�6W   $	��Top=�6k   �� 5   
   -   5        $ EndDateLabel��5      $��EndDate��6&   $
��Left=�68   $��
302,78,0,0q�6S   $	��Top=�6g   -   'System.Windows.Controls.AutoCompleteBox  5   
   -   5        $��EGNClientName��5         
FilterMode$ ContainsOrdinal=�5         ValueMemberPath$  ��5      $��385,119,0,151q�6   $
��Left=�6/   $	��102��6J   �� 5    
   -   5        $ CustomerEGN��5       $��Customers' EGN��6%   $
��Left=�6>   $��266,116,0,0q�6Y   $	��Top=�6n   $	��115��6�   �� 5!   
   -   5        $ InsuredLabel��5!      $��InsuredName��6&   $
��Left=�6<   $��266,157,0,0q�6W   $	��Top=�6l   $��95��6�     5"   
   -   5          Name$ InsuredName��5#      $ ContainsOrdinal=�5$      $  ��5'      $��385,157,0,113q�6    $
��Left=�67   $	��102��6R   �� 5)   
   -   5        $ 
AgentLabel��5)      $��Agent��6$   $
��Left=�64   $��302,194,0,0q�6O   $	��Top=�6d   �� 5*   
   -   5        $ AgentComboBox��5*      $
��Left=�6*   $��385,194,0,0q�6E   $	��Top=�6Z   $	��102��6r   �� 5+   
   -   5        $ PremiumTextBox��5+      $
��Left=�6*   $��23��6E   $��110,116,0,0q�6Q   $
 Wrap=�6f   $�� ��6z   $	��Top=�6�   $	��120��6�   �� 5,   
   -   5        $ label��5,      $��Premium��6   $
��Left=�61   $��
33,116,0,0q�6L   $	��Top=�6`   �� 5-   
   -   5        $ 
TaxTextBox��5-      $
��Left=�6&   $��23��6A   $��110,157,0,0q�6M   $
 Wrap=�6b   $	��Top=�6v   $	��120��6�   �� 5.   
   -   5        $ TaxLabel��5.      $	��Tax��6"   $
��Left=�60   $��
47,160,0,0q�6K   $	��Top=�6_   �� 5/   
   -   5        $ label1��5/      $��Price��6    $
��Left=�60   $��
37,197,0,0q�6K   $	��Top=�6_   �� 50   
   -   5        $ PriceTextBox��50      $
��Left=�6(   $��23��6C   $��110,197,0,0q�6O   $
 Wrap=�6d   $	��Top=�6x   $	��120��6�   �� 51   
   -   5        $ 	NoteLabel��51      $��Notes��6#   $
��Left=�63   $��	505,9,0,0q�6N   $	��Top=�6a   $��75��6y   �� 52   
   -   5        $ NotesTextBox��52      $
��Left=�6(   $	��167��6C   $��	550,9,0,0q�6P   $
 Wrap=�6c   $	��Top=�6w   $��85��6�   �� 53   
   -   5        $ StatusComboBox��53      $
��Left=�6+   $��550,194,0,0q�6F   $	��Top=�6[   $��85��6s   �� 54   
   -   5        $ label2��54      $��Status��6    $
��Left=�61   $��505,194,0,0q�6L   $	��Top=�6a   �� 55   
   -   5        	 ��Name$	 AddPolicyButton��55      $��
Add Policy��6*   $
��Left=�6?   $��40��6Z   $��240,240,0,0q�6f   $	��Top=�6{   $	��175��6�   6�   56      57      