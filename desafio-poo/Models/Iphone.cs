namespace DesafioPOO.Models
{
    public sealed class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, string memoria) : base(numero, modelo, memoria, imei)
        {
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"App {nomeApp} instalado ...");
        }
    }
}