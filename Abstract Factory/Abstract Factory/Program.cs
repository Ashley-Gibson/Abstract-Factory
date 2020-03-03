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

            Console.WriteLine("\n***** Cold Factory *****\n");
            coldSandwichClient = new Client(new Cold());
            coldSausageClient = new Client(new Cold());
            Console.WriteLine("Creating " + coldSandwichClient.GetCreatedSandwichName() + "\n");
            Console.WriteLine("Creating " + coldSausageClient.GetCreatedSausageName() + "\n");

            Console.WriteLine("\n***** This is a Hot Factory *****\n");
            hotSandwichClient = new Client(new Hot());
            hotSausageClient = new Client(new Hot());
            Console.WriteLine("Creating " + hotSandwichClient.GetCreatedSandwichName() + "\n");
            Console.WriteLine("Creating " + hotSausageClient.GetCreatedSausageName() + "\n");

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
