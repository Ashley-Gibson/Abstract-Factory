using Abstract_Factory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Unit_Testing
{
    [TestClass]
    public class Tests
    {
        private readonly IFoodAbstractFactory coldConcreteFactory = new Cold();
        private readonly IFoodAbstractFactory hotConcreteFactory = new Hot();

        [TestMethod]
        public void Test_Cold()
        {
            // Arrange
            Client coldSandwichClient = new Client(coldConcreteFactory);
            string expectedSandwichName = "Cold Sandwich";
            string expectedSausageName = "Cold Sausage";

            // Act
            string actualSandwichName = coldSandwichClient.GetCreatedSandwichName();
            string actualSausageName = coldSandwichClient.GetCreatedSausageName();

            // Assert
            Assert.AreEqual(expectedSandwichName, actualSandwichName);
            Assert.AreEqual(expectedSausageName, actualSausageName);
        }

        [TestMethod]
        public void Test_Hot()
        {
            // Arrange
            Client hotSandwichClient = new Client(hotConcreteFactory);
            string expectedSandwichName = "Hot Sandwich";
            string expectedSausageName = "Hot Sausage";

            // Act
            string actualSandwichName = hotSandwichClient.GetCreatedSandwichName();
            string actualSausageName = hotSandwichClient.GetCreatedSausageName();

            // Assert
            Assert.AreEqual(expectedSandwichName, actualSandwichName);
            Assert.AreEqual(expectedSausageName, actualSausageName);
        }

        [TestMethod]
        public void Test_CreateCold()
        {
            // Arrange
            ISandwich expectedColdSandwichClass = new ColdSandwich();
            ISausage expectedColdSausageClass = new ColdSausage();

            // Act
            ISandwich actualColdSandwichClass = coldConcreteFactory.CreateSandwich();
            ISausage actualColdSausageClass = coldConcreteFactory.CreateSausage();            

            // Assert
            Assert.AreEqual(expectedColdSandwichClass.GetType(), actualColdSandwichClass.GetType());
            Assert.AreEqual(expectedColdSausageClass.GetType(), actualColdSausageClass.GetType());
        }

        [TestMethod]
        public void Test_CreateHot()
        {
            // Arrange
            ISandwich expectedHotSandwichClass = new HotSandwich();
            ISausage expectedHotSausageClass = new HotSausage();

            // Act
            ISandwich actualHotSandwichClass = hotConcreteFactory.CreateSandwich();
            ISausage actualHotSausageClass = hotConcreteFactory.CreateSausage();

            // Assert
            Assert.AreEqual(expectedHotSandwichClass.GetType(), actualHotSandwichClass.GetType());
            Assert.AreEqual(expectedHotSausageClass.GetType(), actualHotSausageClass.GetType());
        }
    }
}
