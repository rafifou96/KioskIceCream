   M S B A M L   `   `   `  ����H  DIceCreamKiosk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:IceCreamKiosk.UserControlsIceCreamKiosk.UserControls  5      d `Microsoft.Maps.MapControl.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35tRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPFMicrosoft.Maps.MapControl.WPF 5	      /    )IceCreamKiosk.UserControls.AdminDashboard   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:IceCreamKiosk.UserControls     5      U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullY UMaterialDesignThemes.MahApps, Version=0.1.0.325, Culture=neutral, PublicKeyToken=nullHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5      ^mapRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPF   5	      .��5      � -   5          �Name$  GridMain��5      .+�5   
   )  #MaterialDesignThemes.Wpf.DialogHost  -   5          Name$ 
DialogHost��5   <      CloseOnClickAway .    DialogContent 5      � 5      -   5        $  gdDialogHost��5      $
��Auto��6-   $��Center=�6:   $
��Auto��6W   .+�5      ��  �� Orientation$ 
Horizontal=�6!   $��15q�6:   $��Center=�6F   .+�5      A� $	��150��6"   $	��150��6.   ��5      �� 5   "    j� Stretch$ UniformToFill=�6-    �� ImageSource 6E   �� *
ImageURL+5      �� 5      $ Vertical=�6%   $��10q�6<   .+�5"      �� $	��200��6(   $
��15,5q�64   $
��Wrap=�6B   $��
ExtraBlack"�6W    #  MaterialDesignDisplay1TextBlock#��[  6�   ��6o   �� *Name+6�   �� 5#      $	��200��6(   $
��15,5q�64   $
��Wrap=�6B   $��16(�6V   $��DemiBold"�6d    # MaterialDesignDisplay4TextBlock#��[ 6�   ��6z   �� *	Flavour+6�   �� 5$      $	��200��6(   $
��15,5q�64   $
��Wrap=�6B   $��15(�6V    # MaterialDesignDisplay3TextBlock#��[ 6�   ��6d   �� *Description+6�   �� 5&      $ Vertical=�6)   $��10q�6@   .+�5)   "   �� $ 
Horizontal=�6-   $��0,10,0,0q�6F   .+�5*   &   '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=null]]   Kind$ Flash=�6>   $��0,0,3,0q�6K   $��Center=�6\   �� 5+   &   $��	Energy:		��60      MaterialDesignBody2TextBlock#��[ 6K   $��16(�6�   �� 5,   &   $��SemiBold"�6H   $��Center=�6^   $��16(�6y   ��60   �� *Energy+6y   �� 5-   &   $�� KCAL��60   $��SemiBold"�6=   $��Center=�6S   $��16(�6n   5.   #   �� 5/   "   $ 
Horizontal=�6-   $��0,8,0,0q�6F   .+�50   &     $ CubeOutline=�6>   $��0,0,3,0q�6Q   $��Center=�6b   �� 51   &   $��Sugar:		��60   #��[ 6J   $��16(�6�   �� 52   &   $��SemiBold"�6G   $��Center=�6]   $��16(�6x   ��60   �� *Sugar+6x   �� 53   &   $�� g��60   $��SemiBold"�6:   $��Center=�6P   $��16(�6k   54   #   �� 55   "   $ 
Horizontal=�6-   $��0,8,0,10q�6F   .+�56   &     $ WaterOutline=�6>   $��0,0,3,0q�6R   $��Center=�6c   �� 57   &   $��Fat:		��60   #��[ 6H   $��16(�6~   �� 58   &   $��SemiBold"�6E   $��Center=�6[   $��16(�6v   ��60   �� *Fat+6v   �� 59   &   $�� g��60   $��SemiBold"�6:   $��Center=�6P   $��16(�6k   5:   #   5;      �� 5>      $ 
Horizontal=�6)   $��Right=�6B   $��Bottom=�6^   .+�5?   "   �� -   5         ��Name$ btnDialogDelete��5?   )     MaterialDesignFlatButton#���  6`   $��Center=�5@   !   $��DELETE��6<   �� 5A   "   -   5        $ btnDialogOK��5A   )   	   CloseDialogCommand#��Z	 6>   #���  6�   $��Center=�5B   !   $��OK��6<   5C      5D      5E      5F      .��5I      � 
�������
 � ColumnDefinitions
 5J      �� 5K      $��* �6'   �� 5L      $��* �6'   �� 5M      $��* �6'   .+�5Q      #  MaterialDesignThemes.Wpf.Card  
