   M S B A M L   `   `   `  ����p  lSystem.Windows.Controls.Input.Toolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35pTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.ToolkitSystem.Windows.Controls  5      J FWpfApplication2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:WpfApplication2.Pages.PaymentsWpfApplication2.Pages.Payments 5      3   -WpfApplication2.Pages.Payments.AddPaymentPage   5      `toolkitTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.Toolkit  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:WpfApplication2.Pages.Payments     5        N� Title$  AddPaymentPage��5      .��5      � 
�������$��
0,0,-550,0q�6"   .+�5   
   (  "System.Windows.Controls.DatePicker  -   5          Name$ DateOfPaymentPicker��5      $
��Left=�62   $��
108,18,0,0q�6M   $	��Top=�6a   �� 5   
   -   5         ��Name$ label��5      $��Date of Payment��6   $
��Left=�69   $��	10,16,0,0q�6T   $	��Top=�6g   �� 5   
   -   5        $ label1��5      $��Due Date��6    $
��Left=�63   $��	35,50,0,0q�6N   $	��Top=�6a     5   
   -   5        $ DueDatePicker��5      $
��Left=�6,   $��
108,50,0,0q�6G   $	��Top=�6[   �� 5   
   -   5        $ label2��5      $��PolicyNumber��6    $
��Left=�67   $��	18,92,0,0q�6R   $	��Top=�6e   �� 5   
   -   5        $ label3��5      $��Premium��6    $
��Left=�62   $��
35,130,0,0q�6M   $	��Top=�6a   �� 5   
   -   5        $ label4��5      $	��Tax��6    $
��Left=�6.   $��
37,174,0,0q�6I   $	��Top=�6]   �� 5   
   -   5         ��Name$ 
TaxTextBox��5      $
��Left=�6&   $��23��6A   $��108,174,0,0q�6M    �� TextWrapping$
 Wrap=�6b   $	��Top=�6v   $	��102��6�   �� 5   
   -	   5        $ label5��5      $��Price��6    $
��Left=�60   $��
37,214,0,0q�6K   $	��Top=�6_   �� 5   
   -
   5        $ label6��5      $��
FinalPrice��6    $
��Left=�65   $��
270,17,0,0q�6P   $	��Top=�6d    J� RenderTransformOrigin$ 0.417,-0.538&�6|   �� 5   
   -   5        $ label7��5      $��Status��6    $
��Left=�61   $��
288,50,0,0q�6L   $	��Top=�6`   �� 5   
   -   5        $ PremiumTextBox��5      $
��Left=�6*   $��23��6E   $��108,133,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6z   $	��102��6�   �� 5   
   -   5        $ PriceTextBox��5      $
��Left=�6(   $��26��6C   $��108,214,0,0q�6O   $
 Wrap=�6d   $	��Top=�6x   $	��102��6�   -   'System.Windows.Controls.AutoCompleteBox  5   
   -   5          Name$ PolicyNumberTextBox��5         
FilterMode$ ContainsOrdinal=�5         ValueMemberPath$  ��5      $��108,92,0,182q�6   $
��Left=�6.   $	��102��6I   �� 5!   
   -   5        $ FinalPriceTextBox��5!      $
��Left=�6-   $��23��6H   $��
355,19,0,0q�6T   $
 Wrap=�6h   $	��Top=�6|   $	��120��6�   �� 5"   
   -   5        	 ��Name$	 AgentComboBox��5"      $
��Left=�6*   $��
355,96,0,0q�6E   $	��Top=�6Y   $	��120��6q   �� 5#   
   -   5        $ label8��5#      $��Agent��6    $
��Left=�60   $��
288,96,0,0q�6K   $	��Top=�6_   �� 5$   
   -   5        
 ��Name$
 checkBox��5$   I   $��Blank��6[   $
��Left=�6k   $��355,141,0,0q�6�   $	��Top=�6�   �� 5%   
   -   5        $ label9��5%      $��Blank Number��6    $
��Left=�67   $��255,174,0,0q�6R   $	��Top=�6g     5&   
   -   5        $ BlankNumberTextBox��5'      $ ContainsOrdinal=�5(      {�.  $  ��5*      $��355,171,0,103q�6   $
��Left=�6/   $	��120��6J   �� 5,   
   -   5        $	 CompanyComboBox��5,      $
��Left=�6,   $��355,214,0,0q�6G   $	��Top=�6\   $	��120��6t   �� 5-   
   -   5        $ label10��5-      $��Company��6!   $
��Left=�63   $��270,214,0,0q�6N   $	��Top=�6c   �� 5.   
   -   5         ��Name$ 	AddButton��5.      $��Add Payment��6$   $
��Left=�6:   $��225,245,0,0q�6U   $	��Top=�6j   $��95��6�   $��35��6�   6�   �� 5/   
   -   5        $	 StatusComboBox��5/      $
��Left=�6+   $��
355,52,0,0q�6F   $	��Top=�6Z   $	��120��6r   50      51      