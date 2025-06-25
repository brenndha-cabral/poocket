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
        public List<ModulesApp> Modules = new List<ModulesApp>();

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


            if (!Modules.Remove(moduleFound))
            {
                Console.WriteLine($"❌ Módulo \"{idModule}\" não encontrado.");
            }
            
            Modules.Remove(moduleFound);
        }

        public void ListModules()
        {
            Console.Write("Buscando módulos");
            for (int i = 0; i < 3; i++)
            {
            Thread.Sleep(600);
            Console.Write(".");
            }
            Console.WriteLine();
            foreach (var module in Modules)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"🔹 Nome: {module.Name} - Id: {module.Id}");
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
        }
  }
}