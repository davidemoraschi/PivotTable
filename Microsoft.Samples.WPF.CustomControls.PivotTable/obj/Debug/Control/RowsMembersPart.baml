   M S B A M L   `   `   `  ����q  mMicrosoft.Samples.WPF.CustomControls.PivotTable, Version=1.0.3596.15666, Culture=neutral, PublicKeyToken=null[2clr-namespace:Microsoft.Samples.WPF.CustomControls$Microsoft.Samples.WPF.CustomControls  5      :    4Microsoft.Samples.WPF.CustomControls.RowsMembersPart   5      W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      Blocal2clr-namespace:Microsoft.Samples.WPF.CustomControls    5      
������   � 	Resources  5       �� MergedDictionaries �� SourceW  QMicrosoft.Samples.WPF.CustomControls.CollectionViewGroupToSharedSizeNameConverter   SharedHeightConverter  DescriptionTextBlockStyle �� 
TargetType �� Property �� Value �� Triggers �� Binding �� Path	 �� Value
 �� 
TargetType>   8Microsoft.Samples.WPF.CustomControls.SharedSizeDecorator   SharedHeightGroup �� 	Converter   Child �Name  VerticalAxisElementsBrush � ColumnDefinitions � RowDefinitions   SharedWidthGroup �� Orientation d�Name  TreeViewToggleButtonStyle �� 	ClickMode ��Name ��Name �� Triggers �� 
TargetName�� 5       5	      �� 5
      $ Resources.xaml?�6   %�  &	        &	      'R� J    'Q� <    7   7  7    5      68   �� 5      " ��6-   .�5      ��  � ��$ Center=�6,   �� 5       � ��$ Center=�6*   �� 5       � y�$ 	Collapsed=�6#   �� 5       � ��$ 4q�6    5      �� 5       6   �� $ Count�	 062   .a�5      ��  � y�$ Visible=�6%   5      5      �� 5      " R�6   .�5      ��  � ��$ 0q�6    �� 5       � �� 5      �� 5       .R�5!   	   �� $��
0, 0, 0, 1q�6   
���   �#��z��5"   
   #��z��60   ._�5#   
   �� 5$   
   5%   	   5'      5(      �� 5+      " Q�6   .�5,      ��  � �� 5-      �� 5.      "
 Q�6   .R�5/   	      6#   �� 8   . 50   
   � $
 Grid��6   8��  51      �� 52      �� 53       55      �� 56      .+�59        $��0��6]   $��0��6j    6%   �� $ Name.Level.UniqueName�. 5:      �� $��Center=�6   $��0��62   $��0��6B   $ 
Horizontal=�6O   .+�5;      d� $ Expander��6   -   5        8�� $ Press=�5=      5>      �� 5?      $��0��6   $��Header��6.   $
��5, 1q�6E   5@      5A      �� 5B      $ 	ItemsHost��67   $��1��6   $��0��6*   67   �� 5C      $ Border��6   $��2��6"   
���   �$��
1, 1, 0, 0q�6K   5D      5E   
    5F   	   �� 5G   
   $	 false��6A    6   �� $ Name.IsExpandable�.a�5H      �� $ Expander��6    � y�$ Hidden=�6>   5I      �� 5J   
   $
	 true��6E    6   �� $ Name.IsAggregateGroup�.a�5K      �� $ Border��6    � ��$ 0q�6A   �� 5L      $ 	ItemsHost��6    � y�$ Visible=�6?   �� 5M      $
 Grid��6    � ��
 ���� 6:   5N      �� 5O   
   $
	 true��6=    6   �� $ IsBottomLevel�.a�5P      �� $ Expander��6    � y�$ 	Collapsed=�6>   �� 5Q      $ 	ItemsHost��6    � y�$ 	Collapsed=�6?   5R      5T   	   5V      5W      5X      .��5\      �� 
���   �$��
0, 0, 1, 1q�6   ._�5]      � .+�5^      �� #��[ 6   Drop row hierarchies here6]   ]� 5_      ��.  .+�5`      R� -   5        $��RowsTreeView��5`   $   $	��Top=�6   ��68   �� $ Groups�  5a       �� DataType-  'System.Windows.Data.CollectionViewGroup �� ItemsSource��%�   (��       5c      *, +)�� 5b      "  5c       5d      �� $ Items�.R�5e   	   �� ��6   �� $ Name.Caption�5f   	   5g      5h      5i      5j      5k      5m      