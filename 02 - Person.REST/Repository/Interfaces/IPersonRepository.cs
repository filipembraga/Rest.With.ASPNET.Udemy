﻿using _02___Person.REST.Model;

namespace _02___Person.REST.Repository.Interfaces
{
    public interface IPersonRepository
    {
        Person Create(Person person);
        Person FindById(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
        PersonV2 Create(PersonV2 person);
        bool Exists(long id);
    }
}
