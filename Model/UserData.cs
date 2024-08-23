using System.ComponentModel.DataAnnotations;
namespace TestApp.Model
{
    public class UserData
    {
        //fields
        private int id;
        private string FirstName;
        private string MiddelName;
        private string LastName;
        private string Birthdate;
        private string ContactNumber;
        private string EmailAddress;
        private string StreetAddress;
        private string Suburb;
        private string City;
        private string Province;
        private string Country;
        private string Sex;
        private string Race;
        private string AccountName;
        private int FKID;
        
        //Constructors
        public UserData() { }

        public UserData(int id, string firstName1, string middelName1, string lastName1, string birthdate1, string contactNumber1, string emailAddress1, string streetAddress1, string suburb1, string city1, string province1, string country1, string sex1, string race1, string accountName1, int fKID1)
        {
            Id = id;
            FirstName1 = firstName1;
            MiddelName1 = middelName1;
            LastName1 = lastName1;
            Birthdate1 = birthdate1;
            ContactNumber1 = contactNumber1;
            EmailAddress1 = emailAddress1;
            StreetAddress1 = streetAddress1;
            Suburb1 = suburb1;
            City1 = city1;
            Province1 = province1;
            Country1 = country1;
            Sex1 = sex1;
            Race1 = race1;
            AccountName1 = accountName1;
            FKID1 = fKID1;
        }

        //properties
        public int Id { get => id; set => id = value; }
        public string FirstName1 { get => FirstName; set => FirstName = value; }
        public string MiddelName1 { get => MiddelName; set => MiddelName = value; }
        public string LastName1 { get => LastName; set => LastName = value; }
        public string Birthdate1 { get => Birthdate; set => Birthdate = value; }
        public string ContactNumber1 { get => ContactNumber; set => ContactNumber = value; }
        public string EmailAddress1 { get => EmailAddress; set => EmailAddress = value; }
        public string StreetAddress1 { get => StreetAddress; set => StreetAddress = value; }
        public string Suburb1 { get => Suburb; set => Suburb = value; }
        public string City1 { get => City; set => City = value; }
        public string Province1 { get => Province; set => Province = value; }
        public string Country1 { get => Country; set => Country = value; }
        public string Sex1 { get => Sex; set => Sex = value; }
        public string Race1 { get => Race; set => Race = value; }
        public string AccountName1 { get => AccountName; set => AccountName = value; }
        public int FKID1 { get => FKID; set => FKID = value; }
    }
}
