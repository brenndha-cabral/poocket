
using poocket.Models;

List<ModulesApp> modules = new List<ModulesApp>();
bool hasRunProgram = true;



try
{
  while (hasRunProgram)
  {
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("\n🔹 POOCKET INTERFACE 1.9.2 [PROTOCOLO ABERTO] 🔹");

    Smartphone smartphone = null!;

    // Console.WriteLine("\n> Selecione sua UPN:");
    // Console.WriteLine("1. T-33 \"Titan\" [Estável]");
    // Console.WriteLine("2. LX-9 \"Lux\" [Avançado]");

    Console.WriteLine("\n> Escolha uma opção:\n\n 1. T-33 \"Titan\" [Estável]\n 2. LX-9 \"Lux\" [Avançado]\n 3. Sair\n");

    int input = Convert.ToInt32(Console.ReadLine());

    switch (input)
    {
      case 1:
        smartphone = new Nokia(Guid.NewGuid().ToString());
        break;

      case 2:
        smartphone = new IPhone(Guid.NewGuid().ToString());
        break;

      case 3:
        Console.WriteLine("\n❌ Encerrando protocolo.");
        hasRunProgram = false;
        break;

      default:
        break;
    }

    if (!hasRunProgram) break;

    Console.WriteLine("\n🔧 Comandos disponíveis: \n Inject | \n Remove | \n List | \n Exit");
    Console.Write("> Digite um comando: ");
    string cmd = Console.ReadLine()?.ToLower() ?? "";
    string module;

    switch (cmd)
    {
      case "Inject":
        Console.Write("🔹 Nome do módulo: ");
        module =  Console.ReadLine()?.ToLower() ?? "";
        smartphone.InjectModule(new ModulesApp(Guid.NewGuid().ToString(), module));
        break;

      case "Remove":
        Console.Write("🔹 Nome do módulo: ");
        module =  Console.ReadLine()?.ToLower() ?? "";
        smartphone.RemoveModule(module);
        break;

      case "List":
        smartphone.ListModules();
        break;

      default:
        break;
    }
    
  }
}
catch (Exception)
{
  
    throw new Exception("Erro ao rodar o projeto!");
}
