   M S B A M L   `   `   `  ����H  DIceCreamKiosk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:IceCreamKiosk.UserControlsIceCreamKiosk.UserControls  5      d `Microsoft.Maps.MapControl.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35tRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPFMicrosoft.Maps.MapControl.WPF 5      %    IceCreamKiosk.UserControls.Rate   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:IceCreamKiosk.UserControls     5      U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullY UMaterialDesignThemes.MahApps, Version=0.1.0.325, Culture=neutral, PublicKeyToken=nullHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5      ^mapRclr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPF   5      .��5      � 
�������  � ColumnDefinitions  5   
   �� 5      $��3* �6   �� 5      $��5* �6   �� 5      $��3* �6    � RowDefinitions 5   
   �� 5      $	��10* �6   �� 5      $��8* �6   .+�5   
   �� -   5         ��Name$ pnlBeforeIceCream��5      
�������$��0��5      $��1��6   $��2��6/   $��2��6C    K� ZIndex$ 1��6T   $��Stretch=�5      ._�5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=null]]   Kind$ CommentTextMultiple=�6&   $��Center=�6A   $��Center=�6\   $	��150��5   &   $	��150��62   ���#55A7E56?   5      �� 5!   
   ���	#FFF1F1F1$��2��6.   $��Center=�6?   .��5"      �� -   5         ��Name$ ListViewIceCreams��5"      ��5#      �� 5$      .R�5'      #  MaterialDesignThemes.Wpf.Card  -   5        
�������$��12q�5'   A   $��10q�6N   $	��265��6Z   .��5)      ��  �� Orientation$ 
Horizontal=�6)   $��1q�6B   .+�5,   "   A� $��75��6*   $��75��65   ��5-   &   �� 5.   *    j� Stretch$ UniformToFill=�65    �� ImageSource 6M   �� *
ImageURL+50   #   �� 53   "   $ Vertical=�6-   $��10q�6D   .+�54   &   �� $	��Top=�60       MaterialDesignTitleTextBlock#���   6H   ��6   �� *Name+�� 55   &   $��1,0,0,0q�60   $
��Left=�6^      MaterialDesignBody2TextBlock#���  6y   $��WrapWithOverflow=�56   0   $	��200��6P   ��55   A   �� *Description+56   P   57   #   58      59      5:      ��5=      �� 5>      .R�5?      $� 5@      5B      5C        5F   
   $��10q�6   
