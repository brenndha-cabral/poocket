
using poocket.Models;

bool hasRunProgram = true;

try
{
  while (hasRunProgram)
  {
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("\n🔹 POOCKET INTERFACE 1.9.2 [PROTOCOLO ABERTO] 🔹");

    Smartphone smartphone = null!;

    Console.WriteLine("\n> Escolha uma opção:\n\n 🔹 1. T-33 Titan [Estável]\n 🔹 2. LX-9 Lux [Avançado]\n 🔹 3. Listar Todos \n 🔹 4. Sair\n");

    int input = Convert.ToInt32(Console.ReadLine());

    switch (input)
    {
      case 1:
        smartphone = new Nokia(Guid.NewGuid().ToString());
        Console.WriteLine("\n🔧 Comandos disponíveis: \n 🔹 Inject \n 🔹 Remove \n 🔹 List \n 🔹 Exit");
        Console.Write("> Digite um comando: ");
        string cmd = Console.ReadLine()?.ToLower() ?? "";
        string module;

        switch (cmd)
        {
          case "inject":
            Console.Write("🔹 Nome do módulo: ");
            module =  Console.ReadLine()?.ToLower() ?? "";
            smartphone.InjectModule(new ModulesApp(Guid.NewGuid().ToString(), module));
            break;

          case "remove":
            Console.Write("🔹 Nome do módulo: ");
            module =  Console.ReadLine()?.ToLower() ?? "";
            smartphone.RemoveModule(module);
            break;

          case "list":
            smartphone.ListModules();
            break;

          case "exit":
            Console.WriteLine("\n❌ Encerrando protocolo.");
            hasRunProgram = false;
            break;

          default:
            break;
        }
        break;

      case 2:
        smartphone = new IPhone(Guid.NewGuid().ToString());
        Console.WriteLine("\n🔧 Comandos disponíveis: \n Inject | \n Remove | \n List | \n Exit");
        Console.Write("> Digite um comando: ");
        string cmd2 = Console.ReadLine()?.ToLower() ?? "";
        string module2;

        switch (cmd2)
        {
          case "inject":
            Console.Write("🔹 Nome do módulo: ");
            module2 =  Console.ReadLine()?.ToLower() ?? "";
            smartphone.InjectModule(new ModulesApp(Guid.NewGuid().ToString(), module2));
            break;

          case "remove":
            Console.Write("🔹 Nome do módulo: ");
            module2 =  Console.ReadLine()?.ToLower() ?? "";
            smartphone.RemoveModule(module2);
            break;

          case "list":
            smartphone.ListModules();
            break;

          case "exit":
            Console.WriteLine("\n❌ Encerrando protocolo.");
            hasRunProgram = false;
            break;

          default:
            break;
        }
        break;

      case 3:
        smartphone.ListModules();
        break;

      case 4:
        Console.WriteLine("\n❌ Encerrando protocolo.");
        hasRunProgram = false;
        break;

      default:
        break;
    }

    if (!hasRunProgram) break;
  }
}
catch (Exception)
{
  
    throw new Exception("Erro ao rodar o projeto!");
}
