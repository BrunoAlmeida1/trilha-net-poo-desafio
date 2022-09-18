namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        public override void InstalarAplicativo(string nomeApp)
        {
            System.Console.WriteLine($"Instalando o {nomeApp} no seu Nokia\n \t\t...");
            Thread.Sleep(3000);
            System.Console.WriteLine("Aplicativo instalado com sucesso\n");
        }
    }
}