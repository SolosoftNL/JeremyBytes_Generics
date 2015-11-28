using System.Collections.Generic;
using System.Linq;
using Generics.Common;
using Generics.Common.Interface;
using Generics.Repository.MyService;

namespace Generics.Repository.PersonRepository
{
    public class PersonServiceRepository : IPersonRepository
    {
        // NOTE: To keep this code readable, it contains NO EXCEPTION HANDLING.
        // Please refer to your favorite WCF reference to see how to properly
        // manage client-side proxies and faulted channels.

        private PersonServiceClient proxy;

        public PersonServiceRepository()
        {
            proxy = new PersonServiceClient();
        }

        public IEnumerable<Person> GetPeople()
        {
            return proxy.GetPeople();
        }

        public Person GetPerson(string lastName)
        {
            return proxy.GetPerson(lastName);
        }

        public void AddPerson(Person newPerson)
        {
            proxy.AddPerson(newPerson);
        }

        public void UpdatePerson(string lastName, Person updatedPerson)
        {
            proxy.UpdatePerson(lastName, updatedPerson);
        }

        public void DeletePerson(string lastName)
        {
            proxy.DeletePerson(lastName);
        }

        public void UpdatePeople(IEnumerable<Person> updatedPeople)
        {
            proxy.UpdatePeople(updatedPeople.ToArray());
        }
    }
}
