namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base (numero, modelo, imei, memoria){}


        public override void InstalarAplicativo(global::System.String nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo \"{nomeApp}\" no Nokia.");
        }
    }
}
