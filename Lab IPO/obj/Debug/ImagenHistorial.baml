   M S B A M L   `   `   `  ����B  >Lab IPO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:Lab_IPOLab_IPO  5   	       Lab_IPO.ImagenHistorial   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Lab_IPO     5   	     � 
ResizeMode$  NoResize=�5   	    � Title$ ImagenHistorial��5	   	   ���#a1f7af$	��325��5   	   $	��500��6    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � $��0,-1,0,1q�6    � RowDefinitions 5   
   �� 5      $��10 �6   �� 5      $��3* �6   �� 5      $��1* �6   �� 5      $��10 �6    � ColumnDefinitions 5   
   �� 5      $��10 �6   �� 5      $��1* �6   �� 5      $��10 �6   .+�5   
   �� -   5         ��Name$ CargarImagenButton��5      $��Center=�6-   $��	0,0,240,0q�6J   $��center=�6]   $��45��6x   $	��180��6�   ���#2ba13f
���   �$��Bahnschrift)�6�   $��24(�6�   $
��Bold"�6�   $��3,3,3,3q�6�    � Cursor$
 Hand��6(  $��2��66  $��1��6C  .��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��Assets/Icons/images.png��6   $��24��69   $��Center=�6E   �� 5      $��Cargar foto��6   $��Center=�6/   $��Center=�6J   $��20(�6g   $��5,0,0,0q�6u   5       � 	Resources 5      	 �� 
TargetType
 �� Property �� Value��%^   '��       �� 5      "	 ��6   .�5       �� 
 �@��CornerRadius$ 5��65   5!      5"      5#      �� 5$   
   -   5        $ SalirButton��5$      $��Center=�6&   $��	240,0,0,0q�6C   $��center=�6V   $��45��6q   $	��180��6}   
���  ��
���   �$��Bahnschrift)�6�   $��24(�6�   $
��Bold"�6�   $��3,3,3,3q�6�   $
 Hand��6  $��2��6&  $��1��63  .��5%      �� $ 
Horizontal=�6   .+�5&      �� $��Assets/Icons/exit.png��6   $��30��67   $��Center=�6C   �� 5'      $��Salir��6   $��Center=�6)   $��Center=�6D   $��20(�6a   $��5,0,0,0q�6o   
���   �6�   5(       5)      ��%^   '��       �� 5*      "	 ��6   .�5+      �� 
 �@��CornerRadius$ 5��65   5,      5-      5.      �� 5/   
   $��4q�6   
���   � �� CornerRadius$ 5��6:   $��Stretch=�6K   $��Center=�6g   $��0,0,0,0q�6�   $��1��6�   $	��225��6�   $��1��6�   ._�50      �� -   5         ��Name$ imagenHistorial��50      51      52      53      