using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poocket.Repository
{
    public interface ISmartphone
    {
        abstract string GetSignatureLine();
        List<string> ListApps();
        string ListAppByName();
        List<string> InstallApps(string appName);
        List<string> UninstallApps(string appName);
    }
}