   M S B A M L   `   `   `  ����G  Cpraktika1_EF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:praktika1_EFpraktika1_EF  5          praktika1_EF.First   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:praktika1_EF     5        N� Title$  First��5	      .��5      � $��0,10,0,0q�6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ SushiDataGrid��5      $��0��6*   $��2��67   �� 5   
   -   5        $#��Добавить данные��5      $��3��6D   $��0��6Q   $
��left=�6a   $	��Top=�6|   $��10q�6�   �� 5   
   -   5        $!��Удалить данные��5      $��3��6A   $��1��6N   $
��left=�6^   $	��Top=�6y   $��10q�6�   �� 5   
   -   5        $��Закрыть окно��5      $��3��6E   $��1��6R   $��right=�6b   $	��Top=�6~   $��10q�6�   �� 5   
   -   5        $#��Обновить данные��5      $��3��6:   $��1��6G   $��center=�6W   $	��Top=�6t   $��10q�6�   �� 5   
   -   5         ��Name$ NameTbx��5      $��1��6#   $��10q�60   ��6<   �� *SelectedItem.TITLE+ �� ElementName$ SushiDataGrid���� 5   
   -   5        $ WorkingHourse��5      $��2��6)   $��10q�66   $��0��6B   ��6R   �� *SelectedItem.WORKINGHOURSE+$ SushiDataGrid���� 5   
   -   5        $ TitleTbx��5      $��1��6$   $��1��61   $��10q�6A   ��6M   �� *SelectedItem.TITLE+$ SushiDataGrid���� 5    
   -	   5        $ WH��5       $��2��6   $��2��6+   $��10q�6;   ��6G   �� *SelectedItem.WORKINGHOURSE+$ SushiDataGrid��5"      5#      