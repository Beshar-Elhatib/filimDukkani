using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_2_filimDukkani
{
    public class Rental
    {
        //burada kiralanma id si tanimlanir ve kacini
        //kiralanma oldugunu bizi bilgilendirir.
        public int RentalId { get; set; }
        public Movie Movie { get; set; }
        public Person Person { get; set; }
        public DateTime RentDate { get; set; }
    }
}
