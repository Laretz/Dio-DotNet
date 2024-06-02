namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public List<string> AplicativosInstalados { get; private set; } = new List<string>();

        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria){
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }
        public override void InstalarAplicativo(string nomeApp){
            AplicativosInstalados.Add(nomeApp);
            Console.WriteLine( $"Aplicativo {nomeApp} instalado com sucesso no Nokia!!!");
        }

        public override void ExibirApps(){
        if (AplicativosInstalados.Count == 0)
        {
            Console.WriteLine("Nenhum aplicativo instalado.");
            return;
        }

        Console.WriteLine("Aplicativos instalados:");
        int contador = 1;
        foreach (string aplicativo in AplicativosInstalados)
        {
            Console.WriteLine($"{contador++}. {aplicativo}");
        }
    }
    }
}