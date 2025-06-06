﻿namespace Cloud_Mall.Domain.Entities
{
    public class CartItem
    {
        public int ID { get; set; }
        public int Quantity { get; set; }

        public int CartID { get; set; }
        public virtual Cart Cart { get; set; }

        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
    }
}
