using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

decimal valorMonetario = 1582.40M;
Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
//Console.WriteLine($"{valorMonetario:C}");
int numero = 123456;
Console.WriteLine(numero.ToString("##-##-##"));

DateTime data = DateTime.Now;
Console.WriteLine(data);
Console.WriteLine(data.ToShortDateString()); 
Console.WriteLine(data.ToString("dd//MM//yyyy HH:mm"));

DateTime date = DateTime.Parse("30/04/2024 18:00");
Console.WriteLine(date);

string dataString = "2024-12-17 18:00";


bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out data);
if(sucesso){
    Console.WriteLine($"Conversão com sucesso! Data> {data}");
}else{
    Console.WriteLine($"{dataString}não é uma data válida");
}

Console.WriteLine(data);
