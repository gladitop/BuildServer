   M S B A M L   `   `   `  ����F  BBuildServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:BuildServerBuildServer  5   	       BuildServer.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:BuildServer     5   	   -   5          � Title$  BuildServer: Main menu��5   	   $	��450��6(   $	��450��65   $	��800��6E    � WindowStartupLocation$ CenterScreen=�6T   $	��800��6y   .��5	      � .+�5
   
   �� -   5         ��Name$ 
listserver��5
   )    �� SelectionMode$ Single=�6   $
��Left=�6=   $	��155��6X   $��0,0,0,63q�6d   6v   �� 5   
   -   5         ��Name$ btaddserver��5       � ToolTip$ 
Add server��6&   $��2,0,0,9q�6;   $
��Left=�6L   $��75��6g   $��49��6r   $��Bottom=�6~   .��5      ��  �� Orientation$ 	 Vertical=�6   .+�5      �� $��Resources\AddServer.png��6   $��36��69   $��36��6E   5      5      �� 5   
   -   5        $ btdeleteserver��5      $ Delete server��6)   $
��Left=�6A   $��82,0,0,9q�6\   $��75��6n   $��49��6y   $��Bottom=�6�   .��5      �� $ 	 Vertical=�6   .+�5      �� $ ��Resources/DeleteServer.png��6   $��36��6<   $��36��6H   5      5      � 5   
   ���	#FF41BFBD$��155,0,-0.4,0q�6&   $��51��6<   $	��Top=�6H   .+�5      �� -   5         ��Name$ imagesstartserver��5      $
{�True��6/   $ Start server��6@   $��Resources/StartBt.png��6W   $��51��6v   $��0,-0.8,9.4,-0.6q�6�   $	��Top=�6�   $��Right=�6�   $��51��6�   �� 5      $
{�True��6   $ Settings the server��6%   $��Resources/Settings.png��6C   $��51��6c   $��	0,-1,65,0q�6o   $	��Top=�6�   $��Right=�6�   $��51��6�   �� 5      -   5        $ btssettings��5      $��Button��6*   $��0,0,65,0q�6;   $	��Top=�6M   $��50��6e   $��Right=�6�   $��51��6�    J� Opacity$ 0Q�6�   �� 5      -   5        $ btstartserver��5      $�� ��6,   $ 0Q�67   $��Right=�6C   $��	0,0,9.4,0q�6_   $	��Top=�6r   $��51��6�   $��51��6�   6�   5      �� 5   
   $��155,51,9.6,10q�6   .@�5      �� $��Information��6   .��5      � ���	#FFE5E5E5.+�5      �� -   5        	 ��Name$	 lbnameserver��5      $��Name:��62   $��30(�6B   $
��Left=�6P   $��	10,10,0,0q�6k   $	��Top=�6~   $	��542��6�   �� 5      -	   5        $	 lbtypeConnectserver��5      $��Type connect:��69   $��30(�6Q   $
��Left=�6_   $��	10,61,0,0q�6z   $	��Top=�6�   $	��542��6�   �� 5       -
   5        $	 lbpathCertificateserver��5       $��Path certificate:��6=   $��30(�6Y   $��10,112,69,0q�6g   $	��Top=�6|   �� 5!      -   5        $ btlbpathCertificateserver��5!      $	��...��6@   $��
0,112,10,0q�6N   $��Right=�6�   $��31��6�   $��46��6�   $	��Top=�6�   �� 5"      -   5        $	 lbpathserver��5"      $��Path server:��62   $��30(�6I   $��10,163,69,0q�6W   $	��Top=�6l   �� 5#      -   5        $ btlbpathserver��5#      $	��...��65   $��
0,171,10,0q�6C   $	��Top=�6W   $��46��6o   $��Right=�6�   $��31��6�   �� 5$      $��Open description server:��6   $��30(�6?   $
��Left=�6M   $��
10,214,0,0q�6h   $	��Top=�6|   $	��343��6�   �� 5%      -   5        $ btopendescriptionserver��5%      $	��...��6>   $
��Left=�6L   $��358,214,0,0q�6g   $	��Top=�6|   $��31��6�   $��46��6�   6�   �� 5&      -   5        $ btmoredelailsserver��5&      $��25(�6:   $��More delails...��6H   $
��Left=�6b   $��	10,0,0,10q�6}   $	��201��6�   $��46��6�   $��Bottom=�6�   5'      5(      �� 5)      $��Settings��6   .��5*      � ���	#FFE5E5E5.+�5+      �� $��	Not work!��6   
���  ��$��50(�6A   $
��Left=�6O   $��172,110,0,0q�6j   $	��Top=�6   5,      5-      5.      50      51      