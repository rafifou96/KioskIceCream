   M S B A M L   `   `   `  ����H  DIceCreamKiosk, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:IceCreamKioskIceCreamKiosk  5      E ADragablz, Version=0.0.3.203, Culture=neutral, PublicKeyToken=null5(clr-namespace:Dragablz;assembly=DragablzDragablz 5          IceCreamKiosk.App   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      -localclr-namespace:IceCreamKiosk     5      =dragablz(clr-namespace:Dragablz;assembly=Dragablz     5        �� 	Resources  5       �� MergedDictionaries �� Source   Key  
Primary100 �� Color  Primary100Foreground  
Primary500  Primary500Foreground  
Primary700  Primary700Foreground  	Accent200  Accent200Foreground  Dragablz.TabablzControl �� 
TargetType %	 !MaterialDesignTabablzControlStyle �� BasedOn 
 ScrollThumbs �� Property �� Value �� 
TargetType	 �Name
 ��Name �� CornerRadius �� Triggers P� Property P� Value �� 
TargetName ]�Name ]� Thumb n�Name ]� IncreaseRepeatButton ��Name J� Opacity ]� DecreaseRepeatButton �� Angle�� 5	   
    5
      �� 5       5      �� 5      $b \pack://application:,,,/MaterialDesignColors;component/Themes/MaterialDesignColor.purple.xaml?�6-   �� 5      PrimaryHueLightBrush  # [ 6C   �� 5      "PrimaryHueLightForegroundBrush  # [ 6M   �� 5      PrimaryHueMidBrush  # [ 6A   �� 5       PrimaryHueMidForegroundBrush  # [ 6K   �� 5      PrimaryHueDarkBrush  # [ 6B   �� 5      !PrimaryHueDarkForegroundBrush  # [ 6L   5!      �� 5$       5&      �� 5'      $b \pack://application:,,,/MaterialDesignColors;component/Themes/MaterialDesignColor.purple.xaml?�6-   �� 5+      SecondaryAccentBrush  # [ 6C   �� 5,      "SecondaryAccentForegroundBrush  # [ 6M   5-      �� 50      $J Dpack://application:,,,/Dragablz;component/Themes/materialdesign.xaml?�6%   �� 51      $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Defaults.xaml?�6%   %V  '        7 	 &	
 "     '�� }    7 
 �� 5=      "  6   8   6B   �� 5?      " n�6)   .�5@      ��  � �� 5A      �� 5B      " n�6*   .R�5C      � $
	 Grid��6#   .+�5D   "   �� $��Stretch=�6,   $��Stretch=�6J   $
��Auto��6f   $
��Auto��6s   
������ 6�   �� 5E   "   $
 ScrollBarRectangle��6)   $ 5��6E   $��Stretch=�6V   $��Stretch=�6t   $
��Auto��6�   $
��Auto��6�   #��z��6�   5F       5G      P� 5H   "    �@�Tag$ 
Horizontal��69   . �5I   &   �� $ ScrollBarRectangle��6-    � ��$
 Auto��6^   �� 5J   &   $ ScrollBarRectangle��6-    � ��$ 7��6_   5K   #   5M      5O      5P      �� 5Q      " ��6   .�5R      ��  � ��$ -5,0,0,0q�6+   �� 5S       �@��IsFlicksEnabled .  6;   �� 5T       � �� �	#FF8C8C8C6/   �� 5U       � ��
 ���� 6/   �� 5V       � ��$ 8��6*   �� 5W       � �� 5X      �� 5Y      " ��6*   .R�5Z      � $	 GridRoot��6#   $��8��65   #��z��6?   .+�5[   "   ]� $ 
PART_Track��6(   ��. |�.   5\   &   n� 5]   *   $ ScrollBarThumb��60   #��z��6H   8��  6r    5_   &   �� 5`   *   $ PageUp��67   $��ScrollBar.PageDownCommand��6G   $ 0Q�6k   |�.  6w    5b   &   �� 5c   *   $ PageDown��67   $��ScrollBar.PageUpCommand��6I   $ 0Q�6k   |�.  6w   5e   #   5f       5h      P� 5i   "    � {� .  . �5j   &   �� $ ScrollBarThumb��6-    � y�$ 	Collapsed=�6_   5k   #   P� 5l   "    �@��Orientation$ 
Horizontal=�6A   . �5m   &   �� $ GridRoot��6-    �@�LayoutTransform 5n   *   �� 5o   .   $	 -90Q�6>   5q   '   �� 5r   &   $ 
PART_Track��6-    �@�LayoutTransform 5s   *   �� 5t   .   $	 -90Q�6>   5v   '   �� 5w   &    � ��$
 Auto��6>   �� 5x   &    � ��$ 8��6?   �� 5y   &   $ ScrollBarThumb��6-    �@�Tag$ 
Horizontal��6X   �� 5z   &   $ PageDown��6-    � ��$ ScrollBar.PageLeftCommand��6V   �� 5{   &   $ PageUp��6-    � ��$  ScrollBar.PageRightCommand��6T   5|   #   5~      5�      5�      5�      5�      