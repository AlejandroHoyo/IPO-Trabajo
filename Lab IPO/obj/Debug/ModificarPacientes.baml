   M S B A M L   `   `   `  ����B  >Lab IPO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:Lab_IPOLab_IPO  5           Lab_IPO.ModificarPacientes   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:Lab_IPO     5        N� Title$  Modificar Citas��5	       N� 
Background �#a1f7af.��5      �  � ColumnDefinitions 5   
   �� 5      $��3 �6   �� 5      $��1* �6   �� 5      $��3 �6    � RowDefinitions 5   
   �� 5      $��3 �6   �� 5      $��4* �6   �� 5      $��3* �6   �� 5      $��1* �6   �� 5      $��3 �6   .+�5   
   �� $��1��6   $��1��6    $��Datos del Paciente��60   $��Bahnschrift)�6L   $��22(�6e   $
��Bold"�6s   
���   �$��3q�6�   .��5      �  5      �� 5      $��3 �6'   �� 5      $��1* �6'   �� 5      $��2* �6'   �� 5      $��3 �6'   .+�5       � $��2��6    5!      �� 5"      $��5 �6(   �� 5#      $��1* �6(   �� 5$      $��5 �6(   �� 5%      $��1* �6(   �� 5&      $��5 �6(   �� 5'      $��1* �6(   �� 5(      $��5 �6(   �� 5)      $��1* �6(   �� 5*      $��5 �6(   �� 5+      $��1* �6(   �� 5,      $��5 �6(   �� 5-      $��1* �6(   �� 5.      $��5 �6(   �� 5/      $��1* �6(   �� 50      $��5 �6(    52      �� 53      $��3 �6+   �� 54      $��1* �6+   �� 55      $��2* �6+   �� 56      $��3 �6+   .+�59      �� $��1��6!   $��1��6.    �� Orientation$ 
Horizontal=�6>   $��Right=�6W   $��Center=�6s   .+�5:      �� $��Assets/Icons/id.png��6    $��35��6=   $��Center=�6H   $��0,0,10,0q�6c   �� 5;      $��Nombre: ��6    $��Center=�63   $��28(�6N   $��Bahnschrift)�6\   $��Normal"�6u   5<      �� 5=      $��3��6!   $��1��6.   $ 
Horizontal=�6>   $��Right=�6W   $��Center=�6s   .+�5>      �� $��Assets/Icons/id.png��6    $��35��6=   $��Center=�6H   $��0,0,10,0q�6c   �� 5?      $��Apellidos: ��6    $��Center=�66   $��28(�6Q   $��Bahnschrift)�6_   $��Normal"�6x   5@      �� 5A      $��5��6!   $��1��6.   $ 
Horizontal=�6>   $��Right=�6W   $��Center=�6s   .+�5B      �� $��Assets/Icons/cake.png��6    $��35��6?   $��Center=�6J   $��0,0,10,0q�6e   �� 5C      $��Edad: ��6    $��Center=�61   $��28(�6L   $��Bahnschrift)�6Z   $��Normal"�6s   5D      �� 5E      $��7��6!   $��1��6.   $ 
Horizontal=�6>   $��Right=�6W   $��Center=�6s   .+�5F      �� $��Assets/Icons/gender.png��6    $��35��6A   $��Center=�6L   $��0,0,10,0q�6g   �� 5G      $��Sexo: ��6    $��Center=�61   $��28(�6L   $��Bahnschrift)�6Z   $��Normal"�6s   5H      �� 5I      $��9��6!   $��1��6.   $ 
Horizontal=�6>   $��Right=�6W   $��Center=�6s   .+�5J      �� $��Assets/Icons/location.png��6    $��35��6C   $��Center=�6N   $��0,0,10,0q�6i   �� 5K      $��Domicilio: ��6    $��Center=�66   $��28(�6Q   $��Bahnschrift)�6_   $��Normal"�6x   5L      �� 5M      $��11��6!   $��1��6/   $ 
Horizontal=�6?   $��Right=�6X   $��Center=�6t   .+�5N      �� $��Assets/Icons/email.png��6    $��35��6@   $��Center=�6K   $��0,0,10,0q�6f   �� 5O      $��Email: ��6    $��Center=�62   $��28(�6M   $��Bahnschrift)�6[   $��Normal"�6t   5P      �� 5Q      $��13��6!   $��1��6/   $ 
Horizontal=�6?   $��Right=�6X   $��Center=�6t   .+�5R      �� $��Assets/Icons/phone.png��6    $��35��6@   $��Center=�6K   $��0,0,10,0q�6f   �� 5S      $��Teléfono: ��6    $��Center=�65   $��28(�6P   $��Bahnschrift)�6^   $��Normal"�6w   5T      �� 5V      -   5         ��Name$$ nombreModificarPacienteTextbox��5V       �� TextWrapping$
 Wrap=�6F   $��Stretch=�6r   $��Center=�6�   $��2��6�   $��1��6�   $��55��6�   $��0,0,10,0q�6�   $��	Banshrift)�6�   $��Normal"�6�   $��center=�6  $��28(�63  ��6Z   �� *Nombre+63  �� 5W      -   5        $' !apellidosModificarPacienteTextbox��5W      $
 Wrap=�6I   $��Stretch=�6x   $��Center=�6�   $��2��6�   $��3��6�   $��55��6�   $��0,0,10,0q�6�   $��	Banshrift)�6�   $��Normal"�6  $��center=�6  $��28(�69  ��6]   �� *	Apellidos+69  �� 5X      -   5        $" edadModificarPacienteTextbox��5X      $
 Wrap=�6D   $��Stretch=�6n   $��Center=�6�   $��2��6�   $��5��6�   $��55��6�   $��0,0,10,0q�6�   $��	Banshrift)�6�   $��Normal"�6�   $��center=�6  $��28(�6/  ��6X   �� *Edad+6/  �� 5Y      -   5         ��Name$# sexoModificarPacienteComboBox��5Y      $��Stretch=�6F   $��Center=�6d   $��2��6   $��7��6�   $��55��6�   $��0,0,10,0q�6�   $��	Banshrift)�6�   $��Normal"�6�   $��center=�6�    � Cursor$
 Hand��6  .@�5Z      �� $��Hombre��6'   	 �� 
IsSelected	 . 68   �� 5[      $��Mujer��6'   5\      �� 5]      -   5        $' !domicilioModificarPacienteTextbox��5]      $
 Wrap=�6I   $��Stretch=�6x   $��Center=�6�   $��2��6�   $��9��6�   $��55��6�   $��0,0,10,0q�6�   $��	Banshrift)�6�   $��Normal"�6  $��center=�6  $��28(�69  ��6]   �� *	Direccion+69  �� 5^      -   5        $$ correoModificarPacienteTextbox��5^      $
 Wrap=�6F   $��Stretch=�6}   $��Center=�6�   $��2��6�   $��11��6�   $��55��6�   $��0,0,10,0q�6�   $��	Banshrift)�6�   $��Normal"�6	  $��center=�6  $��28(�6?  ��6Z   �� *CorreoElectronico+6?  �� 5_      -   5        $&  telefonoModificarPacienteTextbox��5_      $
 Wrap=�6H   $��Stretch=�6v   $��Center=�6�   $��2��6�   $��13��6�   $��55��6�   $��0,0,10,0q�6�   $��	Banshrift)�6�   $��Normal"�6  $��center=�6  $��28(�68  ��6\   �� *
Telefono+68  5`      �� 5a      $��4q�6   
���   �$	��230��6A   $	��230��6N   
 �� CornerRadius$
 10��6Z   $��Center=�6l   $��Center=�6�   $��0,0,0,70q�6�   $��1��6�   ._�5b      �� -   5         ��Name$ imagenFotoPerfil��5b      ��66   �� *
