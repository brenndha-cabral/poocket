using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using poocket.Models;

namespace poocket.Repository
{
    public interface ISmartphone
    {
        abstract string GetSignatureLine();
        List<App> ListApps();
        App AppByName(string appName);
        void InstallApps(App appName);
        void UninstallApps(App appName);
    }
}