   M S B A M L   `   `   `  ����J  FMySimpleAccount, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MySimpleAccountMySimpleAccount  5   	        MySimpleAccount.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:MySimpleAccount     5   	   -   5          �Name$'  !Главная_страничка��5   	    � Title$ Мой аккаунт��5   	   $	��450��6   $��751.629��6*   ���	#FFF6DBA1 � Icon$ EwdJKitWYAEe_ju.jpg��6Q    � 	Resources 5
         listMenu��%�   &	        �� 5   
   .@�5      m� -   5        $��Добавить��5      6)   m� 5      -   5        $��Удалить��5      6(   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   o� $��2��6   ���	#FF96E876$��Showcard Gothic)�6:   $��18(�6W   .@�5      m� $��Подборки��6   .@�5      m� -   5        $��Игрухи��5      6+   m� 5      -   5        $��Музяка��5      6+   5       5!      �� 5#   
   $��1��6    �� DisplayMemberPath$ NickName��5%       � ContextMenu# [  5&      ���	#FFC6E559 �� SelectedItem 5#      �� *SelectedAccount+��5$      �� *
Accounts+5&   :   �� 5(   
   $��1��6   $��1��6"   	 �� Orientation$	 Vertical=�62   .+�5)      �� $	 Vertical=�5+      
 � DataContext
 5*      �� *SelectedAccount+.+�5,      �� $��Имя��6   �� 5-      ��6   �� *	FirstName+�� 5.      $��Фамилия��6   �� 5/      ��6   �� *
LastName+�� 50      $��Никнейм��6   �� 51      ��6   �� *
NickName+�� 52      $��Дата Создания��6   (  "System.Windows.Controls.DatePicker  53         SelectedDate 6   �� *
Creation+54      �� 55      $��Любимая игра��6   �� 56      $
 Name��58      ��56      �� *Games+ 57      �� *SelectedAccount.Game+58      �� 5:      $!��Любимая музыка��6   �� 5;      $ Title��5=      ��5;      �� *Musics+ 5<      �� *SelectedAccount.Music+5=      5>      5?      5@      