   M S B A M L   `   `   `  ����F  BSalesWPFApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SalesWPFAppSalesWPFApp  5   	       SalesWPFApp.LoginView   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:SalesWPFApp     5   	     � Title$  	LoginView��5   	   $	��450��6   $	��800��6(   .��5	      � .+�5
   
   �  � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      �� $��Username��6   $��0��6'   $
��Left=�64   $��Center=�6O   $��30q�6j   �� 5      $��Password��6   $��1��6'   $
��Left=�64   $��Center=�6O   $��30q�6j   �� 5      -   5         ��Name$ txtUsername��5      $��0��6+   $��Stretch=�68   $��Center=�6V   $��
120,0,30,0q�6q   G� 5      -   5         G�Name$ txtPassword��5      $��1��6/   $��Stretch=�6<   $��Center=�6Z   $��
120,0,30,0q�6u   �� 5      -   5        $��Login��5      $��2��6%   $��Center=�62   $��Center=�6O   $	��100��6j   $��0,20,0,0q�6v   6�   �� 5      -   5         ��Name$ txtError��5      $��3��6*   $��Center=�67   $��Center=�6T   
���  �� �� TextAlignment$ Center=�6�   $��0,10,0,0q�6�   5      5      5      