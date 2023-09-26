using System;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Teste com a classe Nokia
            Nokia nokiaPhone = new Nokia(numero: "123456", marca: "Nokia", modelo: "Nokia 9");
            nokiaPhone.Ligar();
            nokiaPhone.ReceberLigacao();
            nokiaPhone.InstalarAplicativo("WhatsApp");

            // Teste com a classe Iphone
            Iphone iphone = new Iphone(numero: "789012", marca: "Apple", modelo: "iPhone 12");
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");

            Console.ReadLine();
        }
    }
}
