   M S B A M L   `   `   `  ����T  Psession10-entityframework, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:session10_entityframeworksession10_entityframework  5   	   ,    &session10_entityframework.CustomerForm   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:session10_entityframework     5   	   -   5          � Title$  CustomerForm��5   	   $	��350��6   $	��500��6+   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �  � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $��* �6#    5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      �� $��0��6   $��0��6!   $��Customer Id��61   �� 5      -   5         ��Name$ CustomerIdLabel��5      $��0��6-   $��1��6:   ��5      �� *Customer.Id+�� 5      $��Customer Name��6   $��1��6,   $��0��69   �� 5      -   5         ��Name$ CustomerLastName��5      $��1��60   $��1��6=   ��5      �� *Customer.LastName+�� 5       $��Customer Phone��6   $��2��6-   $��0��6:   �� 5!      -   5        $ CustomerPhone��5!      $��2��6-   $��1��6:   ��5"      �� *Customer.Phone+�� 5#      $��Customer Email��6   $��3��6-   $��0��6:   �� 5$      -   5        $ CustomerEmail��5$      $��3��6-   $��1��6:   ��5%      �� *Customer.Email+�� 5&      $��4��6   $��0��6!   $��Recent orders��61   �� 5'      -   5         ��Name$ 
OrdersList��5'      $��4��6*   $��1��67   $	��100��6G   ��5(      �� *
OrderDates+5)   G   5+      &   System.Windows.Controls.DataGrid  5,   
   -   5          Name$ OrderItemsDataGrid��5,         AutoGenerateColumns .  $��2��5.      ��5,   /   �� *
OrderItems+   Columns 5/      0  *System.Windows.Controls.DataGridTextColumn  50      -   5        idColumn��,  &System.Windows.Controls.DataGridColumn	   Header$	 Id��51   %   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 50   7   �� *Id+51   %     52      -	   5        instructionColumn��$	 Instructions��53   %   
 52   @   �� *Instructions+53   %     54      -
   5        productIdColumn��$	 
Product Id��55   %   
 54   >   �� *	ProductId+55   %     56      -   5        quantityColumn��$	 Quantity��57   B   
 6%   �� *
Quantity+6B     58      -   5        storeIdColumn��$	 StoreId��58   X   
 6<   �� *	StoreId+6X     59      -   5        totalPriceColumn��$	 
TotalPrice��59   ^   
 6?   �� *
TotalPrice+6^     5:      -   5        unitPriceColumn��$	 	UnitPrice��5:   \   
 6>   �� *	UnitPrice+6\   5>      5?      5@      