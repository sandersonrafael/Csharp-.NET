using System;
using Enums.Entities;
using Enums.Entities.Enums;

Order order = new Order { Id = 1080, Moment = DateTime.Now, Status = OrderStatus.PendingPayment };

Console.WriteLine(order);

/* Conversion */

// Enum to String
string txt = OrderStatus.PendingPayment.ToString();
Console.WriteLine(txt);

// String to Enum
OrderStatus orderStatus = Enum.Parse<OrderStatus>("Shipped");
Console.WriteLine(orderStatus);
