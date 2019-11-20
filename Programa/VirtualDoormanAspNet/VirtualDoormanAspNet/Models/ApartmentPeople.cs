namespace VirtualDoormanAspNet.Models
{
    public class ApartmentPeople
    {
        public int Apartment { get; set; }
        public string Cpf { get; set; }

        public ApartmentPeople()
        {
        }

        public ApartmentPeople(Apartment apartment, People people)
        {
            Apartment = apartment.ApartmentNumber;
            Cpf = people.Cpf;
        }
    }
}
