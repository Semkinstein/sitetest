   M S B A M L   `   `   `  ����B  >WpfApp5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp5WpfApp5  5   	       WpfApp5.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp5     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��332��6)   .��5	      � $��0,0,2,0q�6   .+�5
   
   �� -   5         ��Name$ listBox��5
      $
��Left=�6#   $	��232��6>   $	��Top=�6K   $	��280��6c   $��	10,10,0,0q�6o   �� 5   
   -   5         ��Name$ but_play��5      $	��►��6#   $
��Left=�6/   $	��Top=�6J   $��40��6b   $��
10,253,0,0q�6m   $��40��6�   &   System.Windows.Media.TextOptions   TextFormattingMode$ Display=�6�      TextHintingMode$ Fixed=�6�   $��Tahoma)�6�   $��22(�6�   6�   �� 5   
   -   5        $ 	but_pause��5      $��❚❚��6$   $
��Left=�61   $	��Top=�6L   $��40��6d   $��
60,253,0,0q�6o   $��40��6�   $��22(�6�   6�   �� 5   
   -   5        $ but_stop��5      $	��■��6#   $
��Left=�6/   $	��Top=�6J   $��40��6b   $��110,253,0,0q�6m   $��40��6�   $��22(�6�   6�   �� 5   
   -   5        $ but_shuffle��5      $	��இ��6&   $
��Left=�62   $	��Top=�6M   $��40��6e   $��160,253,0,0q�6p   $��40��6�   $��20(�6�   6�   �� 5   
   -   5         ��Name$ sl_time��5      $
��Left=�6"   $	��Top=�6=   $��
22,302,0,0q�6U   $	��178��6i   6�   �� 5   
   -   5        $ 	sl_volume��5      $
��Left=�6$   $	��Top=�6?   $��215,289,0,0q�6W   $	��106��6l   $��22��6x    J� RenderTransformOrigin$ 0.5,0.5&�6�    � Cursor$ Arrow��6�    � Value$	 0.5Q�6�   	 � Maximum$	 1Q�6�   z�5      V� 5      .~�5      �� �� 5      �� 5      
 �� Angle$	
 -90Q�6&   T� 5      5      5      �� 5   
   -   5         ��Name$ l_time��5      $��0:0:0��6    $
��Left=�60   $	��Top=�6K   $��146,325,0,0q�6c   $��54��6x   �� 5   
   -	   5        $ 
l_cur_time��5      $��0:0:0��6$   $
��Left=�64   $	��Top=�6O   $��
22,325,0,0q�6g   $��38��6{   5      5      