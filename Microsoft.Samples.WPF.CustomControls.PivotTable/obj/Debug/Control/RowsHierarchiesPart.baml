   M S B A M L   `   `   `  ����q  mMicrosoft.Samples.WPF.CustomControls.PivotTable, Version=1.0.3596.15666, Culture=neutral, PublicKeyToken=null[2clr-namespace:Microsoft.Samples.WPF.CustomControls$Microsoft.Samples.WPF.CustomControls  5      >    8Microsoft.Samples.WPF.CustomControls.RowsHierarchiesPart   5      W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      Blocal2clr-namespace:Microsoft.Samples.WPF.CustomControls    5      
������   � 	Resources  5       �� MergedDictionaries �� SourceO  IMicrosoft.Samples.WPF.CustomControls.RowsHierarchiesLevelTemplateSelector   LevelsTemplateSelector �� 
TargetType  MainItemsControlStyle �� Property �� Value �� 
TargetType  InnerItemsControlStyle  FirstLevelTemplate �� DataType1   +Microsoft.Samples.WPF.CustomControls.ILevel>   8Microsoft.Samples.WPF.CustomControls.SharedSizeDecorator   SharedHeightGroup	   SharedWidthGroup
 �� Path   Child@   :Microsoft.Samples.WPF.CustomControls.MembersFilterTreeView  VerticalAxisElementsBrush   Level  DefaultLevelTemplate �� Padding �� TextAlignment  HierarchyTemplate5   /Microsoft.Samples.WPF.CustomControls.IHierarchy �� Orientation�� 5       5
      �� 5      $ Resources.xaml?�6   %�  &	        &	      &	 �     &	 �    7  &	 �    7  &	 �    7   7    5      60   �� 5      " ��6   .�5      ��  � ��$ 0q�6    �� 5       � �� 5      �� 5      " ��6   .R�5   	   �� 
���   �$��
0, 0, 1, 0q�6$   ._�5   
   �� 5   
   5   	   5      5      �� 5      " ��6   .�5      ��  � ��$ 0q�6    �� 5       � �� 5       �� 5!      .R�5"   	   �� 5#   	   5%      5&      �� 5(      "  6-   .R�5)        $&  RowsHierarchiesPart_SharedHeight��5*      	 5)       �� $
 
UniqueName�. 5+      �� $��
1, 1, 0, 0q�6   
���   �._�5,        8��   6$   �� 66   5-      5.      5/      �� 51      "  6/   .R�52        $&  RowsHierarchiesPart_SharedHeight��53      	 52       �� $
 
UniqueName�. 54      �� $��
1, 1, 0, 0q�6   
���   �._�55      � 8��  .+�56   	   �� $ 
4, 1, 4, 1q�6   $ Center=�6F   ��6(   �� $
 Caption�6F   57   	   58      59      5:      �� 5<      "  5>      .R�5?      �� 8��  8�� ��5A      �� $
 Levels���5C      �� 5D      .R�5E   	   �� $ 
Horizontal=�6   5F   	   5H      5I      5K      .��5N      �� -   5        $��HierarchiesItemsControl��5O      #��[ 5Q      #��[ 5R      $��Bottom=�5S      ��5P      �� $
 Hierarchies���5U      �� 5V      .R�5W      �� $ 
Horizontal=�6   5X      5Z      5[      