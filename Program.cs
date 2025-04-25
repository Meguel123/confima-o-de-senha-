Console.Clear();
string SenhaCorreta, Senhadigitada;
Console.Write("Digite sua senha:");
Senhadigitada = Console.ReadLine();
Console.Clear();
Console.WriteLine("digite novamente");
SenhaCorreta = Console.ReadLine()!;
if(SenhaCorreta == Senhadigitada)
{//senha certa
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("usuario logado com sucesso");}

else
{//senha errada
Console.ForegroundColor = ConsoleColor.Red;
Console.Write("Senha errada");}

Console.ResetColor();
