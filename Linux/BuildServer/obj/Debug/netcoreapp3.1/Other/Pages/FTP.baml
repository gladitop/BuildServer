   M S B A M L   `   `   `  ����F  BBuildServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:BuildServer.Other.PagesBuildServer.Other.Pages  5      !    BuildServer.Other.Pages.FTP   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:BuildServer.Other.Pages     5        N� Title$  BuildServer: Add server��5	      .��5      � .+�5   
   �� -   5         ��Name$ tbrootfoldet��5   $   ${�False��6   $
��Left=�6:   $��25(�6U   $��39��6c   $��
116,14,0,0q�6o    �� TextWrapping$
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��389��6�   �� 5   
   $��Storage:��6   $��25(�6#   $
��Left=�61   $��	10,10,0,0q�6L   $	��Top=�6_   �� 5   
    � ToolTip$ Select folder��6   $4��.pack://application:,,,/Resources/Directory.png��6(   $
��Left=�6`   $��39��6{   $��
530,14,0,0q�6�   $	��Top=�6�   $��52��6�   �� 5   
   -   5         ��Name$ btselectfolder��5       J� Opacity$ 0Q�6)   $��Button��65   $
��Left=�6F   $��
530,10,0,0q�6a   $	��Top=�6u   $��52��6�   $��43��6�   6�   �� 5   
   -   5        $ 
tbnameroot��5   #   $
{�True��6   $
��Left=�67   $��25(�6R   $��39��6`   $��	97,72,0,0q�6l   $
 Wrap=�6   $�� ��6�   $	��Top=�6�   $	��389��6�   6�   �� 5   
   $��Name:��6   $��25(�6    $
��Left=�6.   $��	10,68,0,0q�6I   $	��Top=�6\   �� 5   
   $��Port:��6   $��25(�6    $
��Left=�6.   $��
10,116,0,0q�6I   $	��Top=�6]   �� 5   
   -   5        $ tbport��5   #   $
{�True��6   $
��Left=�63   $��25(�6N   $��39��6\   $��
97,120,0,0q�6h   $
 Wrap=�6|   $�� ��6�   $	��Top=�6�   $	��148��6�   6�   �� 5   
   -   5         ��Name$ checktls��5      $��	Using TLS��6%   $��25(�69   $
��Left=�6G   $��
10,179,0,0q�6b   $	��Top=�6v   6�   �� 5   
   -   5        $ tbpathcertificate��5   $   ${�False��6   $
��Left=�6?   $��25(�6Z   $��39��6h   $��140,241,0,0q�6t   $
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��389��6�   6�   �� 5   
   $��Сertificate:��6   $��25(�6'   $
��Left=�65   $��
10,237,0,0q�6P   $	��Top=�6d   �� 5   
   $ Select folder��6   ${�False��6(   $4��.pack://application:,,,/Resources/Directory.png��6:   $
��Left=�6r   $��39��6�   $��552,237,0,0q�6�   $	��Top=�6�   $��52��6�   �� 5   
   -   5        $ btselectcertificate��5   #   ${�False��6   $ 0Q�6@   $��Button��6L   $
��Left=�6]   $��552,233,0,0q�6x   $	��Top=�6�   $��52��6�   $��43��6�   6�   �� 5   
   $��Passworld: ��6   $��25(�6&   $
��Left=�64   $��
10,285,0,0q�6O   $	��Top=�6c   G� 5   
   -   5         G�Name$ tbpassworldcertificate��5   (   ${�False��6   $
��Left=�6H   $��25(�6c   $��39��6q   $��141,289,0,0q�6}   $	��Top=�6�   $	��389��6�   6�   �� 5   
   $��Description server: ��6   $��25(�6/   $
��Left=�6=   $��
10,348,0,0q�6X   $	��Top=�6l   �� 5   
   -	   5        $ tbdescriptionserver��5      $
{�True��6/   $
��Left=�6@   $��25(�6[   $��39��6i   $��264,349,0,0q�6u   $
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��318��6�   6�   �� 5   
   -
   5        $ btdescriptionserver��5      $	��...��6.   $
��Left=�6<   $��604,348,0,0q�6W   $	��Top=�6l   $��59��6�   $��40��6�   6�   5      5      