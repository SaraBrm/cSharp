using System.Collections;
using System.Collections.Generic;

namespace PhonebookByDictionary
{
    public class RepositoryContact<T> : IEnumerable<T> where T : IKey
    {
        private Dictionary<string, T> contacts = new Dictionary<string, T>();

        public int TotalContact
        {
            get { return contacts.Count; }
        }
        public void AddContact(T contact)
        {
            contacts.Add(contact.PhoneNumber, contact);
        }
        public void Remove(string phoneNumber)
        {
            contacts.Remove(phoneNumber);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var contact in contacts)
                yield return contact.Value;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public T this[string phoneNumber]
        {
            get
            {
                return contacts[phoneNumber];
            }

        }
    }
}