FotoPerfil+5c      �� 5d      -	   5         ��Name$ cambiarFotoPacienteButton��5d      $��Center=�6<   $��	0,240,0,0q�6Y   $��center=�6l   $��60��6�   $	��250��6�   ���#86df95
���   �$��Bahnschrift)�6�   $��24(�6�   $
��Bold"�6�   $��3,3,3,3q�6  $
 Hand��6@  $��1��6N  .��5e      �� $ 
Horizontal=�6!   .+�5f      �� $��Assets/Icons/camera.png��6    $��32��6A   $��Center=�6M   �� 5g      $��Cambiar foto��6$   $��Center=�68   $��Center=�6S   $��30(�6p   $��5,0,0,0q�6~   5h       � 	Resources 5i       �� 
TargetType �� Property �� Value��%^   '��       �� 5j      " ��6    .�5k      ��  �@��CornerRadius$ 5��6=   5l      5m      5n      5o      5p      �� 5q   
   $��2��6   $��1��6    $��Historiales Médicos��60   $��Bahnschrift)�6M   $��22(�6f   $
��Bold"�6t   
���   �$��3q�6�   .��5s      �  5t      �� 5u      $��1* �6'   �� 5v      $��2* �6'   .+�5x      �� -
   5         ��Name$ historialesMedicosList��5x      $��Center=�6p   $	��230��6�   $��Bahnschrift)�6�   $��16(�6�   $��2,2,2,2q�6�   $
 Hand��6�   
���   �$��2q�6�   ���#e7fdeb��5y      �� 5z      .R�5{      �� ��6(   �� *Fecha+5|       � ContextMenu 5~      �� 5      
���   �$��3q�6:    J� Opacity$
 0.95Q�6N    5�       �� 
TargetType��%f  '��       'm�     �� 5�   "   " ��6(   .�5�   &   ��  � �� �#a1f7af6C   �� 5�   &    � �� 5�   *   �� 5�   .   " ��6>   .R�5�   2   �� #��z��69   #��z��6c   #��z��6�   ._�5�   6   �� .+�5�   :   �� 5�   7   5�   3   5�   /   5�   '   5�   #   �� 5�   "   " m�6(   .�5�   &   ��  � �� �#a1f7af6C   5�   #   5�      .@�5�      m� -   5         m�Name$ ctxHistorialAdd��5�   '   $��Añadir Historial Nuevo��6@   $��18(�6`   $
��Bold"�6�   $��Bahnschrift)�6�    m� Icon 5�   "   �� 5�   &   $��Assets/Icons/correct.png��6,   5�      m� 5�      -   5        $ ctxHistorialDelete��5�   '   $��Borrar Historial��6C   $��18(�6]   $
��Bold"�6�   $��Bahnschrift)�6�    5�   "   �� 5�   &   $ ��Assets/Icons/incorrect.png��6,   5�      5�      5�      �� 5�      $��2q�6   
���   �$��1��6A   $��3q�6Q   $
 4��6\   ._�5�      �� $��3q�6#   $
��Auto=�6.   .��5�      �� .+�5�      �� $!��Datos del Historial Médico��6'   $��Bahnschrift)�6K   $��18(�6d   $
��Bold"�6r   
���   �$��2q�6�   .��5�   "   �� $ 
Horizontal=�6-   $��Stretch=�6F   .+�5�   &   �� $��Assets/Icons/calendar.png��6,   $��25��6O   $��Center=�6Z   $��5,0,10,0q�6u   (  "System.Windows.Controls.DatePicker  5�   &   -   5          Name$ fechaHistorial��5�   1   $��Stretch=�6I   $��18(�6e   $��Bahnschrift)�6s   $��Normal"�6�   $��Stretch=�6�   $	��500��6�   5�   #   5�      �� 5�      $��	Dolencias��6'   $��Bahnschrift)�6:   $��18(�6S   $
��Bold"�6a   
���   �$��2q�6�   $��60��6�   .��5�   "   �� -   5        $' !dolenciasModificarPacienteTextBox��5�   *   $��18(�6p   $��Normal"�6~   $��Bahnschrift)�6�   $
 Wrap=�6�   ��6U   �� *	Dolencias+6�   5�      �� 5�      $��Tratamientos��6'   $��Bahnschrift)�6=   $��18(�6V   $
��Bold"�6d   
���   �$��2q�6�   $��60��6�   .��5�   "   �� -   5        $* $tratamientosModificarPacienteTextBox��5�   *   $��18(�6w   $��Normal"�6�   $��Bahnschrift)�6�   $
 Wrap=�6�   ��6Y   �� *Tratamientos+6�   5�      �� 5�      -   5        $&  modificarHistorialPacienteButton��5�   %   $��Center=�6O   $��0,5,0,0q�6l   $��center=�6}   $��35��6�   $	��150��6�   ���#86df95
���   �$��Bahnschrift)�6�   $��18(�6�   $
��Bold"�6   $��3,3,3,3q�6  $
 Hand��6X  .��5�   "   �� $ 
Horizontal=�6-   .+�5�   &   �� -   5        $! modificarHistorialBotonFoto��5�   ,   $��Assets/Icons/modify.png��6Q   $��20��6r   $��Center=�6~   �� 5�   &   -   5         ��Name$" modificarHistorialBotonTexto��5�   0   $��	Modificar��6V   $��Center=�6g   $��Center=�6�   $��18(�6�   $��5,0,0,0q�6�   5�   #    5�   "   ��%^   '��       �� 5�   &   " ��6,   .�5�   *   ��  �@��CornerRadius$ 5��6I   5�   '   5�   #   5�      5�      5�      5�      5�      5�      �� 5�   
   -   5        $' !confirmarModificarPacientesButton��5�      $��Center=�6<   $��	0,0,375,0q�6Y   $��center=�6l   $��60��6�   $	��350��6�   ���#2ba13f
���   �$��Bahnschrift)�6�   $��24(�6�   $
��Bold"�6�   $��3,3,3,3q�6  $
 Hand��6E  $��3��6S  $��1��6`  .��5�      �� $ 
Horizontal=�6   .+�5�      �� $��Assets/Icons/save.png��6   $��32��67   $��Center=�6C   �� 5�      $��Confirmar cambios��6   $��Center=�65   $��Center=�6P   $��30(�6m   $��5,0,0,0q�6{   5�       5�      ��%^   '��       �� 5�      " ��6   .�5�      ��  �@��CornerRadius$ 5��65   5�      5�      5�      �� 5�   
   -   5        $&  cancelarModificarPacientesButton��5�      $��Center=�6;   $��	375,0,0,0q�6X   $��center=�6k   $��60��6�   $	��350��6�   
���  ��
���   �$��Bahnschrift)�6�   $��24(�6�   $
��Bold"�6�   $��3,3,3,3q�6   $
 Hand��6A  $��3��6O  $��1��6\  .��5�      �� $ 
Horizontal=�6   .+�5�      �� $��Assets/Icons/delete.png��6   $��32��69   $��Center=�6E   �� 5�      $��Cancelar cambios��6   $��Center=�64   $��Center=�6O   $��30(�6l   $��5,0,0,0q�6z   
�������6�   5�       5�      ��%^   '��       �� 5�      " ��6   .�5�      ��  �@��CornerRadius$ 5��65   5�      5�      5�      5�      5�      