�������$��10q�69   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�5R   &   $	��630��6W   .��5S      '  !Microsoft.Maps.MapControl.WPF.Map  -   5          Name$	 Map��5S      +  %Microsoft.Maps.MapControl.WPF.MapCore   CredentialsProviderT  NMicrosoft.Maps.MapControl.WPF.Design.ApplicationIdCredentialsProviderConverter$F @AvTzJZt1E6MHYLyNIogfiPuVFKl5THAE_BCqdscIzXMx_GSDwpOdYUPjBY4vw241 6+      	ZoomLevel$ 15Q�5T         Center 6)   �� *
Location+5U      �� 5X      $��1��6   
�������.+�5[      &	   MaterialDesignThemes.Wpf.Flipper	  -   5         	 Name$ flpChangeNamePicture��5[   -    	  FrontContent 5\      �� 5]       	  FlipCommand#��Z 6&   $
��Auto��5^   <   $
��Auto��6J    J� Opacity$ 1Q�6n   ��6&   Z� ��6W   Z� .��5_   "   � $	��180��6'   $	��Top=�64   $��9,12,9,0q�6L   .+�5`   &     
�������.��5a   *   �� -   5         ��Name$ imgBtnDevanture��5a   0   $
��Fill=�6I   $	��Top=�6t   ��6X   �� *
ImageURL+6t   5b   '   �� 5c   &   $��Bottom=�61   $��15q�6b   
���   �$��20(�5d   1    ! MaterialDesignButtonTextBlock#��[ 6?   $
��Wrap=�6v   ��5c   L   �� *Name+5d   v   5e   #   5f       	  BackContent 5h      �� 5i      #��Z 6&   $
��Auto��5j   <   $
��Auto��6J   ��6&   Z� ��6W   Z� .��5k   "   � $	��180��6'   $	��Top=�64   $��10q�6L   .+�5n   &     
����ح�.��5o   *   �� -	   5        $ imgBtnDevantureBack��5o   0   $
��Fill=�6M   $ 0Q�6\   $	��Top=�6�   ��6h   �� *
ImageURL+6�   5p   '   �� 5s   &   $��10q�61   .+�5t   *   �� -
   5         ��Name$ txtFlpChangeName��5t   2   $��10q�6b   )
  #MaterialDesignThemes.Wpf.HintAssist 
  Hint$ 	Shop Name��5u   .    % !MaterialDesignFloatingHintTextBox#��[ 5v   .   $��Champagne & Limousines)�5w   .   $��13(�6V   ��5t   L   �� *Name+5w   d   �� 5x   *   -   5        $ btnChangePicture��5x   1   $��Change Picture��6K   $��10q�6d   6p   5y   '   5z   #   5{      5}      	  5�       5�      �� 5�      #��Z 6%   $
��Auto��5�   ;   $
��Auto��6I   ��6%   Z� ��6V   Z� .��5�   "   � $	��170��6'   $	��Top=�64   $��10q�6L   .+�5�   &     
����ح�.��5�   *   �� $
��Fill=�60   $ 0Q�6?   $	��Top=�6g   ��6K   �� *
ImageURL+6g   5�   '   �� 5�   &   $��15q�61   $��Center=�6=   .+�5�   *   �� $ 
Horizontal=�65   .+�5�   .     $
 Shop=�6F   $��0,0,3,0q�6R   $��Center=�6c   �� 5�   .   $��16(�69   $��	Address:	��6G   $��
ExtraLight"�6\   $��Center=�6t   �� 5�   .   $��16(�69   $
��Wrap=�6`   $	��240��6t   ��6G   �� *	Address+6t   5�   +   �� 5�   *   $ 
Horizontal=�65   $��0,8,0,0q�6N   .+�5�   .     $ Phone=�6F   $��0,0,3,0q�6S   $��Center=�6d   �� 5�   .   $��16(�69   $��Phone:	��6G   $��
ExtraLight"�6Z   $��Center=�6r   �� 5�   .   $��16(�69   $	��240��6^   $
��Wrap=�6j   $��SemiBold"�6~   ��6G   �� *Phone+6~   5�   +   �� 5�   *   $ 
Horizontal=�65   $��0,8,0,0q�6N   .+�5�   .     $	 Web=�6F   $��0,0,3,0q�6Q   $��Center=�6b   �� 5�   .   $��16(�69   $��	Website:	��6G   $��
ExtraLight"�6\   $��Center=�6t   �� 5�   .   $��16(�69   $	��240��6`   $��SemiBold"�6l   ��6G   �� *	Website+6l   5�   +   5�   '   5�   #   5�       5�      �� 5�      #��Z 6%   $
��Auto��5�   ;   $
��Auto��6I   ��6%   Z� ��6V   Z� .��5�   "   � $	��170��6'   $	��Top=�64   $��10q�6L   .+�5�   &     
����ح�.��5�   *   �� $
��Fill=�60   $ 0Q�6?   $	��Top=�6g   ��6K   �� *
ImageURL+6g   5�   '   �� 5�   &   $��10q�61   .+�5�   *   �� -   5        $ txtChangeAddress��5�   .   $��7q�5�   K   $ Address��5�   .   #��[ 5�   .   $��Champagne & Limousines)�5�   .   $��13(�6V   ��5�   2   �� *	Address+5�   V   �� 5�   *   -   5        $ txtFlpChangePhone��5�   2   $��7q�6d   #��[ 5�   .   $ Phone��5�   .   $��Champagne & Limousines)�5�   .   $��13(�6V   ��5�   M   �� *Phone+5�   d   �� 5�   *   -   5        $ txtFlpWebsite��5�   2   $��7q�6b   #��[ 5�   .   $ Website��5�   .   $��Champagne & Limousines)�5�   .   $��13(�6V   ��5�   I   �� *	Website+5�   d   5�   '   5�   #   5�      5�      �� 5�      .+�5�        $��20q�6.   $��8q�6:   
�������
���   �.��5�      �� -   5        $��	stkpOffer��5�   )   .+�5�   "   �� $��18(�6-   $��Ice-Creams Offer��6;   #��[ 6T   �� 5�   "   $ 
Horizontal=�6-   .+�5�   &     $ IceCream=�6>   $��0,0,3,0q�6N   $��Center=�6_   �� 5�   &   $��16(�61   #��[ 6[   ��6?   ��  �� Path$ Count�6[   5�   #   5�      5�        5�      $	��200��6.   $��	0,-30,0,0q�6;   .��5�      �� 
�������$��20q�6A   $	��135��6M   .��5�   "   �� -   5         ��Name$ ListViewIceCreams��5�   /   ��5�   &   �� 5�   *   .R�5�   .   �� $��10q�69   .+�5�   2   �� $ btnShowIceCream��69   -   5        $��0q�5�   9   ��5�   R   Z� ��6c   Z� ��6y   Z� .��5�   6   �� 
���� ��$��2q�6R   ._�5�   :   �� $ 
Horizontal=�6E   $��10q�6_   $	��100��6k   $	��100��6z   .+�5�   >   A� $��30��6F   $��30��6Q   ��5�   B   �� 5�   F   $ UniformToFill=�6Q    6i   �� *
ImageURL+5�   ?   �� 5�   >   $��10q�6^   $
��Wrap=�6k   #��[ 5�   H   $	��100��6   ��5�   H   �� *Name+5�      5�   ;   5�   7   5�   3   5�   /   5�   +   ��5�   &   �� 5�   *   .R�5�   .   � 5�   +   5�   #   5�      5�      5�      5�      �� 5�      $��2��6   $��10q�6-   .+�5�        
�������
���   �$��5q�5�   *   $��	0,0,10,10q�5�   *   .��5�      �� $ 
Horizontal=�6%   .+�5�        $	 Add=�66   $��Center=�6A   $��5q�6\   �� 5�      $��Center=�6(   $��Add An Ice-Cream��6C   $��5q�6[   $��20(�5�       #��[ 6.   $
��Wrap=�6e   �� 5�      -   5        $ Disconnection��5�   %   $��90,0,0,0q�6<   
���  ����6`   Z� .��5�   "     $ PowerStandby=�6:   5�      5�      5�        5     $��	0,10,10,0q�6*   
�������
���   �$��8q�5  .   .��5     �� -   5         ��Name$ stkpAddIceCream��5  %   .+�5     �� -   5        $ txtIceCream��5  &   $	��0,5q�6Q   $
 Name��5	  "   #��[ 5
  "   $��Champagne & Limousines)�5  "   $��18(�6J   ��5  ;   �� *Name+5  J   �� 5     -   5        $ txtTaste��5  &   $	��0,5q�69   $ Flavour��5  "   #��[ 5  "   $��Champagne & Limousines)�5  "   $��18(�6J   ��5  "   �� *	Flavour+5  J   �� 5     
�������$��1q�6=   $	��0,5q�6Q   ._�5  "   ��  * &MaterialDesignOutlinedTextFieldTextBox#��[ 6*   $ Description��5  &   $	��100��5  &    �� AcceptsReturn .  �� TextWrapping$
 Wrap=�5  &   
���  ��" �� VerticalScrollBarVisibility$
 Auto=�5  &   ��5  &   �� *Description+5  &   5     �� 5      $ 
Horizontal=�6)   $��Center=�6B   .+�5!  "   �� -   5        $ btnAddPicture��5!  )     PrimaryHueLightBrush#��[ 5"  )   $��
30,10,0,10q�5#  )   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 20��5$  )   $	��230��5%  )   $	��140��65   
������ $��3q�5(  )   ��5)  &   � 5*  *   .+�5+  .   �� -   5        $ imgAddImageBkg��5+  4   $	��200��5,  0   $	��120��5-  0   $
��Fill=�5.  0   �� 5/  .   -   5        $��txtBtnAddPicture��50  0   $��Center=�5/  8   $��Center=�51  0   ADD A PICTURE6\   52  +   54  #   � 56  "   -   5         �Name$ pgbImage��57  %    %	 !MaterialDesignCircularProgressBar#��[	 58  %     � Value$  0Q�59  %   ! � IsIndeterminate! . $��40��5:  %   $y�Hidden=�60   $��Right=�5;  %   $��10,0,0,0q�5<  %   $��40��5=  %   5>     �� 5@     -   5        $ btnAdd��5@  %   {�.  $	��ADD��6G   6U   5B     5C       5F     
�������
���   �$��	0,10,10,0q�5G  *   $��8q�6=   .��5H     � .+�5I     � -   5        $ pgbNutritionalInfos��5J  !   #��[	 5K  !   $  0Q�5L  !   ! . $	��100��5M  !   $	��100��5N  !   $y�Hidden=�5O  !   �� 5Q     -   5        $ stkpNutritionalInfos��5Q  )   .+�5R  "   �� $��Nutrional Informations��6,   #��[ 6J   $��18(�5S  %   �� 5V  "   $ 
Horizontal=�6-   $��0,10,0,0q�6F   .+�5W  &     $ Flash=�6>   $��0,0,3,0q�6K   $��Center=�6\   �� 5X  &   $��	Energy:		��60   #��[ 6K   $��16(�6�   �� 5Y  &   -   5        $��	txtEnergy��5Y  0   $��SemiBold"�6A   $��Center=�6W   $��16(�6r   5Z  #   �� 5[  "   $ 
Horizontal=�6-   $��0,8,0,0q�6F   .+�5\  &     $ CubeOutline=�6>   $��0,0,3,0q�6Q   $��Center=�6b   �� 5]  &   $��Sugar:		��60   #��[ 6J   $��16(�6�   �� 5^  &   -   5        " ��Name$" txtSugar��5^  0   $��SemiBold"�6B   $��Center=�6X   $��16(�6s   5_  #   �� 5`  "   $ 
Horizontal=�6-   $��0,8,0,0q�6F   .+�5a  &     $ WaterOutline=�6>   $��0,0,3,0q�6R   $��Center=�6c   �� 5b  &   $��Fat:		��60   #��[ 6H   $��16(�6~   �� 5c  &   -   5        $" txtFat��5c  0   $��SemiBold"�6@   $��Center=�6V   $��16(�6q   5d  #   5e     5f     5g     5h     5j     5k     5l     5m     