using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poocket.Models
{
  public class Nokia : Smartphone
  {
    public Nokia(string imei) : base("T-33 Titan", imei, 7)
    {
    }

    public override void InjectModule(ModulesApp module)
    {
      Thread.Sleep(600);
      Console.Write("\n🔐 Confirmação (s/n): ");

      var confirm = Console.ReadLine();

      if (confirm?.ToLower() != "s")
      {
        Console.WriteLine("❌ Operação cancelada.");
        return;
      }

      Console.ForegroundColor = ConsoleColor.DarkYellow;
      Console.Write("🔧 [Titan] Iniciando injeção do módulo");
      for (int i = 0; i < 3; i++)
      {
        Thread.Sleep(600);
        Console.Write(".");
      }
      Console.WriteLine();
      Thread.Sleep(800);
      Console.ForegroundColor = ConsoleColor.Cyan;

      if (Modules.Count >= Storage)
      {
        Console.WriteLine("⚠️ Limite de módulos atingido para Titan.");
        return;
      }

      Thread.Sleep(800);
      Console.ForegroundColor = ConsoleColor.DarkMagenta;
      Console.Write("🧬 [Titan] Sincronizando módulo com IA");
      for (int i = 0; i < 3; i++)
      {
        Thread.Sleep(600);
        Console.Write(".");
      }
      Console.WriteLine();

      Thread.Sleep(1000);
      Modules.Add(module);
      Console.ForegroundColor = ConsoleColor.DarkGreen;
      Console.WriteLine($"✨ Módulo \"{module.Name}\" injetado no Titan.");
      Thread.Sleep(500);
      Console.ForegroundColor = ConsoleColor.Cyan;
    }

    public override void RemoveModule(string idModule)
    {
      Thread.Sleep(800);
      Console.Write("🔍 [Titan] Buscando módulo para remoção");
      for (int i = 0; i < 3; i++)
      {
        Thread.Sleep(600);
        Console.Write(".");
      }
      Console.WriteLine();

      Thread.Sleep(1000);
      base.RemoveModule(idModule);
      Console.ForegroundColor = ConsoleColor.DarkRed;
      Console.WriteLine($"✨ Módulo \"{idModule}\" removido do Titan.");
      Console.ForegroundColor = ConsoleColor.Cyan;
    }
  }
}