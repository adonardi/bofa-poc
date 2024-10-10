using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bofa_poc_di.Interface.DependencyInjectionConsoleApp
{
    /// <summary>
    /// Define interfaces and their concrete implementations for services that will be injected
    /// </summary>
    public interface IGreetingService
    {
        void Greet(string name);
    }
}
