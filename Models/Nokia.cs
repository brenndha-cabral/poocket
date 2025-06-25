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
      Console.Write("\n🔐 Confirmação (s/n): ");
      
      var confirm = Console.ReadLine();

      if (confirm?.ToLower() != "s")
      {
        Console.WriteLine("❌ Operação cancelada.");
        return;
      }

      Console.WriteLine("🔧 [Titan] Iniciando injeção do módulo...");

    if (Modules.Count >= Storage)
    {
        Console.WriteLine("⚠️ Limite de módulos atingido para Titan.");
        return;
    }

      Console.WriteLine("🧬 [Titan] Sincronizando módulo com IA...");
      Modules.Add(module);
      Console.WriteLine($"✨ Módulo \"{module.Name}\" injetado no Titan.");
    }

    public override void RemoveModule(string idModule)
    {
        Console.WriteLine("🔍 [Titan] Buscando módulo para remoção...");
        base.RemoveModule(idModule);
        Console.WriteLine($"✨ Módulo \"{idModule}\" removido do Titan.");
    }
  }
}