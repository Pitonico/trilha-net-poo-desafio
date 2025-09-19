namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero) : base(numero) {}

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no {Marca} {Modelo}.");
        }
    }
}