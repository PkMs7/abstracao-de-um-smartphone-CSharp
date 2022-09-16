using abstracao_de_um_smartphone_CSharp.src.Models;

Nokia nokia1 = new Nokia("54999999999", "Lumia 6800", "35.........", 64);
nokia1.Ligar();
nokia1.ReceberLigacao();
nokia1.InstalarAplicativo("Pokemon Unite");

Iphone iphone1 = new Iphone("51999999999", "Iphone12", "35.........", 128);
iphone1.Ligar();
iphone1.ReceberLigacao();
iphone1.InstalarAplicativo("Pokemon Unite");