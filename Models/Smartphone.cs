using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using poocket.Repository;

namespace poocket.Models
{
    public abstract class Smartphone : ISmartphone
    {
        public string Imei { get; set; }
        public string Model { get; set; }
        public int Storage { get; set; }
        protected List<ModulesApp> Modules = new List<ModulesApp>();

        public Smartphone(
            string imei,
            string model,
            int storage
            )
        {
            Imei = imei;
            Model = model;
            Storage = storage;
        }
        public abstract void InjectModule(ModulesApp module);

        public virtual void RemoveModule(string idModule)
        {
            ModulesApp moduleFound = Modules.Find(module => module.Id == idModule);

            if (Modules.Remove(moduleFound))
            {
                Console.WriteLine($"✅ Módulo \"{idModule}\" removido.");
            }
            else
            {
                Console.WriteLine($"❌ Módulo \"{idModule}\" não encontrado.");
            }
        }

        public void ListModules()
        {
            Console.WriteLine("\n📋 Módulos ativos no núcleo:");
            foreach (var module in Modules)
            {
                Console.WriteLine($"- {module}");
            }
        }
  }
}