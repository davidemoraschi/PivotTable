   M S B A M L   `   `   `  ����q  mMicrosoft.Samples.WPF.CustomControls.PivotTable, Version=1.0.3596.15666, Culture=neutral, PublicKeyToken=null[2clr-namespace:Microsoft.Samples.WPF.CustomControls$Microsoft.Samples.WPF.CustomControls  5      A    ;Microsoft.Samples.WPF.CustomControls.ColumnsHierarchiesPart   5      W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      Blocal2clr-namespace:Microsoft.Samples.WPF.CustomControls    5      
������   � 	Resources  5       �� MergedDictionaries �� SourceQ  KMicrosoft.Samples.WPF.CustomControls.ColumnHierarchiesLevelTemplateSelector   LevelsTemplateSelector �� 
TargetType  MainItemsControlStyle �� Property �� Value �� 
TargetType  InnerItemsControlStyle  FirstLevelTemplate �� DataType1   +Microsoft.Samples.WPF.CustomControls.ILevel>   8Microsoft.Samples.WPF.CustomControls.SharedSizeDecorator   SharedHeightGroup	   Child@   :Microsoft.Samples.WPF.CustomControls.MembersFilterTreeView
   Level  DefaultLevelTemplate �� Padding �� TextAlignment �� Path  HierarchyTemplate5   /Microsoft.Samples.WPF.CustomControls.IHierarchy  HorizontalAxisElementsBrush�� 5       5      �� 5	      $ Resources.xaml?�6   %a  &	        &	      &	 �     &	 u    &	 9    &	 ]    7  7   7    5      62   �� 5      " ��6   .�5      ��  � �� 5      �� 5      " ��6   .R�5   	   �� 
���   �$��
0, 1, 0, 0q�6$   ._�5   
   �� 5   
   5   	   5      5      �� 5      " ��6   .�5      ��  � ��$ 0q�6    �� 5       � �� 5      �� 5      " ��6   .R�5   	   �� 5    	   5"      5#      �� 5%      "  6-   .R�5&        $) #ColumnsHierarchiesPart_SharedHeight��6    .	 5'      �� $��
0, 0, 1, 0q�6   
���   �._�5(        
 6$   �� 5)      5*      5+      �� 5-      "  6/   .R�5.        $) #ColumnsHierarchiesPart_SharedHeight��6    .	 5/      �� $��
0, 0, 1, 0q�6   
���   �._�50      � 
������ .+�51   	   �� $ 
4, 1, 4, 1q�6   $ Center=�6F   ��6(   �� $ Caption�6F   52   	   53      54      55      �� 57      "  59      .R�5:      � 8��  .+�5;      �� 8�� 8�� ��5=      �� $ Levels���5?      �� 5@   	   .R�5A   
   ]� 5B   
   5D      5E      5F      5G      .��5J      ]� ��.  $��Bottom=�6#   .+�5K      �� -   5        $��HierarchiesItemsControl��5M      $
��Left=�5L      #��[ 5O      #��[ 5P      ��5N      �� $ Hierarchies���5R      �� 5S      .R�5T      ��  �� Orientation$ 
Horizontal=�6   5U      5W      5X      5Z      