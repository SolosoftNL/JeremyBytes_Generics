using System.Collections.Generic;

namespace Generics.Common.Interface
{
    public interface IRepository<T, TKey>
    {
        IEnumerable<T> GetItems();

        T GetItem(TKey key);

        void AddItem(T newItem);

        void UpdateItem(TKey key, T updatedItem);

        void DeleteItem(TKey key);

        void UpdateItems(IEnumerable<T> updatedItems);
    }
}
