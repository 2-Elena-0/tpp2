   M S B A M L   `   `   `  ����C  ?notebook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:notebooknotebook  5   	       notebook.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:notebook     5   	      m_Title  � Title#  �   5   	   $	��450��6+   $	��800��68   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   o� $��30��6   $��0��6   .@�5      m� $��30��6    
 m_File#���  6#   .@�5      m� -   5         
 m_Open#���  5      6=   m� 5      -   5         
 m_Save#���  5      6=   5      m� 5      $��30��6    
 m_Edit#���  6#   .@�5      m�  m� Command$ 	SelectAll��6     m_Select_all#���  5       m� CommandTarget 5   /   ��  �� ElementName$ txtNotes��5      m� 5      $	 Cut��6    	 m_Cut#���  6X    6)   �� $ txtNotes��6X   m� 5      $
 Copy��6    
 m_Copy#���  6Y    6*   �� $ txtNotes��6Y   m� 5      $ Paste��6    
 m_Past#���  6Z    6+   �� $ txtNotes��6Z   m� 5      $ Delete��6    	 m_Delete#��� 	 6[    6,   �� $ txtNotes��6[   5      m� 5      -   5         m�Name$ MenuLanguage��5   #   $��30��6    
 m_menu_Language#��� 
 69   6f   5      �� 5   
   -   5        $��txtNotes��5      $��1��6    �� TextWrapping$
 Wrap=�6/   $��10q�6C   5      5"      