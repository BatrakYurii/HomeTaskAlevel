using System;
using System.Collections.Generic;
using System.Linq;

namespace Master
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>()
            {
                new Person(){Id = 1,Age = 13,FirstName = "Andrey", LastName = "Sokol", Email = "andryuu@gmail.com", AddressList = new List<int> {1,2 }},
                new Person(){Id = 2,Age = 23,FirstName = "Stas", LastName = "Sudov", Email = "stasik1997@gmail.com", AddressList = new List<int> {3 }},
                new Person(){Id = 3,Age = 17,FirstName = "Maxim", LastName = "Butenko", Email = "monster@gmail.com", AddressList = new List<int> {4,5}},
                new Person(){Id = 4,Age = 40,FirstName = "Danil", LastName = "Petrov", Email = "dania777@gmail.com", AddressList = new List<int> {6 }}
            };

            List<Address> adresses = new List<Address>()
            {
                new Address(){Id=1, Country="Ukraine", State="Kharkivska", City="Kharkiv", ZipCode="62000", AddressLine="Chkalova 1"},
                new Address(){Id=2, Country="Ukraine", State="Zaporizka", City="Melitopol", ZipCode="72313", AddressLine="Peremoga 17"},
                new Address(){Id=3, Country="Ukraine", State="Kharkivska", City="Izum", ZipCode="43255", AddressLine="Super Street 10"},
                new Address(){Id=4, Country="Ukraine", State="Zaporizka", City="Berdyansk", ZipCode="53945", AddressLine="Morskaya 44"},
                new Address(){Id=5, Country="Ukraine", State="Odesska", City="Odessa", ZipCode="73755", AddressLine="Portovaya 50"},
                new Address(){Id=6, Country="Ukraine", State="Kharkivska", City="Kharkiv", ZipCode="62200", AddressLine="Chkalova 10"}
            };


            //1. Join Person and Adress
            var newPersons = persons.SelectMany(p => p.AddressList,
                (p, a) => new { Person = p, Address = a});

            var result = from p in newPersons
                         where p.Person.FirstName == "Andrey"
                         join a in adresses on p.Address equals a.Id
                         select new { Name = $"{p.Person.LastName} {p.Person.FirstName}", a.Country, a.City, a.AddressLine };

            Console.WriteLine("1.");
            foreach (var person in result)
            {
                Console.WriteLine($"{person.Name}, {person.Country}, {person.City}, {person.AddressLine}");
            }
            Console.WriteLine("\n");


            //2. 
            var olderEighteen = persons.Where(p => p.Age > 18);
            Console.WriteLine("2.");
            foreach (Person person in olderEighteen)
            {
                Console.WriteLine($"{person.LastName} {person.FirstName} : Age = {person.Age}");
            }
            Console.WriteLine("\n");

            //3
            var personWithAdress = newPersons.Join(adresses,
                p => p.Address,
                a => a.Id,
                (p, a) => new
                {
                    FirstName = p.Person.FirstName,
                    LastName = p.Person.LastName,
                    Age = p.Person.Age,
                    Email = p.Person.Email,
                    Country = a.Country,
                    State = a.State,
                    City = a.City,
                    ZipCode = a.ZipCode,
                    AdressLine = a.AddressLine
                });



            var personFromSomeState = adresses.GroupJoin(personWithAdress,
                a => a.State,
                pr => pr.State,
                (adress, prs) => new
                {
                   State = adress.State,
                   Name = prs.Select(p => p),
                   Address = $"{adress.Country}, {adress.State} oblast, {adress.City}, {adress.AddressLine}"
                }
                );

            Console.WriteLine("3.");
            foreach (var state in personFromSomeState)
            {
                Console.WriteLine(state.State);
                foreach(var person in state.Name)
                {
                    Console.WriteLine($"  - {person.LastName} {person.FirstName} : {person.City}, {person.AdressLine}, {person.ZipCode}");
                }
            }
            Console.WriteLine("\n");


            //4
            var avarageAge = Math.Round(persons.Average(p => p.Age));
            Console.WriteLine("4.");
            Console.WriteLine($"Средний возраст - {avarageAge}");
            Console.WriteLine("\n");
        }
    }
}
