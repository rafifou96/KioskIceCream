   M S B A M L   `   `   `  ����H  DIceCreamKiosk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:IceCreamKiosk.UserControlsIceCreamKiosk.UserControls  5      *    $IceCreamKiosk.UserControls.AdminAuth   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:IceCreamKiosk.UserControls     5      U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullY UMaterialDesignThemes.MahApps, Version=0.1.0.325, Culture=neutral, PublicKeyToken=nullHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5      .��5      � -   5          �Name$  GridMain��5      .+�5   
   )  #MaterialDesignThemes.Wpf.DialogHost  -   5          Name$ 
DialogHost��5   <      CloseOnClickAway .    DialogContent 5      � 5      $	��380��6   $��Center=�6#   .+�5      ��  �� Orientation$ 
Horizontal=�6!   $��15q�6:   $��Center=�6F   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=null]]   Kind$ Warning=�62   
���  ��$��50��6R   $��50��6]   �� 5      -   5         ��Name$ dialTextBlock��5   $   
�������$	��200��6M   $
��15 5q�6Y   $
��Wrap=�6g   $��15(�6{   5      �� 5      $ 
Horizontal=�6!   $��Right=�6:   $��Bottom=�6V   $��	0,0,10,15q�6q   .+�5      �� -   5         ��Name$ btnDialogOK��5   !      CloseDialogCommand#��Z 66      MaterialDesignFlatButton#���   6x   $��4q�5      $��Center=�6(   $��OK��6C   5      5      .��5      � 	 � ColumnDefinitions	 5      �� 5      $��* �6'   �� 5      $��* �6'   .+�5#      � $��0��6   .+�5$        $ IceCream=�6.   ���#55A7E5$	��150��6S   $	��150��6_   $��Center=�5%      $��Center=�66   5&      5'      � 5*      -   5        $  	gridLogin��5*      $��1��6*   .+�5-      �� ��5.      �� 5/      
 �� EndPoint$
 0.5,1&�62    �� 
StartPoint$ 0.5,0&�6C   .��50   "   �  � Color$ #55a7e5��6/   � 51   "   $ #9fd5ff��6/    � Offset$	 0.5Q�6?   � 52   "   $ #bfe3ff��6/   $ 1Q�6?   53      55      �� 57      $	��280��6    $	��250��6,   $��Center=�69   $
��0,80q�6T    �� RadiusY$ 10��6b    �� RadiusX$ 10��6o   
������� J� Effect 58      3  -System.Windows.Media.Effects.DropShadowEffect  59         
BlurRadius$ 15Q�6/      	Direction$ 0Q�6?      RenderingBias$ Quality=�6M      ShadowDepth$ 1Q�6e      Color$ 	#FFBBBBBB��6u   5;      � 5=      -   5         �Name$ pgbLogin��5=   "    % !MaterialDesignCircularProgressBar#��[ 5>   &    � Value$ 0Q�5?   &    � IsIndeterminate . $	��200��5@   &   $	��200��5A   &   $��Center=�5B   &   $y�Hidden=�5C   &   � 5F      $��Center=�6   $��35,80q�66   $	��240��6E   .+�5G      �� $��LOGIN��6    $��Center=�60   $	��Top=�6M   $��5q�6e   
�������$��18(�6�   �� 5H      $��Center=�6%   $��15q�6@   .+�5I      �� -   5         ��Name$ txtLoginEmail��5I   &   $
��0,10q�6=   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ PSEUDO��5K   "    % !MaterialDesignFloatingHintTextBox#��[ 6J   $��Champagne & Limousines)�6�   $��18(�6�   $	��225��6�   ��5J   "   �� *Pseudo+5K   �   G� 5L      -   5         G�Name$ psLoginPassword��5L   *   $
��0,10q�5M   &   $ PASSWORD��64    ) %MaterialDesignFloatingHintPasswordBox#��[ 6^   $��Champagne & Limousines)�6�   $��18(�6�   $	��225��6�   5N      5O      �� 5R      -	   5        $ btnLogin��5R      $	��150��6/   $��Center=�6;   $��Bottom=�6X   $
��0,65q�5S      $��LOGIN��6'   67   �� 5V      -
   5        $ btnToSignUpPage��5V      $��SIGN UP��5W   F   $��Center=�6X   $��Bottom=�6u   $��30q�6�   
�������$	��150��5X   I   ��5W      Z� ��6/   Z� 5X   I     5Y      $
 Shop=�6.   $	��100��6:   $	��100��6F   $��Center=�6S   $��30q�6p   
�������6|   5Z      � 5]      -   5        $  
gridSignUp��5]      $��1��6+   .+�5`      �� ��5a      �� 5b      $
 0.5,1&�62   $ 0.5,0&�6C   .��5c   "   � $ #55a7e5��6/   � 5d   "   $ #9fd5ff��6/   $	 0.5Q�6?   � 5e   "   $ #bfe3ff��6/   $ 1Q�6?   5f      5h      �� 5j      $	��280��6    $	��400��6,   $��Center=�69   $
