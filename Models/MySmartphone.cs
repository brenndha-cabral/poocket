using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using poocket.Repository;

namespace poocket.Models
{
    public class MySmartphone : ISmartphone
    {
        public string Id { get; set; }
        public List<App> Apps { get; set; }

        public MySmartphone(
            string id
        )
        {
            Id = id;
            Apps = new List<App>();
        }
        
        public int GetAppsQuantity()
        {
            return Apps.Count;
        }

        public string GetSignatureLine()
        {
            throw new NotImplementedException();
        }

        public List<App> ListApps()
        {
            return Apps;
        }

        public App AppByName(string appName)
        {
            App? appFound = Apps.Find(name => name.Name == appName);

            if (appFound != null)
            {
                return appFound;
            }
            else
            {
                throw new Exception($"{appName} não corresponde a nenhum aplicativo!");
            }
        }

        public void InstallApps(App appName)
        {
            App? appFound = Apps.Find(name => name.Name == appName.Name);

                if (appFound != null)
                {
                    Console.WriteLine("✅ App já está instalado!");
                }
                else
                {
                
                    Apps.Add(appName);
                    Console.WriteLine($"📥 Instalando app: {appName}...");
                    Console.WriteLine("✅ App instalado com sucesso!");
            }
        }

        public void UninstallApps(App appName)
        {
            App? appFound = Apps.Find(name => name.Name == appName.Name);

                if (appFound == null)
                {
                    Console.WriteLine("❌ App não instalado!");
                }
                else
                {
                    Apps.Remove(appName);
                    Console.WriteLine($"❌ Removendo app: {appName}...");
                    Console.WriteLine("✅ App removido com sucesso!");
            }
        }
    }
}