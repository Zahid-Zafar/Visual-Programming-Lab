   M S B A M L   `   `   `  ����N  JT1 Shipping-Address, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:T1_Shipping_AddressT1_Shipping_Address  5   	   $    T1_Shipping_Address.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:T1_Shipping_Address     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� $��Select Shipping Address:��6   $��10q�64   $	��Top=�6@   �� 5   
   -   5         ��Name$ AddressComboBox��5      $��
10,30,10,0q�5      $	��Top=�5       �� SelectedItem 5      �� *SelectedShippingAddress+ �� Mode$ TwoWay=�5      �� 5   
   -   5        $��Add New Address��5      $
��Left=�6+   $��	10,70,0,0q�6F   $	��Top=�5      $	��120��6)   65   �� 5   
   -   5        $��Update Address��5      $��Right=�6*   $��	0,70,10,0q�6F   $	��Top=�5      $	��120��6)   65   �� 5   
   $ ��Selected Shipping Address:��6   $��
10,120,0,0q�66   $	��Top=�6J   �� 5   
   -   5         ��Name$ TextBox��5      $��10,150,10,0q�6#   $	��Top=�68    �� 
IsReadOnly . ��5   $   �� *SelectedShippingAddress+6M   5      5      