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
      Console.Write("\n🔐 Confirmação (s/n): ");

      var confirm = Console.ReadLine();
      
      if (confirm?.ToLower() != "s")
      {
        Console.WriteLine("❌ Operação cancelada.");
        return;
      }

      Console.WriteLine("🔧 [Lux] Iniciando injeção do módulo...");

    if (Modules.Count >= Storage)
    {
        Console.WriteLine("⚠️ Limite de módulos atingido para Lux.");
        return;
    }

      Console.WriteLine("🧬 [Lux] Sincronizando módulo com IA...");
      Modules.Add(module);
      Console.WriteLine($"✨ Módulo \"{module.Name}\" injetado no Lux.");
    }

    public override void RemoveModule(string module)
    {
        Console.WriteLine("🧹 [Lux] Removendo módulo com elegância...");
        base.RemoveModule(module);
        Console.WriteLine($"✨ Módulo \"{module}\" removido do Lux.");
    }
  }
}