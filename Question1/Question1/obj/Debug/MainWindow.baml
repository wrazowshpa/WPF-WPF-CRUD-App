   M S B A M L   `   `   `  ����D  @Question1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Question1	Question1  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	       Question1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Question1     5   	   9System&clr-namespace:System;assembly=mscorlib     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)   .��5
      � .+�5   
   �� -   5         ��Name$ ElectronicsComboBox��5       �� SelectedValuePath$ Content��60   $
��Left=�6L   $��170,107,0,0q�6g   $	��Top=�6|   $	��120��6�   .@�5      �� $
��iPad��6   �� 5      $��	Earphones��6   �� 5      $��Phone��6   5      �� 5   
   -   5        $ BooksComboBox��5      $ Content��6*   $
��Left=�6F   $��170,155,0,0q�6a   $	��Top=�6v   $	��120��6�    J� RenderTransformOrigin$ -0.125,-0.079&�6�   .@�5      �� $��Harry Potter��6   �� 5      $��Lord of the Rings��6   �� 5      $��Eragon��6   5      �� 5   
   -   5        $ JewelryComboBox��5      $ Content��6,   $
��Left=�6H   $��170,202,0,0q�6c   $	��Top=�6x   $	��120��6�   .@�5      �� $
��Ring��6   �� 5      $��Necklace��6   �� 5      $��Earring��6   5      �� 5   
   -   5        $ ToysComboBox��5      $ Content��6)   $
��Left=�6E   $��170,251,0,0q�6`   $	��Top=�6u   $	��120��6�   .@�5      �� $��Barbie��6   �� 5      $��Power Ranger��6   �� 5      $
��Lego��6   5       �� 5#   
   $��Electronics:��6   $
��Left=�6'   $��
54,103,0,0q�6B   $	��Top=�6V   �� 5$   
   $��Jewelry:��6   $
��Left=�6#   $��
54,198,0,0q�6>   $	��Top=�6R   �� 5%   
   $��Books:��6   $
��Left=�6!   $��
54,151,0,0q�6<   $	��Top=�6P   �� 5&   
   $��Toys:��6   $
��Left=�6    $��
54,251,0,0q�6;   $	��Top=�6O   �� 5'   
   $��Category��6   $
��Left=�6#   $��	54,59,0,0q�6>   $	��Top=�6Q   $
��Bold"�6i   �� 5(   
   $
��Name��6   $
��Left=�6   $��
203,59,0,0q�6:   $	��Top=�6N   $
��Bold"�6f   �� 5)   
   -   5         ��Name$ 	clearBill��5)      $��
Clear Bill��6$   $
��Left=�69   $��420,308,0,0q�6T   $	��Top=�6i   $��75��6�   6�   �� 5*   
   $��	HST(13%):��6   $
��Left=�6$   $��520,307,0,0q�6?   $	��Top=�6T   �� 5+   
   $��TOTAL��6   $
��Left=�6    $��582,364,0,0q�6;   $	��Top=�6P   $
��Bold"�6h   �� 5,   
   $
��Left=�6   $	��100��6+   $��170,290,0,0q�68   $	��Top=�6M   $	��103��6e   ��5-      �� 5.       �� 	UriSource$ cetennialcollegelogo.png?�6   50      �� 51   
   -   5         ��Name$ 	statusBar��51      $
��Left=�6'   $��28��6B   $��0,395,0,-0.2q�6N   $	��Top=�6d   $	��795��6|    � Cursor$  ��6�   .@�52      �� $��2��6   .��53      �� $��Mansoor Mehraban��6   54      �� 55      -   5        ��56      �� 57      $ cetennialcollegelogo.png?�6"   5:      ]� 5;      $��Stretch=�6   $��Stretch=�66   .+�5<      (  "System.Windows.Controls.WebBrowser  -   5          Name$ Browser��5<      5=      5>      �� 5?   
   -	   5        	 ��Name$	 listbox1��5?      $
��Left=�6$   $	��166��6?   $��420,103,0,0q�6L   $	��Top=�6a   $	��319��6y   
 � DataContext
 5@        Question1.Electronics  5A      5C      �� 5D   
   -
   5         ��Name$ subtotalTextBox��5D      $
��Left=�6+   $��23��6F   $��670,311,0,0q�6R    �� TextWrapping$
 Wrap=�6g   $��0��6{   $	��Top=�6�   $��69��6�   �� 5E   
   -   5        $ 
taxTextBox��5E      $
��Left=�6&   $��23��6A   $��589,311,0,0q�6M   $
 Wrap=�6b   $��0��6v   $	��Top=�6   $��53��6�   �� 5F   
   -   5        $ totalTextBox��5F      $
��Left=�6(   $��23��6C   $��669,364,0,0q�6O   $
 Wrap=�6d   $��0��6x   $	��Top=�6�   $��70��6�   �� 5G   
   $
��Left=�6   $��
268,10,0,0q�6/   $
��Wrap=�6C   $��Store Invoice Calculator��6W   $	��Top=�6w   $��39��6�   $	��280��6�   $��Segoe Print)�6�   $
��Bold"�6�   $��20(�6�   5K      5L      