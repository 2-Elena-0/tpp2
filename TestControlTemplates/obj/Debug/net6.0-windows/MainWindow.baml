   M S B A M L   `   `   `  ����O  KTestControlTemplates, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:TestControlTemplatesTestControlTemplates  5   	   %    TestControlTemplates.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:TestControlTemplates     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	         
MyTemplate �� 
TargetType ��Name ��Name �� Triggers P� Property P� Value �� Property	 �� Value
 �� 
TargetName  SomeName  MyTemplateText ��Name��%�  &	        &	 �    &	 �    �� 5
   
   " ��6-   .R�5      �� $ MyBtn��6   $��2q�6$   
����  �$	��200��6J   $	��200��6W   $
��Left=�5      ._�5      �� $ ContName��6!   $��5q�63   $��Center=�6>   $��Center=�6[   
�������$��50(�5   4   $��Smile��6B   5       5      P� 5       �@J�IsMouseOver$
 true��61   . �5      ��  � ��$
	 Bold"�63   5      P� 5       � ��$
 true��6/   . �5      �� $
 MyBtn��6    � ��
	 �����6F   �� 5      $
 MyBtn��6    � ��
	 �� ��6G   �� 5      $
 ContName��6    � ��$	 Please��6F   �� 5      $
 ContName��6    � ��
	 �   �6I   �� 5      $
 ContName��6    � ��$	 Normal"�6I   5      5      �� 5   
   " ��6+   .R�5      �� $ MyBtn2��6   
��� ��$��5q�6>   
��� � �$	��200��6e   $	��200��6r   $��Right=�5      ._�5       �� $ 	ContName2��6!   $��5q�64   $��Center=�6?   $��Center=�6\   
�������$��50(�5!   4   $��Smile��6B   5"       5#      P� 5$       �@J�IsMouseOver$
 true��61   . �5%      ��  � ��$
	 Thin"�63   5&      P� 5'       � ��$
 true��6/   . �5(      �� $
 	ContName2��6    � ��$
	 No((��6G   �� 5)      $
 	ContName2��6    � ��
	 �����6J   �� 5*      $
 	ContName2��6    � ��$	 Normal"�6J   �� 5+      $
 MyBtn2��6    � ��
	 �ݠ��6G   �� 5,      $
 MyBtn2��6    � ��$	 0q�6L   5-      5/      �� 50   
   " ��61   .R�51      �� $ MyText��6   $��What?��6(   $��40(�65   $��Center=�6C   
���**��
���P��52       53      P� 54       �@J�IsMouseOver$
 true��61   . �55      �� $
 MyText��63    � ��
	 � ��6G   �� 56      $
 MyText��63    � ��
	 �   �6G   �� 57      $
 MyText��6-    � ��$	 	Is it... ��6A   �� 58       � ��$	 Light"�63   59      5<      5=      .��5>      � .+�5?   
   �� #��[ 6   �� 5@   
   #��[  6   
����� �68   �� 5A   
   #��[ 6   5B      5C      