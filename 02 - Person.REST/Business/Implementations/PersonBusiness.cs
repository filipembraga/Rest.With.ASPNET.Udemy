using _02___Person.REST.Business.Interfaces;
using _02___Person.REST.Model;
using _02___Person.REST.Repository.Interfaces;

namespace _02___Person.REST.Business.Implementations
{
    public class PersonBusiness : IPersonBusiness
    {
        private readonly IPersonRepository _personRepository;

        public PersonBusiness(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public Person Create(Person person)
        {
            return _personRepository.Create(person);
        }

        public void Delete(long id)
        {
            _personRepository.Delete(id);
        }

        public List<Person> FindAll()
        {
            return _personRepository.FindAll();
        }

        public Person FindById(long id)
        {
            return _personRepository.FindById(id);
        }

        public Person Update(Person person)
        {
            return _personRepository.Update(person);
        }

        public PersonV2 Create(PersonV2 person)
        {
            return _personRepository.Create(person);
        }
    }
}
