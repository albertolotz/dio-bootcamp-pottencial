namespace DesafioPOO.Models
{
    public sealed class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, string memoria) : base(numero, modelo, memoria, imei)
        {
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"App {nomeApp} instalado ...");
        }
    }
}