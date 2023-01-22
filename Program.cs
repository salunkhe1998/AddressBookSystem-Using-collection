namespace CollectionAddressBook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            AddressBook Adr = new AddressBook();
            Adr.createUser();
            Adr.editContact();
            Adr.printUser();
        }
    }
}
