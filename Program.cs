using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Smartphone nokia = new Nokia("123456789") {
            Marca = "Nokia",
            Modelo = "3310",
            Imei = "987654321098765",
            Memoria = 1,
            Armazenamento = 16
        };

        Console.WriteLine("---| " + nokia.ToString() + " |---");
      
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Smartphone iphone = new Iphone("987654321") {
            Marca = "Apple",
            Modelo = "iPhone 13",
            Imei = "123456789012345",
            Memoria = 4,
            Armazenamento = 128
        };

        Console.WriteLine("---| " + iphone.ToString() + " |---");

        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Facebook");
    }
}