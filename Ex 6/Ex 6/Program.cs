using Ex_6;

Gato gato1 = new Gato
{
    Especie = "Gato Persa" 
};
Porco porco1 = new Porco
{
    Especie = "Porco Doméstico"
};
Capivara capivara1 = new Capivara
{
    Especie = "Capivara Doméstica"
};
Console.WriteLine($"Espécie: {gato1.Especie}");
gato1.EmitirSom();

Console.WriteLine($"\nEspécie: {porco1.Especie}");
porco1.EmitirSom();

Console.WriteLine($"\nEspécie: {capivara1.Especie}");
capivara1.EmitirSom();

Console.ReadKey();
