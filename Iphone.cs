namespace DesafioPOO.Models
{
    // Herda da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // Sobrescreve o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeAplicativo)
        {
            // Implementação específica para instalar um aplicativo em um iPhone
            // Você pode adicionar sua lógica de instalação aqui
            Console.WriteLine($"Instalando o aplicativo {nomeAplicativo} em um iPhone.");
        }
    }
}
