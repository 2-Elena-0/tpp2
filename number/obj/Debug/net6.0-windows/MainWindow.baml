   M S B A M L   `   `   `  ����A  =number, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:numbernumber  5   	       number.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:number     5   	     � Title$  
MainWindow��5   	   $	��250��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� -   5         ��Name$ L1��5      $��Center=�6   $��30(�69   $��0��6G   ]� 5   
   $��1��6   $��Center=�6!   .+�5      �� $��20(�6   $
��Left=�6"   .��6=   Введите число:6M   �� 5      -   5         ��Name$ 
TextNumber��5      $��20(�6*   $��0��68   5      �� 5   
   -   5        $��2��5      $��20(�6   $	��100��6,   .��6S   Угадать!6]   �� 5   
   -   5        $ LabelRes��5      $��15(�6"   $��Center=�60   $��3��6M   $ ��Пока числа нет��6Z   �� 5   
   -   5        $ LabelAtt��5      $��15(�6"   $��Center=�60   $��4��6M   5      5      