��0,80q�6T   $ 10��6b   $ 10��6o   
������� 5k        5l      $ 15Q�6/   $ 0Q�6?   $ Quality=�6M   $ 1Q�6e   $ 	#FFBBBBBB��6u   5n      � 5q      $��Center=�6   $	��400��66   .+�5r      �� $��SIGN-UP��6    $��Center=�62   $	��Top=�6O   $��5q�6g   
�������$��18(�6�   �� 5s      $��Center=�6'   $��15,20,15,15q�6B   $	��330��6W   $	��260��6d   .��5t      �� .+�5u   "   �� -   5        $ txtName��5u   *   $
��0,10q�6R   $ Shop's Name��6`   #��[ 6�   $��Champagne & Limousines)�6�   $��18(�6�   $	��225��6�   ��6<   �� *Name+6�   �� 5v   "   -   5        $ 	txtPseudo��5v   *   $
��0,10q�6V   $ Pseudo��6d   #��[ 6�   $��Champagne & Limousines)�6�   $��18(�6�   $	��225��6�   ��6>   �� *Pseudo+6�   G� 5w   "   -   5        $ 
psPassword��5w   .   $
��0,10q�6B   $ Password��6P   #��[ 6z   $��Champagne & Limousines)�6�   $��18(�6�   $	��225��6�   �� 5x   "   -   5        $ 
txtAddress��5x   *   $
��0,10q�6X   $ Address��6f   #��[ 6�   $��Champagne & Limousines)�6�   $��18(�6�   $	��225��6   ��6?   �� *	Address+6  � 5z   "   -   5        $ 
pgbAddress��5{   &   #��[ 5|   &   $ 0Q�5}   &    . $��40��5~   &   $��40��5   &   $��Center=�5�   &   $y�Hidden=�5�   &   �� 5�   "   -   5        $ txtPhoneNumber��5�   *   $
��0,10q�6Z   $ Phone Number��6h   #��[ 6�   $��Champagne & Limousines)�6�   $��18(�6�   $	��225��6  ��6C   �� *Phone+6  �� 5�   "   -   5        $ 
txtWebsite��5�   *   $
��0,10q�6X   $ Website��6f   #��[ 6�   $��Champagne & Limousines)�6�   $��18(�6�   $	��225��6   ��6?   �� *	Website+6   �� 5�   "   -   5        $ btnAddPicture��5�   )   $
��0,10q�6@     PrimaryHueLightBrush#��[ 5�   %   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 20��5�   %   $	��200��5�   %   $	��130��61   
������ ��5�   &   � 5�   *   .+�5�   .   �� -   5         ��Name$ imgAddImageBkg��5�   4   $	��200��5�   ,   $	��130��5�   ,   $
��Fill=�5�   ,   $��-16,-5,-16,-3.4q�6;   �� 5�   .   -   5        $ txtBtnAddPicture��5�   8   $��Center=�5�   4   $��Center=�6O   DEVANTURE PICTURE6   5�   +   5�   #   5�      5�      5�      �� 5�      -   5        $ 	btnSignUp��5�      $	��150��60   $��Center=�6<   $��Bottom=�6Y   $
��0,65q�6t   $��SIGN UP��6�   6�   �� 5�      -   5        $ btnToLoginPage��5�      $��Center=�5�      $��Bottom=�62   $��30q�6M   
������� � Cursor$
 Hand��5�   '   $	��200��5�      ��5�      Z� ��6+   Z� .��5�      �� $ 
Horizontal=�6%   .+�5�        $ 	ArrowLeft=�66   $��15��6G   $��15��6R   $��Center=�6^   $��0,0,6,0q�6y   �� 5�      $��BACK TO LOGIN PAGE��6(   5�      5�        5�      $
 Shop=�6.   $	��100��6:   $	��100��6F   $��Center=�6S   $��30q�6q   
�������6}   5�      5�      5�      5�      5�      