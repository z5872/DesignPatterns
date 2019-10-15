using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////////////////////////////////////////////////////////
            // Creational:
            ////////////////////////////////////////////////////////////////////////////////
            // - Abstract Factory

            // - Builder
            
            //// - Factory Method
            //var factoryMethod = new Creational.FactoryMethod();
            //factoryMethod.Run();
            //factoryMethod.RunRealWorld();

            // - Prototype

            //// - Singleton
            //var singleton = new Creational.Singleton();
            //singleton.Run();
            //singleton.RunRealWorld();
            //singleton.RunRealWorld2();

            ////////////////////////////////////////////////////////////////////////////////
            // Structural:
            ////////////////////////////////////////////////////////////////////////////////
            // - Adapter

            // - Bridge

            // - Composite

            //// - Decorator
            //var decorator = new Structural.Decorator();
            //decorator.Run();
            //decorator.RunRealWorld();
            //decorator.RunRealWorld2();

            // - Facade
            // - Flyweight
            // - Proxy


            ////////////////////////////////////////////////////////////////////////////////
            // Behavioral
            ////////////////////////////////////////////////////////////////////////////////
            // - Chain of Resp.
            //var chainOfResp = new Behavioral.ChainOfResponsibility();
            //chainOfResp.Run();
            //chainOfResp.RunRealWorld();
            
            // - Command
            
            // - Interpreter
            
            // - Iterator
            
            // - Mediator
            
            // - Observer
            
            // - State
            
            //// - Strategy
            var strategy = new Behavioral.Strategy();
            strategy.Run();
            strategy.RunRealWorld();

            // - Template Method
            
            // - Visitor
            ////////////////////////////////////////////////////////////////////////////////
        }
    }
}
