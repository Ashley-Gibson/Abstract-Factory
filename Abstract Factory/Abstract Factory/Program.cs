using System;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Client coldSandwichClient;
            Client hotSandwichClient;
            Client coldSausageClient;
            Client hotSausageClient;

            Console.WriteLine("\r\n------------ This is a Cold Factory ----------------");
            coldSandwichClient = new Client(new Cold());
            coldSausageClient = new Client(new Cold());
            Console.WriteLine("\r\n Creating " + coldSandwichClient.GetCreatedSandwichName());
            Console.WriteLine("\r\n Creating " + coldSausageClient.GetCreatedSausageName());

            Console.WriteLine("\r\n\r\n------------ This is a Hot Factory ----------------");
            hotSandwichClient = new Client(new Hot());
            hotSausageClient = new Client(new Hot());
            Console.WriteLine("\r\n Creating " + hotSandwichClient.GetCreatedSandwichName());
            Console.WriteLine("\r\n Creating " + hotSausageClient.GetCreatedSausageName());

            Console.ReadLine();
        }
    }

    class Client
    {
        private ISandwich sandwich;
        private ISausage sausage;

        public Client(IFoodAbstractFactory factory)
        {
            sandwich = factory.CreateSandwich();
            sausage = factory.CreateSausage();
        }

        public string GetCreatedSandwichName()
        {
            return sandwich.Name();
        }

        public string GetCreatedSausageName()
        {
            return sausage.Name();
        }
    }
}
