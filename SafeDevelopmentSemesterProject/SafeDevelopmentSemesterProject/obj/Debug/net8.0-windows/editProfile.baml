   M S B A M L   `   `   `  ����Y  USafeDevelopmentSemesterProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:SafeDevelopmentSemesterProjectSafeDevelopmentSemesterProject  5   	   0    *SafeDevelopmentSemesterProject.editProfile   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:SafeDevelopmentSemesterProject     5   	     � Title$  editProfile��5   	   $	��640��6   $	��800��6*   ��5	      �� 5
   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/    �� RelativeTransform 5      V� 5      .~�5      ��  �� CenterY$	 0.5Q�6%    �� CenterX$	 0.5Q�63   �� 5       �� CenterX$	 0.5Q�6$    �� CenterY$	 0.5Q�62   �� 5       �� Angle$ 90Q�6&   	 �� CenterX$		 0.5Q�61   
 �� CenterY$	
 0.5Q�6?   T� 5      5      .��5      �  � Color$ 	#FFD6233C��6    � Offset$	 0.7Q�6-   � 5      $ 	#FFDA455A��6   $ 1Q�6-   � 5      $ 	#FFDA455A��6   $ 0Q�6-   � 5      $ 	#FFD6233C��6   $	 0.3Q�6-   5      .��5      � .+�5   
   �� -   5        $��gender��5      $
��Left=�6"   $��
154,43,0,0q�6=   $
��Wrap=�6Q   $	��Top=�6e   $��Choose your gender:��6}   $��Comic Sans MS)�6�   �� 5   
   -   5         ��Name$ 
genderList��5      $��
293,41,0,0q�6&   $��56��6:   $
��Left=�6E   $	��Top=�6`    �� SelectedValuePath$ Content��6x   $��Comic Sans MS)�6�   .@�5      �� $
��Male��6   �� 5      $��Female��6   �� 5      $��Other��6   5       �� 5!   
   $
��Left=�6   $��154,125,0,0q�6/   $
��Wrap=�6D   $��Connections:��6X   $	��Top=�6l   $	��110��6�   $��Comic Sans MS)�6�   �� 5"   
   -   5        $ typeConnection��5"      $��284,121,0,0q�6*   $	��126��6?   $��Comic Sans MS)�6K   $
��Left=�5#   
   $	��Top=�6%   $��96��6=   $ Content��5$   
   .@�5%      �� $��New friends��6   �� 5&      $��Long-term dating��6   �� 5'      $��Short-term dating��6   �� 5(      $��Hookups��6   5)      �� 5*   
   -   5        $��
heightUser��5*      $
��Left=�6$   $��287,246,0,0q�6?    �� TextWrapping$
 Wrap=�6T   $�� ��6h   $	��Top=�6p   $	��120��6�   �� 5+   
   $
��Left=�6   $��181,247,0,0q�6/   $
��Wrap=�6D   $��Height: ��6X   $	��Top=�6h   $��Comic Sans MS)�6�   �� 5,   
   $
��Left=�6   $��176,312,0,0q�6/   $
��Wrap=�6D   $��
Religion: ��6X   $	��Top=�6j   $��Comic Sans MS)�6�   �� 5-   
   -   5        $ religion��5-      $��284,303,0,0q�6$   $	��126��69   $
��Left=�6E   $	��Top=�6`   $��96��6x   $ Content��6�   $��Comic Sans MS)�6�   .@�5.      �� $��Atheism��6   �� 5/      $��
Christiany��6   �� 50      $��Judaism��6   �� 51      $��Islam��6   �� 52      $��Budahism��6   �� 53      $��
Catholisem��6   54      �� 55   
   -   5        $��YesCheckBox��55      $	��Yes��6'   $
��Left=�65   $��284,446,0,0q�6P   $	��Top=�6e   $��Comic Sans MS)�6}   6�   �� 56   
   -   5        $��
NoCheckBox��56      $��No��6&   $
��Left=�63   $��329,446,0,0q�6N   $	��Top=�6c   $��Comic Sans MS)�6{   6�   �� 57   
   $
��Left=�6   $��181,445,0,0q�6/   $
��Wrap=�6D   $��Smoking��6X   $	��Top=�6g   $��Comic Sans MS)�6   �� 58   
   -   5        $
��Save��58      $
��Left=�6    $��309,531,0,0q�6;   $	��Top=�6P   $��65��6h   $��16(�6s   $��Comic Sans MS)�6�   �� 59   
   -	   5        $��Delete Profile��59      $
��Left=�6*   $��630,531,0,0q�6E   $	��Top=�6Z   $��16(�6r   $��Comic Sans MS)�6�   �� 5;   
   -
   5        $��X��5;      $
��Left=�6   $��
732,33,0,0q�68   $	��Top=�6L   $��20(�6d   $��32��6�   $��Comic Sans MS)�6�   �� 5<   
   -   5        $	��←��5<      $
��Left=�6   $��	47,33,0,0q�68   $	��Top=�6K   $��20(�6c   $��31��6q   $��Comic Sans MS)�6�   5>      5?      