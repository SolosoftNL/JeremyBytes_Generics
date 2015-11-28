using System.Collections.Generic;
using System.Linq;
using Generics.Common;
using Generics.Common.Interface;
using Generics.Repository.MyService;

namespace Generics.Repository.PersonRepository
{
    public class GenericPersonServiceRepository : IRepository<Person, string>
    {
        // NOTE: To keep this code readable, it contains NO EXCEPTION HANDLING.
        // Please refer to your favorite WCF reference to see how to properly
        // manage client-side proxies and faulted channels.

        private PersonServiceClient proxy;

        public GenericPersonServiceRepository()
        {
            proxy = new PersonServiceClient();
        }

        public IEnumerable<Person> GetItems()
        {
            return proxy.GetPeople();
        }

        public Person GetItem(string lastName)
        {
            return proxy.GetPerson(lastName);
        }

        public void AddItem(Person newPerson)
        {
            proxy.AddPerson(newPerson);
        }

        public void UpdateItem(string lastName, Person updatedPerson)
        {
            proxy.UpdatePerson(lastName, updatedPerson);
        }

        public void DeleteItem(string lastName)
        {
            proxy.DeletePerson(lastName);
        }

        public void UpdateItems(IEnumerable<Person> updatedPeople)
        {
            proxy.UpdatePeople(updatedPeople.ToArray());
        }
    }
}
