using Ex_5;

Funcionario fun1 = new Funcionario
{
    Nome = "Davy Jones",
    Idade = 36,
};

Funcionario fun2 = new Funcionario
{
    Nome = "Rafaela Gonçalves",
    Idade = 25,
};
Funcionario fun3 = new Funcionario
{
    Nome = "Julia Rodrigues",
    Idade = 41,
};
Funcionario fun4 = new Funcionario
{
    Nome = "Juliano Alvarenga",
    Idade = 33,
};
Funcionario fun5 = new Funcionario
{
    Nome = "Marco Túlio",
    Idade = 28,
};
fun1.Envelhecer(3);//Somar a idade que você passou para a variavel fun1 mais 3
fun2.Envelhecer(5);
fun3.Envelhecer(6);
fun4.Envelhecer(3);
fun5.Envelhecer(5);


//Exibindo as informações dos funcionários
Console.WriteLine($"\nNome: {fun1.Nome}, Idade: {fun1.Idade}");
fun1.Rejuvenecer(2);
Console.WriteLine($"{fun1.Nome} rejuveneceu para {fun1.Idade} anos de idade");

Console.WriteLine($"\nNome: {fun2.Nome}, Idade: {fun2.Idade}");
fun2.Rejuvenecer(3);
Console.WriteLine($"{fun2.Nome} rejuveneceu para {fun2.Idade} anos de idade");


Console.WriteLine($"\nNome: {fun3.Nome}, Idade: {fun3.Idade}");
fun3.Rejuvenecer(4);
Console.WriteLine($"{fun3.Nome} rejuveneceu para {fun3.Idade} anos de idade");


Console.WriteLine($"\nNome: {fun4.Nome}, Idade: {fun4.Idade}");
fun4.Rejuvenecer(3);
Console.WriteLine($"{fun4.Nome} rejuveneceu para {fun4.Idade} anos de idade");

Console.WriteLine($"\nNome: {fun5.Nome}, Idade: {fun5.Idade}");
fun5.Rejuvenecer(7);
Console.WriteLine($"{fun5.Nome} rejuveneceu para {fun5.Idade} anos de idade");




Console.WriteLine("\nPressione qualquer tecla para sair");
Console.ReadKey();