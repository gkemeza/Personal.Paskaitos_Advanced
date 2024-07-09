using Paskaita3_Paveldejimas;

namespace Paskaita3_PaveldejimasTests
{
    [TestClass()]
    public class OrderTests
    {
        [TestMethod()]
        public void ApplyDiscountTest()
        {
            //Arrange
            var customerExternalService = new FakeCustomerExternalService();
            var sut = new Order(100, 2, customerExternalService);

            //Act
            sut.ApplyDiscount("ACME");

            //Assert
            Assert.AreEqual(90, sut.Price);
        }
    }

    // feikine, paveldeta klase - tam, kad galetume overridinti neimplementuota metoda
    public class FakeCustomerExternalService : CustomerExternalService
    {
        public override int GetDiscountRate(string customerId)
        {
            return 5;
        }
    }
}