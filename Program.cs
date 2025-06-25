
using poocket.Models;

bool hasRunProgram = true;
Nokia nokia = new Nokia(Guid.NewGuid().ToString());
IPhone iphone = new IPhone(Guid.NewGuid().ToString());


try
{
  while (hasRunProgram)
  {
    Smartphone smartphone = null!;

    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("\n🔹 POOCKET INTERFACE 1.9.2 [PROTOCOLO ABERTO] 🔹");
    Console.WriteLine("⚙️  Interface neural ativada. Escolha seu dispositivo e comece a gerenciar seus módulos.");

    Thread.Sleep(600);
    Console.WriteLine("\n> Escolha uma opção:\n\n 🔹 1. T-33 Titan [Estável]\n 🔹 2. LX-9 Lux [Avançado]\n 🔹 3. Listar Todos \n 🔹 4. Sair\n");
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write("💻 Terminal liberado > Dispositivo detectado > Aguardando comandos");
    for (int i = 0; i < 3; i++)
    {
    Thread.Sleep(600);
    Console.Write(".");
    }
    Console.WriteLine();
    Console.Write("> ");
    Console.ForegroundColor = ConsoleColor.Cyan;


    int input = Convert.ToInt32(Console.ReadLine());

    switch (input)
    {
      case 1:
        smartphone = nokia;
        Console.WriteLine("\n🔧 Comandos disponíveis: \n 🔹 Inject \n 🔹 Remove \n 🔹 List \n 🔹 Exit");
        Console.Write("\n> Digite um comando: ");
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
            Console.Write("🔹 Id do módulo: ");
            module =  Console.ReadLine()?.ToLower() ?? "";
            smartphone.RemoveModule(module);
            break;

          case "list":
              Console.WriteLine("\n📱 Módulos do Titan:");
              nokia.ListModules();
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
        smartphone = iphone;
        Console.WriteLine("\n🔧 Comandos disponíveis: \n 🔹 Inject \n 🔹 Remove \n 🔹 List \n 🔹 Exit");
        Console.Write("\n> Digite um comando: ");
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
            Console.Write("🔹 Id do módulo: ");
            module2 =  Console.ReadLine()?.ToLower() ?? "";
            smartphone.RemoveModule(module2);
            break;

          case "list":
              Console.WriteLine("\n📱 Módulos do Lux:");
              iphone.ListModules();
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
          Console.WriteLine("\n📱 Módulos do Titan:");
          nokia.ListModules();
          Console.WriteLine("\n📱 Módulos do Lux:");
          iphone.ListModules();
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
