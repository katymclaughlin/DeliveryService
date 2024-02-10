namespace DeliveryService.Data;

    public class Delivery
    {
        public Delivery() {}

        public Delivery(string orderName, string orderDate, string deliveryDate, string deliveryStatus, int itemNumber, int itemQuantity, Guid customerId)
        {
            OrderName = orderName;
            OrderDate = orderDate;
            DeliveryDate = deliveryDate;
            DeliveryStatus = deliveryStatus;
            ItemNumber = itemNumber;
            ItemQuantity = itemQuantity;
            CustomerId = customerId;

        }

        public string OrderName { get; set; }
        public string OrderDate { get; set; }

        public string DeliveryDate { get; set; }

        public string DeliveryStatus { get; set; }

        public int ItemNumber { get; set; }

        public int ItemQuantity { get; set; }

        public Guid CustomerId { get; set; }

    }
