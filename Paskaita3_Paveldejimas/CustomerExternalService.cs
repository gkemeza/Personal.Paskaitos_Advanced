namespace Paskaita3_Paveldejimas
{
    public class CustomerExternalService
    {
        public virtual int GetDiscountRate(string customerId)
        {
            // cia turi buti logika, kuri grazina nuolaida
            // pvz http uzklausa i kita sistema

            throw new Exception("Isorinis servisas nepasiekiamas");
            return 0;
        }
    }

    public class Order
    {
        public Order(decimal price, double quantity, CustomerExternalService customerExternalService)
        {
            Price = price;
            Quantity = quantity;
            this.customerExternalService = customerExternalService;
        }

        public decimal Price { get; set; }
        public double Quantity { get; set; }
        public CustomerExternalService customerExternalService { get; set; }

        public void ApplyDiscount(string customerId)
        {
            int discountRate = customerExternalService.GetDiscountRate(customerId);
            decimal discount = Price * (decimal)Quantity * discountRate / 100;
            Price -= discount;
        }
    }
}
