   M S B A M L   `   `   `  ����B  >BankCA2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:BankCA2BankCA2  5   	       BankCA2.DepositFunds   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:BankCA2     5   	     � Title$  DepositFunds��5   	   $��526.3��6   $��988.2��6-   .��5	      � $��0,0,23.8,26q�6    � RowDefinitions 5
   
   �� 5      $
��485* �6   �� 5      .+�5   
   �� $��Account no:��6   $
��Left=�6&   $��
120,54,0,0q�6A   $	��Top=�6U   $��20(�6m   $��
Calisto MT)�6{   $��34��6�   $	��115��6�   �� 5   
   -   5         ��Name$ cboacc��5      $
��Left=�6#   $��
260,54,0,0q�6>   $	��Top=�6R   $	��115��6j   $��33��6�   $��20(�6�   �� 5   
   $��Amount��6   $
��Left=�6!   $��120,166,0,0q�6<   $	��Top=�6Q   $��20(�6i   $��Maiandra GD)�6w   $��34��6�   $��82��6�   �� 5   
   -   5         ��Name$ 	txtamount��5      $
��Left=�6%   $��27��6@   $��260,166,0,0q�6L    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��115��6�   $��20(�6�   �� 5   
   -   5         ��Name$ 
btndeposit��5      $��Deposit��6%   $
��Left=�67   $��100,249,0,0q�6R   $	��Top=�6g   $	��135��6   $��60��6�   $��20(�6�   6�   �� 5   
   $��Balance��6   $
��Left=�6"   $��120,102,0,0q�6=   $	��Top=�6R   $��20(�6j   $��34��6x   $��82��6�   �� 5   
   -   5        $ 
txtbalance��5      $
��Left=�6&   $��28��6A   $��260,108,0,0q�6M   $
 Wrap=�6b   $��
��6v   $	��Top=�6�   $	��115��6�    �� 
IsReadOnly . $��20(�6�   
������� �� SelectionBrush
 �����6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ datagrid��5      $
��Left=�6%   $��88��6@   $��
20,335,0,0q�6L   $	��Top=�6`   $	��920��6x   �� 5   
   -   5        $ 
btnrefresh��5      $
��🔄��6%   $
��Left=�62   $��
415,50,0,0q�6M   $	��Top=�6a   $��35��6y   $��35��6�   
�������$��24(�6�   
�������	 J� OpacityMask
	 �����6�   �� 5   
   $��Deposit��6   $
��Left=�6"   $��	474,0,0,0q�6=   $	��Top=�6P   $��30(�6h   $��Adobe Garamond Pro)�6v   ���	#FF18433B6�   5      5      