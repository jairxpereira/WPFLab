   M S B A M L   `   `   `  ���� A  =WPFLab, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WPFLab.JanelasWPFLab.Janelas  '    !WPFLab.Janelas.WndMultipleBinding   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:WPFLab.Janelas       � Title$  WndMultipleBinding��$	��540��$	��419�� � SizeToContent$ Width=�.��� .+��� -    ��Name$ sliderFontSize��$
��Left=�$��	19,10,0,0q�$	��Top=�$	��386�� � Maximum$ 72Q� � Minimum$ 8Q� � Value$ 55Q� � SmallChange$ 1Q� �� TickPlacement$ TopLeft=� �� TickFrequency$ 1Q�	 �� IsSnapToTickEnabled	 . �� -   
 ��Name$
 txtSourceText��$
��Left=�$��23��$��
163,47,0,0q� �� TextWrapping$
 Wrap=�$��txtSourceText��$	��Top=�$	��242���� -    ��Name$ listSourceColor��$
��Left=�$��74��$��	19,87,0,0q�$	��Top=�$	��386��$��3��.@���  �� 
IsSelected . 
 � Tag$	 Red��.��Red�� $ Green��.��Green�� $
 Blue��.��Blue�� $ 	AliceBlue��.��	AliceBlue�� $
��Left=�$��
19,183,0,0q�$
��Wrap=�
���   �$	��Top=�����  �� ElementName$ txtSourceText�� �� Path$
 Text����� $ sliderFontSize��$ Value����� $ listSourceColor��$ SelectedItem.Tag��� $
��Left=�$��	19,47,0,0q�$
��Wrap=�$	��Top=����� $ sliderFontSize��$ Value��� $��-10,47,10,-43q��� -   $ sliderFontSizeEx��$
��Left=�$��
19,347,0,0q�$	��Top=�$	��382��$ 1Q�$ TopLeft=�$ 1Q�$ 72Q�$ 55Q�$ 1Q�	 . �� $
��Left=�$��23��$��
19,374,0,0q�$
 Wrap=�$	��Top=�$	��120������ $ sliderFontSizeEx��$ Value� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� $
��Left=�$��
19,322,0,0q�$
��Wrap=�$'��!Testando outro aspecto de binding��$	��Top=��� $
��Left=�$��
27,413,0,0q�$
��Wrap=�$��Jair Pereira��$	��Top=����� $ sliderFontSizeEx��$ Value�$ TwoWay=��� -    ��Name$ btnManualUpdate��$��Manual Update -->��$
��Left=�$��163,375,0,0q�$	��Top=�$	��116���� -   $
 txtManualUpdate��$
��Left=�$��23��$��297,374,0,0q�$
 Wrap=�$	��Top=�$	��104������ $ sliderFontSizeEx��$ Value�$ TwoWay=