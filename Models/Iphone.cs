namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        public override void InstalarAplicativo(string nomeApp)
        {
            System.Console.WriteLine($"Instalando o {nomeApp} no seu Iphone\n \t\t...");
            Thread.Sleep(2000);
            System.Console.WriteLine($"O aplicativo {nomeApp} foi instalado com sucesso\n");

        }
    }
}