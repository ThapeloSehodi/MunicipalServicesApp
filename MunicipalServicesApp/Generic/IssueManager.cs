using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServicesApp.Generic
{
    public class IssueManager<T>
    {
        private List<T> items;

        public IssueManager()
        {
            items = new List<T>();
        }

        public void Add(T item)
        {
            items.Add(item);
        }

        public List<T> GetAll()
        {
            return items;
        }

        public int Count()
        {
            return items.Count;
        }

        public void Remove(T item)
        {
            items.Remove(item);
        }

        public void Clear()
        {
            items.Clear();
        }
    }
}
