using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poocket.Models
{
  public class IPhone : Smartphone
  {
    public IPhone(string imei) : base("LX-9 Lux", imei, 12)
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
      Console.Write("🔧 [Lux] Iniciando injeção do módulo");
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
        Console.WriteLine("⚠️ Limite de módulos atingido para Lux.");
        return;
      }

      Thread.Sleep(800);
      Console.ForegroundColor = ConsoleColor.DarkMagenta;
      Console.Write("🧬 [Lux] Sincronizando módulo com IA");
      for (int i = 0; i < 3; i++)
      {
        Thread.Sleep(600);
        Console.Write(".");
      }
      Console.WriteLine();

      Thread.Sleep(1000);
      Modules.Add(module);
      Console.ForegroundColor = ConsoleColor.DarkGreen;
      Console.WriteLine($"✨ Módulo \"{module.Name}\" injetado no Lux.");
      Thread.Sleep(500);
      Console.ForegroundColor = ConsoleColor.Cyan;
    }

    public override void RemoveModule(string module)
    {
      Thread.Sleep(500);
      Console.Write("🧹 [Lux] Removendo módulo com elegância");
      for (int i = 0; i < 3; i++)
      {
        Thread.Sleep(600);
        Console.Write(".");
      }
      Console.WriteLine();

      Thread.Sleep(1000);
      base.RemoveModule(module);
      Console.ForegroundColor = ConsoleColor.DarkRed;
      Console.WriteLine($"✨ Módulo \"{module}\" removido do Lux.");
      Console.ForegroundColor = ConsoleColor.Cyan;
    }
  }
}