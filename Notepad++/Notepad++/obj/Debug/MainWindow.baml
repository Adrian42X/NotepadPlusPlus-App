   M S B A M L   `   `   `  ����D  @Notepad++, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Notepad__	Notepad__  5   	       Notepad__.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Notepad__     5   	     � Title$  	Notepad++��5   	   $	��450��6   $	��800��6(    � Icon$ icon.ico��64   $��Stretch=�6D   $��Stretch=�6b    � 
ResizeMode$ CanResizeWithGrip=�5	   	    � WindowStartupLocation$ CenterScreen=�6(   .��5      ]� .+�5   
   o� $	��Top=�6   .@�5      m� $��_File��6   .@�5      m� -   5         m�Name$ 	NewButton��5      $
��New ��6.   6=   m� 5      -   5        $ 
OpenButton��5      $��_Open...��6/   6B   m� 5      -   5        $ 
SaveButton��5      $��_Save��6/   6>   m� 5      -   5        $ SaveAsButton��5      $��_Save As...��61   6F   �� 5      m� 5      -   5        $ 
ExitButton��5      $��_Exit��6/   6>   5      m� 5      $��_Search��6   .@�5      m� -   5        $ 
FindButton��5      $��_Find...��6/   6A   m� 5      -   5        $ ReplaceButton��5      $��_Replace...��62   6G   m� 5      -   5        $ ReplaceAllButton��5      $��_Replace All...��65   6N   5      m� 5      $��_Help��6   .@�5      m� -	   5        $ AboutButton��5      $��	_About...��60   6C   �� 5      $
��Wrap=�6   $��19��60   $	��144��6<   �� 6I   $�Adresa institutionala ��6M   �� 6m   -
   5        $(��"https://student.unitbv.ro/surgeweb?�5   w   .�6�   �� $�Email��6�   6�   6�   5       5"      �� 5$   
   -   5        $��
tabDynamic��5$      $��0,5.4,-0.2,0q�6@   ��6'   ��  � 	Resources 5%         	TabHeader �� DataType �� RelativeSource �� AncestorType	 �� Path
 �� 
TargetType �� Property �� Value��%�  &	        '�� j    �� 5&      $ TabItem��61   .R�5'      ]� .+�5(      �� $��	btnDelete��6!   -   5        $��Right=�5(   2   $��5,0,0,0q�6I   $��0q�6Z   ��6~   ��  �� " ��$
	 Name�.��5)      �� $��/deleteicon.png��6$   $��11��6=   $��11��6I   6V   5*      �� 5+      ��6$   ��  �� $ TabItemL�$	 Header�5,      5-      �� 5.      "
 ��6   .�5/      ��  � ��$ Stretch=�6:   6L   �� 50       � ��$ Stretch=�6<   6N   �� 51       �@��AcceptsReturn . 6E   �� 52       �@��TextWrapping$ WrapWithOverflow=�65   6P   �� 53       �@��MaxLines$
 5000��61   6@   �� 54       � ��$
 Auto=�6Q   6`   �� 55       � ��$
 Auto=�6S   6b   56      57      58      5:      5<      