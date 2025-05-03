using System.Globalization;

Console.WriteLine("--Peso Ideal--");

Console.Write("Digite sua altura em m: ");
string alturaTexto = Console.ReadLine()?? "0";
double altura = double.Parse(alturaTexto.Replace(',', '.'), CultureInfo.InvariantCulture);

Console.Write("Sexo [M]asculino / [F]eminino: ");
char sexo = char.ToUpper(Console.ReadKey().KeyChar);
Console.WriteLine(); 

double pesoIdeal;

if (sexo == 'M')
{
    pesoIdeal = (72.7 * altura) - 58.0;
}
else if (sexo == 'F')
{
    pesoIdeal = (62.1 * altura) - 44.7;
}
else
{
    Console.WriteLine("Sexo inválido.");
    return;
}

Console.WriteLine("Seu peso ideal é " + pesoIdeal.ToString("F1") + "kg.");
