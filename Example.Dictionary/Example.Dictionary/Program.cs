using System;
using System.Collections;
using System.Collections.Generic;

namespace Example.Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Repository<Person> persons = new Repository<Person>();
            persons.Add(new Person()
            {
                Id= 1,
                FirstName="Sara",
                LastName="Brm"
            });
            Console.WriteLine(persons[1].FirstName);
            foreach(var person in persons)
            {
                Console.WriteLine("Id:"+person.Id+" FirstName:"+person.FirstName+" LastName:"+person.LastName);
            }
        }
    }

    public class Person : IKey
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public interface IKey
    {
        public int Id { get; set; }
    }
    public class Repository<T>:IEnumerable<T> where T : IKey
    {
        private Dictionary<int,T> entities=new Dictionary<int,T>();
        public void Add(T entity)
        {
            entities.Add(entity.Id, entity);
        }
        public void Remove(T entity)
        {
            entities.Remove(entity.Id);
        }
        public void Remove( int key)
        {
            entities.Remove(key);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var entity in entities)
            {
                yield return entity.Value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public T this[int key]
        {
            get { return entities[key]; }
        }
    }
}
