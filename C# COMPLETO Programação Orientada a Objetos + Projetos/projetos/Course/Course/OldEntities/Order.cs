﻿namespace Course.OldEntities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        //public Enum.OrderStatus Status { get; set; }


        public override string ToString()
        {
            return Id
                + ", "
                + Moment
                + ", ";
                 /*Status*/
        }
    }
}
