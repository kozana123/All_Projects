   M S B A M L   `   `   `  ����Y  USafeDevelopmentSemesterProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:SafeDevelopmentSemesterProjectSafeDevelopmentSemesterProject  5   	   3    -SafeDevelopmentSemesterProject.RegisterWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:SafeDevelopmentSemesterProject     5   	     � Title$  RegisterWindow��5   	   $	��738��6    $	��589��6-   ��5	      �� 5
   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/    �� RelativeTransform 5      V� 5      .~�5      ��  �� CenterY$	 0.5Q�6%    �� CenterX$	 0.5Q�63   �� 5       �� CenterX$	 0.5Q�6$    �� CenterY$	 0.5Q�62   �� 5       �� Angle$ 90Q�6&   	 �� CenterX$		 0.5Q�61   
 �� CenterY$	
 0.5Q�6?   T� 5      5      .��5      �  � Color$ 	#FFD6233C��6    � Offset$	 0.7Q�6-   � 5      $ 	#FFDA455A��6   $ 1Q�6-   � 5      $ 	#FFDA455A��6   $ 0Q�6-   � 5      $ 	#FFD6233C��6   $	 0.3Q�6-   5      .��5      � .+�5   
   �� $
��Left=�6   $��
234,86,0,0q�6/   $
��Wrap=�6C   $��Name:��6W   $	��Top=�6d   $��Comic Sans MS)�6|   �� 5   
   -   5         ��Name$ nameText��5      $
��Left=�6$   $��
294,85,0,0q�6?   $	��Top=�6S   $	��120��6k   $��Comic Sans MS)�6w   �� 5   
   $
��Left=�6   $��216,126,0,0q�6/   $
��Wrap=�6D   $��
BirthDate:��6X   $	��Top=�6j   $��Comic Sans MS)�6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ userBirthDate��5      $
��Left=�6,   $��294,122,0,0q�6G   $	��Top=�6\   $��Comic Sans MS)�6t   �� 5!   
   $
��Left=�6   $��238,170,0,0q�6/   $
��Wrap=�6D   $��Email:��6X   $	��Top=�6f   $��Comic Sans MS)�6~   �� 5"   
   -   5        $ 	emailText��5"      $
��Left=�6%   $��294,169,0,0q�6@   $	��Top=�6U   $	��120��6m   $��Comic Sans MS)�6y   �� 5$   
   $
��Left=�6   $��216,213,0,0q�6/   $
��Wrap=�6D   $��	Password:��6X   $	��Top=�6i   $��Comic Sans MS)�6�   G� 5%   
   -   5         G�Name$ passwordText��5%      $
��Left=�6,   $��294,212,0,0q�6G   $	��Top=�6\   $	��120��6t   $��Comic Sans MS)�6�   �� 5'   
   $
��Left=�6   $��182,284,0,0q�6/   $
��Wrap=�6D   $��Add Your Image:��6X   $	��Top=�6o   $��Comic Sans MS)�6�   �� 5(   
   -   5        $��Choose From Files��5(      $
��Left=�6-   $��296,285,0,0q�6H   $	��Top=�6]   $��Comic Sans MS)�6�   �� 5*   
   $
��Left=�6   $��158,331,0,0q�6/   $
��Wrap=�6D   $	��Top=�6X   $��Choose your gender:��6p   $��Comic Sans MS)�6�   �� 5+   
   -   5         ��Name$ 
genderList��5+      $��296,332,0,0q�6&   $��56��6;   $
��Left=�6F   $	��Top=�6a   $��Comic Sans MS)�6z   .@�5,      �� $
��Male��6   �� 5-      $��Female��6   �� 5.      $��Other��6   5/      �� 51   
   $
��Left=�6   $��152,420,0,0q�6/   $
��Wrap=�6D   $��Search your city:��6X   $	��Top=�6q   $��Comic Sans MS)�6�   �� 52   
   -   5        $ citySearchText��52      $
��Left=�6*   $��254,419,0,0q�6E    �� TextWrapping$
 Wrap=�6Z   $�� ��6n   $	��Top=�6v   $	��184��6�   $��Comic Sans MS)�6�   �� 53   
   -   5        $ cityListBox��53      $��214,467,0,0q�6'   $	��150��6<   $
��Left=�6H   $	��Top=�6c   $	��150��6{   $��Comic Sans MS)�6�   55      �� 57   
   -	   5        $��X��57      $
��Left=�6   $��
518,33,0,0q�68   $	��Top=�6L   $��20(�6d   $��31��6�   $��Comic Sans MS)�6�   �� 58   
   -
   5        $	��←��58      $
��Left=�6   $��	47,33,0,0q�68   $	��Top=�6K   $��20(�6c   $��31��6q   $��Comic Sans MS)�6�   �� 59   
   -   5        $��Register��59      $��Center=�6$   $��	0,666,0,0q�6A   $	��Top=�6T   $��Comic Sans MS)�6�   �� 5:   
   $
��Left=�6   $��232,249,0,0q�6/   $
��Wrap=�6D   $��Phone:��6X   $	��Top=�6f   $��Comic Sans MS)�6~   �� 5;   
   -   5        $ userPhoneText��5;      $
��Left=�6)   $��294,248,0,0q�6D   $	��Top=�6Y   $	��120��6q   $��Comic Sans MS)�6}   5=      5>      