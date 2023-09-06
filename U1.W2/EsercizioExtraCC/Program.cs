using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioExtraCC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContiCorrenti.menuStart();
            
        }
    }
}
//Esercizio SQL
//select count(OrderID) as Ordini from Orders
//select count(CustomerID) as clienti from Customers
//select count(CustomerID) as clientiALondra from Customers where city = 'London'
//select AVG(Freight) as costoTrasporti from Orders
//select AVG(Freight) as costoTrasportiBOTTM from Orders where CustomerID = 'BOTTM'
//select sum(Freight) as costoTrasportiPerID from Orders group by CustomerID
//select count(CustomerID) as clientiPerCitta from Customers group by City
//select sum(UnitPrice* Quantity) as quantitaXprezzo from[Order Details]  group by OrderID
//select sum(UnitPrice * Quantity) as quantitaXprezzoID from[Order Details] where OrderID = 10248
//select count(OrderID) as ordiniPerPaese from Orders group by ShipCity
//select AVG(Freight) as costoMedioTrasporti from Orders group by ShipCity