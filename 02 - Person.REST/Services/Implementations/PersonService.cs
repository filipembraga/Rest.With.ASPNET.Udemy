using _02___Person.REST.Model;
using _02___Person.REST.Services.Interfaces;

namespace _02___Person.REST.Services.Implementations
{
    public class PersonService : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {

        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for(int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }

        public Person FindById(long id)
        {
            return MockPerson((int) id);
        }

        public Person Update(Person person)
        {
            return person;
        }

        private Person MockPerson(int id)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Person Name " + id,
                LastName = "Mockado " + id,
                Address = "Endereço ficticio, 123",
                Gender = "Female"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }

        public PersonV2 Create(PersonV2 person)
        {
            return person;
        }
    }
}
