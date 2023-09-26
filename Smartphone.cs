namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Marca { get; set; } // Implementação da propriedade Marca
        public string Modelo { get; set; } // Implementação da propriedade Modelo

        public Smartphone(string numero, string marca, string modelo)
        {
            Numero = numero;
            Marca = marca;   // Atribui o valor do parâmetro marca à propriedade Marca
            Modelo = modelo; // Atribui o valor do parâmetro modelo à propriedade Modelo
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
    }
}
