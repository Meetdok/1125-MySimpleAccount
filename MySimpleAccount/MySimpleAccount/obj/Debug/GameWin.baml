   M S B A M L   `   `   `  ����J  FMySimpleAccount, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MySimpleAccountMySimpleAccount  5   	       MySimpleAccount.GameWin   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:MySimpleAccount     5   	   -   5          �Name$  Игрульки��5   	    � Title$ Игры��5   	   $	��450��6   $	��800��6#   ���	#FF68E8D3 � WindowStyle$ 
ToolWindow=�6F    � 	Resources 5
         listMenu��%�   &	        �� 5   
   .@�5      m� -   5        $��Добавить��5      6)   m� 5      -   5        $��Удалить��5      6(   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   ��  �� DisplayMemberPath$
 Name��5       � ContextMenu# [  5      
���   �
���������5      �� *Games+ �� SelectedItem 5      �� *SelectedGame+5   M   �� 5   
   $��1��6    � DataContext 6%   �� *SelectedGame+.+�5      �� $��Название��6   �� 5      ��6   �� *Name+�� 5!      $��Жанр��6   �� 5"      $��24��6   $	��Top=�6$   $��
0,0,-0.2,0q�6<   .@�5#      �� 
Шутер6#   �� 5$      Ужастик6%   �� 5%      Боевик6$   �� 5&      Приключение6)   �� 5'      Платформер6(   5(      �� 5*      $+��%Возвростной рейтинг��6   �� 5+      $��24��6   $	��Top=�6$   $��
0,0,-0.2,0q�6<   .@�5,      �� 18+6!   �� 5-      16+6!   �� 5.      12+6!   �� 5/      6+6    �� 50      0+)))6#   51      �� 53      $��Платформа��6   �� 54      $��24��6   $	��Top=�6$   $��
0,0,-0.2,0q�6<   .@�55      �� PlayStation 4/56-   �� 56      PC6    �� 57      Mobile6$   �� 58      Xbox ONE/S/X6*   59      5:      5;      5<      