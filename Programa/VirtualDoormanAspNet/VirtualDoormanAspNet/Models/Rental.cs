using System;
using System.ComponentModel.DataAnnotations;

namespace VirtualDoormanAspNet.Models
{
    public class Rental
    {
        [Key]
        public DateTime RentalDate { get; set; }

        public RentalModel RentalModel { get; set; }
        public Apartment Apartment { get; set; }

        public Rental()
        {
        }

        public Rental(DateTime rentalDate, RentalModel rentalModel, Apartment apartment)
        {
            RentalDate = rentalDate;
            RentalModel = rentalModel;
            Apartment = apartment;
        }
    }
}
