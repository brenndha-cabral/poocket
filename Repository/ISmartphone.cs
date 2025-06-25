using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using poocket.Models;

namespace poocket.Repository
{
    public interface ISmartphone
    {
        void ListModules();
        abstract void InjectModule(ModulesApp moduleName);
        void RemoveModule(string idModule);
    }
}