   M S B A M L   `   `   `  ����H  DDivingProgram, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:DivingProgram.WindowsDivingProgram.Windows  5   	   )    #DivingProgram.Windows.AddDiveWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:DivingProgram.Windows     5   	   X TXceed.Wpf.Toolkit, Version=4.7.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	     � Title$  AddDiveWindow��5	   	   $	��730��6   $
��1370��6,   .��5
      � .+�5   
   �� -   5        $��X��5      $
��Left=�6   $��1276,42,0,0q�68   $	��Top=�6M   $��30(�6e   $��42��6s   6~   �� 5   
   -   5        $	��←��5      $
��Left=�6   $��	46,42,0,0q�68   $	��Top=�6K   $��30(�6c   $��42��6q   6|   �� 5   
   -   5         ��Name$ clubsListBox��5      $��
192,73,0,0q�6(   $	��250��6<   $
��Left=�6H   $	��Top=�6c   $��16(�6|    J� RenderTransformOrigin$ 0.5,0.5&�5   
   5      �� 5   
   $��Club: ��6   $
��Left=�6!   $��
145,64,0,0q�6<   $	��Top=�6P   $
��Bold"�6h   �� 5   
   $��Dive Date: ��6   $
��Left=�6&   $��
477,67,0,0q�6A   $	��Top=�6U   $
��Bold"�6m   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ diveDate��5      $
��Left=�6'   $��
553,68,0,0q�6B   $	��Top=�6V   �� 5   
   $��Time Started: ��6   $
��Left=�6)   $��478,134,0,0q�6D   $	��Top=�6Y   $
��Bold"�6q   �� 5   
   -   5         ��Name$ startHourText��5      $
��Left=�6)   $��575,139,0,0q�6D    �� TextWrapping$
 Wrap=�6Y   $�� ��6m   $	��Top=�6u   $��30��6�   �� 5   
   $��:��6   $
��Left=�6   $��610,134,0,0q�67   $	��Top=�6L   $
��Bold"�6d   �� 5   
   -   5        $ startMinText��5      $
��Left=�6(   $��628,138,0,0q�6C   $
 Wrap=�6X   $�� ��6l   $	��Top=�6t   $��30��6�   �� 5   
   $��Time Ended: ��6   $
��Left=�6'   $��484,168,0,0q�6B   $	��Top=�6W   $
��Bold"�6o   �� 5   
   -   5        $ EndHourText��5      $
��Left=�6'   $��575,173,0,0q�6B   $
 Wrap=�6W   $�� ��6k   $	��Top=�6s   $��30��6�   �� 5   
   $��:��6   $
��Left=�6   $��610,168,0,0q�67   $	��Top=�6L   $
��Bold"�6d   �� 5   
   -   5        $ 
EndMinText��5      $
��Left=�6&   $��628,172,0,0q�6A   $
 Wrap=�6V   $�� ��6j   $	��Top=�6r   $��30��6�   �� 5   
   $��Water temperature: ��6   $
��Left=�6.   $��
707,67,0,0q�6I   $	��Top=�6]   $
��Bold"�6u   �� 5   
   -	   5        $ waterTempText��5      $
��Left=�6)   $��
839,73,0,0q�6D   $
 Wrap=�6X   $�� ��6l   $	��Top=�6t   $��30��6�   �� 5   
   $��Water Condition: ��6   $
��Left=�6,   $��710,141,0,0q�6G   $	��Top=�6\   $
��Bold"�6t   �� 5   
   -
   5        $ 
genderList��5      $��822,146,0,0q�6&   $��40��6;   $
��Left=�6F   $	��Top=�6a   .@�5      �� $
��Tide��6   �� 5       $	��Low��6   5!      �� 5"   
   $��Diving Sites:��6   $
��Left=�6(   $��
902,67,0,0q�6C   $	��Top=�6W   $
��Bold"�6o   �� 5#   
   -   5        $ 	sitesList��5#      $��989,100,0,0q�6%   $	��220��6:   $
��Left=�6F   $	��Top=�6a   $��16(�6y   $y�Hidden=�6�   5$      �� 5%   
   $��Center=�6   $	��264��61   $��0,42,0,0q�6>   
���   �$	��Top=�6_   $
��1138��6w   5'      5(      