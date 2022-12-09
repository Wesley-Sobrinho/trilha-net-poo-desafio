namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
{ /// <summary>
/// 
/// </summary>
/// <param name="numero"></param>
/// <param name="modelo"></param>
/// <param name="imei"></param>
/// <param name="memoria"></param>
        public Iphone(string numero, string modelo, int imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo '{nomeApp}' no Iphone!");
        }
    }
}