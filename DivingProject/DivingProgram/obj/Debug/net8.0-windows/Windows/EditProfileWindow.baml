   M S B A M L   `   `   `  ����H  DDivingProgram, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:DivingProgramDivingProgram  5   	   %    DivingProgram.EditProfileWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:DivingProgram     5   	     � Title$  EditProfileWindow��5   	   $	��946��6#   $	��800��60   .��5	      �� $
��Auto=�6   .��5
   
   � .+�5      �� -   5         ��Name$ email��5      $
��Left=�6%   $��309,239,0,0q�6@   $	��Top=�6U   $	��120��6m   �� 5      -   5        $ lastName��5      $
��Left=�6(   $��309,155,0,0q�6C   $	��Top=�6X   $	��120��6p   �� 5      -   5        $ 	firstName��5      $
��Left=�6)   $��309,121,0,0q�6D   $	��Top=�6Y   $	��120��6q   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ userBirthDate��5      $
��Left=�60   $��309,193,0,0q�6K   $	��Top=�6`   �� 5      $
��Left=�6   $��224,121,0,0q�63   $
��Wrap=�6H   $��First Name:��6\   $	��Top=�6o   �� 5      $
��Left=�6   $��224,155,0,0q�63   $
��Wrap=�6H   $��
Last Name:��6\   $	��Top=�6n   �� 5      $
��Left=�6   $��224,201,0,0q�63   $
��Wrap=�6H   $��	BirthDay:��6\   $	��Top=�6m   �� 5      $
��Left=�6   $��224,241,0,0q�63   $
��Wrap=�6H   $��Email:��6\   $	��Top=�6j   �� 5      $
��Left=�6   $��224,280,0,0q�63   $
��Wrap=�6H   $��	Password:��6\   $	��Top=�6m   G� 5      -   5         G�Name$ password��5      $
��Left=�6,   $��309,279,0,0q�6G   $	��Top=�6\   $	��120��6t   �� 5      -   5        $��Register��5      $
��Left=�6(   $��320,854,0,0q�6C   $	��Top=�6X   6p   �� 5      -   5        $ 
numOfDives��5      $
��Left=�6*   $��309,322,0,0q�6E   $	��Top=�6Z   $��59��6r   �� 5      $
��Left=�6   $��135,324,0,0q�63   $
��Wrap=�6H   $!��Enter number of past dives:��6\   $	��Top=�6   $	��172��6�   �� 5      -   5         ��Name$ rankListBox��5      $��292,432,0,0q�6+   $	��156��6@   $
��Left=�6L   $	��Top=�6g   5      �� 5      $
��Left=�6   $��177,399,0,0q�63   $
��Wrap=�6H   $$��Choose your diver grade level:��6\   $	��Top=�6�   �� 5      $
��Left=�6   $��
86,593,0,0q�63   $
��Wrap=�6G   $*��$Enter date of receipt of your grade:��6[   $	��Top=�6�     5      -	   5        $��gradeReceiptDate��5      $
��Left=�61   $��297,589,0,0q�6L   $	��Top=�6a   �� 5      $
��Left=�6   $��178,650,0,0q�63   $
��Wrap=�6H   $8��2Choose the club you have received your grade from:��6\   $	��Top=�6�   $	��318��6�   �� 5!      -
   5        $ clubListBox��5!      $��187,683,313,243q�6+   $	��300��6D   5#      �� 5%      $
��Left=�6   $��53��63   $��505,420,0,0q�6?   
���   �$	��Top=�6c   $	��172��6{     5&      -   5        $��	dateStart��5&      $
��Left=�6*   $��526,435,0,0q�6E   $	��Top=�6Z   $��23��6r   $y�Hidden=�6~   �� 5'      $
��Left=�6   $��53��63   $��505,511,0,0q�6?   
���   �$	��Top=�6c   $	��172��6{     5(      -   5        $��
dateFinish��5(      $
��Left=�6+   $��526,526,0,0q�6F   $	��Top=�6[   $y�Hidden=�6s   �� 5)      $��
Begin Work��6   $
��Left=�6)   $��505,389,0,0q�6D   $	��Top=�6Y   �� 5*      $��Finish Work��6   $
��Left=�6*   $��505,480,0,0q�6E   $	��Top=�6Z   �� 5,      -   5        $��X��5,      $
��Left=�6!   $��
704,36,0,0q�6<   $	��Top=�6P   $��30(�6h   $��42��6v   6�   �� 5-      $
��Left=�6   $��189,364,0,0q�63   $
��Wrap=�6H   $��Add Your Image:��6\   $	��Top=�6s   �� 5.      -   5        $��Choose From Files��5.      $
��Left=�61   $��299,362,0,0q�6L   $	��Top=�6a   6y   5/      50      51      