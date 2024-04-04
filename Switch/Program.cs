
dotnet add package NAudio --version 2.2.1

//inicialização
Console.WriteLine("=======================");
Console.WriteLine("Programa em c# Gustavo Nappi (2024)");
Console.WriteLine("Bem-vindo");
Console.WriteLine("=======================");

//audio do codigo


//entrada do codigo
Console.WriteLine("Que dia é hoje??");
string dia = Console.ReadLine();

switch (dia)
{
    case "Segunda":
        Console.WriteLine("é segunda-feira");
    break;
    
    case "Terça":
        Console.WriteLine("é Terça-feira");
    break;

    case "Quarta":
        Console.WriteLine("é Quarta-feira");
    break;

    case "Quinta":
        Console.WriteLine("é Quinta-feira");
    break;

    case "Sexta":
        Console.WriteLine("é Sexta-Feira");
    break;

    case "Sabado":
        Console.WriteLine("é Sabado");
    break;

    case "Domingo":
        Console.WriteLine("é Domingo");
    break;

    case "":
        Console.WriteLine("INSIRA UM DIA DA SEMANA");
    break;


}



Console.ReadKey();
