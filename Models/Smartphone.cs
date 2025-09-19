namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public required string Marca { get; init; }
        public required string Modelo { get; init; }
        public required string Imei { get; init; }
        public required int Memoria { get; init; }
        public required int Armazenamento { get; init; }

        public Smartphone(string numero)
        {
            Numero = numero;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
        
        public override string ToString()
        {
            return $"Marca: {Marca} - " +
                $"Modelo: {Modelo} - " +
                $"IMEI: {Imei} - " +
                $"Memória: {Memoria}GB - " +
                $"Armazenamento: {Armazenamento}GB - " +
                $"Número: {Numero}";
        }
    }
}