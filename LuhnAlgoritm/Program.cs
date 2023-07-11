using LuhnAlgoritm;

Console.Write("Write your card number - ");
string cardNumber = Console.ReadLine();
var bank = new Bank();
Console.WriteLine(bank.IsCardNumberValid(cardNumber));
