using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers2Exercise
{
    //public class GoldCustomer : Customer
    //{
    //    public void OfferVoucher()
    //    {
    //        var rating = this.CalculateRating(excludeOrders: true);

    //    }
    //}
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public void Promote()
        {
            Console.WriteLine("Promote logic changed.");
            //var rating = CalculateRating(excludeOrders: true);
            //if (rating == 0)
            //{
            //    Console.WriteLine("Promoted to level 1");
            //}
            //else
            //{
            //    Console.WriteLine("Promoted to level 2");
            //}
        }
        //protected int CalculateRating(bool excludeOrders)
        //{
        //    return 0;
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
        }
    }
}