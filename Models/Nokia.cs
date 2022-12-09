namespace DesafioPOO.Models
{
    
    public class Nokia : Smartphone

    { /// <summary>
    /// 
    /// </summary>
    /// <param name="numero"></param>
    /// <param name="modelo"></param>
    /// <param name="imei"></param>
    /// <param name="memoria"></param>
        public Nokia(string numero, string modelo, int imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo '{nomeApp}' no Nokia!");
        }
    }
}