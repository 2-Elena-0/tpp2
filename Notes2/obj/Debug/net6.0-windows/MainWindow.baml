   M S B A M L   `   `   `  ����A  =Notes2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Notes2Notes2  5   	       Notes2.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Notes2     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��400��6)    J� CommandBindings 5	      )  #System.Windows.Input.CommandBinding  5
   
   -   5           Command$ local:WindowCommands.Exit��5
      6=     5   
   -   5        $ local:WindowCommands.Open��5      6=     5   
   -   5        $ local:WindowCommands.Save��5      6=     5   
   -   5        $! local:WindowCommands.SaveAs��5      6?   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   o� $��0��6   .@�5      m� $��20(�6      File#���   6%   .@�5      m� -   5         m� Command$ local:WindowCommands.Open��5        Open#���  6?   6_   m� 5      -   5        $ local:WindowCommands.Save��5        Save#���  6?   6_   m� 5      -   5        $! local:WindowCommands.SaveAs��5       
 SaveAs#���  6A   6c   5      m� 5      $��20(�6    	 Tools#���  6%   .@�5      m� $ 	SelectAll��6     	SelectAll#���  5       m� CommandTarget 5   /   ��  �� ElementName$ fileText��5      m� 5      $	 Cut��6     Cut#���  6X    6)   �� $ fileText��6X   m� 5      $
 Copy��6     Copy#���  6Y    6*   �� $ fileText��6Y   m� 5      $ Paste��6     Past#���  6Z    6+   �� $ fileText��6Z   m� 5       $ Delete��6    
	 Delete#��� 	 6[    6,   �� $ fileText��6[   5!      m� 5"      -   5         m�Name$ 	Languages��5"   %   $��20(�6    
 	Languages#��� 
 68   m� 5#      $��20(�6     Exit#���  6%   $ local:WindowCommands.Exit��6E   5$      �� 5%   
   -	   5         ��Name$ fileText��5%      $��1��6   	 �� TextWrapping$
	 Wrap=�61   $��10q�6E   5'      5(      