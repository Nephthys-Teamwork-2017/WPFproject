   M S B A M L   `   `   `  ����p  lSystem.Windows.Controls.Input.Toolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35pTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.ToolkitSystem.Windows.Controls  5      J FWpfApplication2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:WpfApplication2.Pages.BlanksWpfApplication2.Pages.Blanks 5      /   )WpfApplication2.Pages.Blanks.AddBlankPage   5      `toolkitTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.Toolkit  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:WpfApplication2.Pages.Blanks     5        N� Title$  AddBlankPage��5
      .��5      � 
�������$��
0,0,-125,0q�6"   .+�5   
   �� -   5         ��Name$ label��5      $��BlankNumber��6   $
��Left=�65   $��	10,10,0,0q�6P   $	��Top=�6c   �� 5   
   -   5        $ label1��5      $��Product��6    $
��Left=�62   $��	35,79,0,0q�6M   $	��Top=�6`   �� 5   
   -   5        $ label2��5      $��Status��6    $
��Left=�61   $��248,113,0,0q�6L   $	��Top=�6a   �� 5   
   -   5        $ label3��5      $��Agent��6    $
��Left=�60   $��
44,113,0,0q�6K   $	��Top=�6_   �� 5   
   -   5        $ label4��5      $��	TakenDate��6    $
��Left=�64   $��
224,10,0,0q�6O   $	��Top=�6c   �� 5   
   -   5        $ label5��5      $��	IssueDate��6    $
��Left=�64   $��
229,41,0,0q�6O   $	��Top=�6c   �� 5   
   -   5        $ label6��5      $��PolicyNumber��6    $
��Left=�67   $��
224,79,0,0q�6R   $	��Top=�6f   �� 5   
   -   5        $ label7��5      $��Company��6    $
��Left=�62   $��	25,44,0,0q�6M   $	��Top=�6`   �� 5   
   -	   5         ��Name$ BlankNumberTextBox��5      $
��Left=�6.   $��23��6I   $��	97,10,0,0q�6U    �� TextWrapping$
 Wrap=�6h   $	��Top=�6|   $	��120��6�   �� 5   
   -
   5         ��Name$ CompanyComboBox��5   4   $
��Left=�6M   $��	97,45,0,0q�6h   $	��Top=�6{   $	��120��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ TakenDatePicker��5      $
��Left=�6.   $��
305,12,0,0q�6I   $	��Top=�6]     5   
   -   5        $ IssueDatePicker��5      $
��Left=�6.   $��
305,45,0,0q�6I   $	��Top=�6]   �� 5   
   -   5        $ AgentComboBox��5      $
��Left=�6*   $��
97,117,0,0q�6E   $	��Top=�6Y   $	��120��6q   �� 5   
   -   5        $ ProductComboBox��5      $
��Left=�6,   $��	97,83,0,0q�6G   $	��Top=�6Z   $	��120��6r   �� 5   
   -   5         ��Name$ AddBlankButton��5      $��	Add Blank��6)   $
��Left=�6=   $��160,170,0,0q�6X   $	��Top=�6m   $	��149��6�   $��35��6�   6�   -   'System.Windows.Controls.AutoCompleteBox  5   
   -   5          Name$ PolicyNumberTextBox��5         
FilterMode$ ContainsOrdinal=�5      	   ValueMemberPath$	  ��5       $��305,79,0,195q�6   $
��Left=�6.   $	��102��6I   �� 5"   
   -   5        $ StatusComboBox��5"      $
��Left=�6+   $��305,117,0,0q�6F   $	��Top=�6[   $	��102��6s   5$      5%      