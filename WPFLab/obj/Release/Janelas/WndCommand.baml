   M S B A M L   `   `   `  ���� A  =WPFLab, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WPFLab.JanelasWPFLab.Janelas      WPFLab.Janelas.WndCommand   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:WPFLab.Janelas     -     �Name$
  ownd�� � Title$ 
WndCommand��$	��234��$	��374�� � 	Resources    mybrush �� Color��%   &	        �� $ 	AliceBlue�� J� CommandBindings )  #System.Windows.Input.CommandBinding  -      Command$ ApplicationCommands.New��  -   $ local:GameCommands.Jogar��.���� .+�o� $��25��.@�m� $��Arquivo��.@�m� $
��Novo�� m� Command$ ApplicationCommands.New��m� $��Abrir��m� $��Fechar��m� $
��Sair��$ ApplicationCommands.Close��m� $��Editar��.@�m� $��Copiar��$ ApplicationCommands.Copy��m� $��Colar��$ ApplicationCommands.Paste��m� $��Selecionar tudo��$# ApplicationCommands.SelectAll��m� -   $��Novo Ok?��m� $��Jogar��$ local:GameCommands.Jogar��c� -    c�Name$ otool������  �� ResourceKey$ mybrush��.@��� $	��Cut��	 � ToolTip$	 cortar������ .+��� $*��$/WPFLab;component/Images/tesoura.png��$��64��$��64���� $
��Copy��.��Copy�� $��Paste��.��Paste�� -   
 ��Name$
 	txtEditor��$��57�� �� TextWrapping$
 Wrap=�$�� ��$��0,3,0,0q���  �� Orientation$ 
Horizontal=�.+��� -    ��Name$ btnNovo��$��ApplicationCommands.New��$
��Left=�$	��101��$��0,3,0,0q�����  �� RelativeSource �� *Self+ �� Path$ Command.Text��� -   $ btnTeste��$��Teste��$��50���� -	   $ btnSair��$
��SAIR�����	#FFF19797$
��Left=�$��50��$��0,3,0,0q