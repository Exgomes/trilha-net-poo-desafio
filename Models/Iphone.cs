namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"

    public class Iphone : Smartphone
    {  
          // TODO: Sobrescrever o método "InstalarAplicativo"
          public Iphone(string numero, string modelo, string imei, string memoria)
            : base(numero, modelo, imei, memoria)
        {
            // Construtor...
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} na App Store...");
        }
       
    }
}