using Ex_7;

ContaCorrente conta1 = new ContaCorrente
{
    Banco = "INTER",
    Agencia = 4321,
    Conta = 11111,
    Saldo = 500,
    Limite = 3000,
};
ContaCorrente conta2 = new ContaCorrente
{
    Banco = "NUBANK",
    Agencia = 1234,
    Conta = 76543,
    Saldo = 200,
    Limite = 2500,
};
ContaCorrente conta3 = new ContaCorrente
{
    Banco = "BRADESCO",
    Agencia = 9876,
    Conta = 64545,
    Saldo = 2000,
    Limite = 8000,
};
Console.WriteLine($"\nO Banco é: {conta1.Banco}, sua agencia é: {conta1.Agencia}, sua conta é: {conta1.Conta}, seu saldo é de: {conta1.Saldo}, seu limite é de: {conta1.Limite}.");
conta1.Depositar(200);
conta1.Sacar(300);
Console.WriteLine($"\nO Banco é: {conta2.Banco}, sua agencia é: {conta2.Agencia}, sua conta é: {conta2.Conta}, seu saldo é de: {conta2.Saldo}, seu limite é de: {conta2.Limite}.");
conta2.Depositar(200);
conta2.Sacar(300);
Console.WriteLine($"\nO Banco é: {conta3.Banco}, sua agencia é: {conta3.Agencia}, sua conta é: {conta3.Conta}, seu saldo é de: {conta3.Saldo}, seu limite é de: {conta3.Limite}.");
conta3.Depositar(2900);
conta3.Sacar(2300);

Console.ReadKey();