�������
���   �$��1��6P   $��8q�5G   *   .��5H      �� -   5        	 ��Name$	 stkpIceCreamInfos��5H   4   $ 
Horizontal=�6   .+�5K      A� $	��150��6   $	��150��6&   ��5L      �� 5M      $ UniformToFill=�6%    6=   �� *
ImageURL+5O      �� 5R      $ Vertical=�6   $��10q�64   .+�5U      �� $	��200��6    $
��15,5q�6,   $
��Wrap=�6:    # MaterialDesignDisplay1TextBlock#��[ 6d   ��6N   �� *Name+6d   �� 5V      $	��200��6    $
��15,5q�6,   $
��Wrap=�6:    # MaterialDesignHeadlineTextBlock#��[ 6g   ��6N   �� *	Flavour+6g   �� 5W      $	��200��6!   $
��15,5q�6-   $
��Wrap=�6;   $��15(�6O    # MaterialDesignDisplay3TextBlock#��[ 6z   ��6]   �� *Description+6z   �� 5Z      $ Vertical=�6!   $��10q�68   .+�5[      �� $ 
Horizontal=�6%   $��0,10,0,0q�6>   .+�5\        $ Flash=�66   $��0,0,3,0q�6C   $��Center=�6T   �� 5]      $��	Energy:		��6(   #��[ 6C   $��16(�6y   �� 5^      -   5        $��e��5^   (   $��SemiBold"�6I   $��Center=�6_   $��16(�6z   ��61   �� *Energy+6z   �� 5_      $�� KCAL��6(   #��[ 65   $��16(�6k   5`      �� 5a      $ 
Horizontal=�6%   $��0,8,0,0q�6>   .+�5b        $ CubeOutline=�66   $��0,0,3,0q�6I   $��Center=�6Z   �� 5c      $��Sugar:		��6(   #��[ 6B   $��16(�6x   �� 5d      -   5        
 ��Name$
 s��5d   (   $��SemiBold"�6J   $��Center=�6`   $��16(�6{   ��63   �� *Sugar+6{   �� 5e      $�� g��6(   #��[ 62   $��16(�6h   5f      �� 5g      $ 
Horizontal=�6%   $��0,8,0,0q�6>   .+�5h        $ WaterOutline=�66   $��0,0,3,0q�6J   $��Center=�6[   �� 5i      $��Fat:		��6(   #��[ 6@   $��16(�6v   �� 5j      -   5        $
 f��5j   (   $��SemiBold"�6H   $��Center=�6^   $��16(�6y   ��63   �� *Fat+6y   �� 5k      $�� g��6(   #��[ 62   $��16(�6h   5l      �� 5m      $ 
Horizontal=�6%   $��0,8,0,0q�6>   .+�5n        $
 Shop=�66   $��0,0,3,0q�6B   $��Center=�6S   �� 5o      $��
Sold in:		��6(   #��[ 6D   $��16(�6z   �� 5p      $��SemiBold"�6D   $��Center=�6Z   $��16(�6u   ��6)   �� *	Shop.Name+6u   5q      �� 5r      $ 
Horizontal=�6%   $��0,8,0,10q�6>   .+�5s        $
 Star=�66   $��0,0,3,0q�6B   $��Center=�6S   �� 5t      $��Rate:		��6(   #��[ 6A   $��16(�6w   �� 5u      -   5        $
 txtAverageRate��5u   (   $��SemiBold"�6]   $��Center=�6s   $��16(�6�   ��6@   �� *AverageRate+6�   5v      5w      5x      5y      5z      �� 5}   
   
�������$��1��6.   $��1��6;   $��2��6K   .��5~      �� -	   5        $ ListViewIceCreamsRatings��5~      ��5      �� 5�      .R�5�        
�������$��12q�6A   $��10q�6N   $	��250��6Z   $	��250��6i   .��5�      �� .+�5�   "   �� $ 
Horizontal=�6-   $��1q�6F   .+�5�   &   A� $��50��6.   $��50��69   ��5�   *   �� 5�   .   $ UniformToFill=�69    6Q   �� *
ImageURL+5�   '   �� 5�   &   $ Vertical=�61   $��10q�6H   .+�5�   *   �� $	��Top=�64   #���   6L   $
��Wrap=�6�   $	��120��6�   ��6�   �� *Author+6�   �� 5�   *   $��1 0 0 0q�64   #���   6b   $
��Left=�6�   $��12(�6�   $
��Wrap=�6�   $	��200��6�   ��6E   �� *Description+6�   5�   '   5�   #   (  "MaterialDesignThemes.Wpf.RatingBar  5�   "      
IsReadOnly .    Value 6;   �� *Rate+6R   5�      5�      5�      ��5�      �� 5�      .R�5�      � 5�      5�      5�      �� 5�   
   -
   5         ��Name$ 
stkpRating��5�      $��2��6+   $��1��6;   $��Center=�6L   .��5�      �� $��10q�6   .+�5�      �� -   5         ��Name$ txtIceCream��5�      $	��0,5q�6G   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Author��5�       % !MaterialDesignFloatingHintTextBox#��[ 5�      $��Champagne & Limousines)�5�      $��18(�6F   ��5�   /   �� *Author+5�   F     5�      -   5          Name$ 	ratingBar��5�      $��10q�5�      $��Center=�5�       5�      �� *Rate+5�      �� 5�      
�������$��1q�61   ._�5�      ��  * &MaterialDesignOutlinedTextFieldTextBox#��[ 6   $ Description��5�      $	��120��5�       �� AcceptsReturn .  �� TextWrapping$
 Wrap=�5�      
���  ��" �� VerticalScrollBarVisibility$
 Auto=�5�      ��5�      �� *Description+5�      5�      �� 5�      -   5         ��Name$ btnAddPicture��5�      $��15q�60   $��ADD PICTURE��6<   6R   �� 5�      -   5        $ 
btnAddRate��5�      $��	15,5,15,0q�6-   $��ADD RATE��6@   6S   5�      5�      5�      5�      