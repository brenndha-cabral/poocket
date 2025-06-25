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
    public List<string> Apps { get; set; }

        public Smartphone(
            string imei,
            string model,
            int storage,
            List<string> apps
        )
        {
            Imei = imei;
            Model = model;
            Storage = storage;
            Apps = apps;

        }

    public string GetSignatureLine()
    {
        throw new NotImplementedException();
    }

    public List<string> ListApps()
    {
      throw new NotImplementedException();
    }
    
    public string ListAppByName()
    {
        throw new NotImplementedException();
    }
        
    public List<string> InstallApps(string appName)
    {
      throw new NotImplementedException();
    }

    public List<string> UninstallApps(string appName)
    {
        throw new NotImplementedException();
    }
  }
}