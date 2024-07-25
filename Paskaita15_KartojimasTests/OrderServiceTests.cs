namespace Paskaita15_Kartojimas.Tests
{
    /*
    2 UŽDUOTIS:. Parašykite Unit testą, kuris patikrintų ar PlaceOrder() grąžina 
    Order su reikiama Amount ir Price reišme, 
    tačiau nerašykite jokio failo į diską ir nieko neišveskite į konsolę.
     */

    [TestClass()]
    public class OrderServiceTests
    {
        [TestMethod()]
        public void PlaceOrder_ReturnsCorrectOrder()
        {
            // Arrange
            IMyLogger logger = new TestLogger();
            OrderService orderService = new OrderService(logger);

            // Act
            var result = orderService.PlaceOrder();

            //Assert
            Assert.AreEqual(0.1, result.Price);
            Assert.AreEqual(100, result.Amount);
        }
    }

    public class TestLogger : IMyLogger
    {
        private List<string> _logEntries = new List<string>();

        public void Log(string message)
        {
            _logEntries.Add(message);
        }
    }
}