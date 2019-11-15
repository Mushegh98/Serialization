using System.Xml.Serialization;

namespace XML_Serialization
{
    [XmlRoot("My Serialization Class")]
    public class MySerialize
    {
        private string firstName;
        private string lastName;
        private string e_Mail;
        private int age;
        private string gender;
        private string country;

        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string E_Mail { get { return e_Mail; } set { e_Mail = value; } }
        public int Age { get { return age; } set { age = value; } }
        public string Gender { get { return gender; } set { gender = value; } }
        public string Country { get { return country; } set { country = value; } }

    }
}
