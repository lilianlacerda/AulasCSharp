Console.WriteLine("Hello, World!");

String firstName = "Lilian Raiany";
String lastName = "Lacerda";
String surname = "Lima";

Console.WriteLine("Meu nome completo é " + firstName + surname + lastName);

int idade = 26;

//O cifrão faz com que a gente consiga escrever as variáveis dentro das ""
Console.WriteLine($"Meu nome completo é {firstName} {surname} {lastName} e a minha idade é {idade}");

Console.WriteLine("Escreva seu nome");

//ReadLine é para receber resposta do usuário
string nome = Console.ReadLine();

Console.WriteLine($"Olá {nome}, boa noite!!!");

//Espera digitar alguma tecla para finalizar
Console.ReadKey();