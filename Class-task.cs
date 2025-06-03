List<City> cities = new List<City>
{
    new City { Id = 1, Name = "Dushanbe" },
    new City { Id = 2, Name = "Khujand" },
    new City { Id = 3, Name = "Bokhtar" },
    new City { Id = 4, Name = "Kulob" },
    new City { Id = 5, Name = "Dushanbe" },
    new City { Id = 6, Name = "Tursunzoda" },
    new City { Id = 7, Name = "Dushanbe" },
    new City { Id = 8, Name = "Vahdat" },
    new City { Id = 9, Name = "Asht" },
    new City { Id = 10, Name = "Hisor" }
};


List<Person> persons = new List<Person>
{
   new Person { Id = 1, Name = "Ali", Age = 25, CityId = 1 },
   new Person { Id = 2, Name = "Zarina", Age = 30, CityId = 2 },
   new Person { Id = 3, Name = "Farrukh", Age = 22, CityId = 3 },
   new Person { Id = 4, Name = "Nargis", Age = 28, CityId = 4 },
   new Person { Id = 5, Name = "Kamol", Age = 35, CityId = 5 },
   new Person { Id = 6, Name = "Malika", Age = 6, CityId = 6 },
   new Person { Id =  7, Name = "Islom", Age = 27, CityId = 7 },
   new Person { Id = 8, Name = "Dilrabo", Age = 23, CityId = 8 },
   new Person { Id = 9, Name = "Shahrom", Age = 4, CityId = 9 },
   new Person { Id = 10, Name = "Madina", Age = 26, CityId = 10 }
};



//#1
// var personWithAge1 = persons.Where(p => p.Age > 25).Select(p => new { PersonName = p.Name, Age = p.Age });
// foreach (var p in personWithAge1)
// {
//     Console.WriteLine(p.PersonName + " " + p.Age);
// }
// System.Console.WriteLine();

// var personWithAge2 =
// (from p in persons
//  where p.Age > 25
//  select new { PersonName = p.Name, Age = p.Age }).ToList();
// foreach (var p in personWithAge2)
// {
//     Console.WriteLine(p.PersonName + " " + p.Age);
// }
// System.Console.WriteLine();


// //#2
// var orderedPersons = persons.OrderBy(p => p.Age).ThenBy(p => p.Name);
// foreach (var p in orderedPersons)
// {
//     Console.WriteLine(p.Name + " " + p.Age);
// }
// System.Console.WriteLine();

// var orderedPersons1 =
// (from p in persons
//  orderby p.Name
//  orderby p.Age
//  select p);
//  foreach (var p in orderedPersons1)
// {
//     Console.WriteLine(p.Name + " " + p.Age);
// }
// System.Console.WriteLine();


//#3

// var personsGroups = persons.GroupBy(p => p.Name[0]);
// foreach (var pr in personsGroups)
// {
//     Console.WriteLine(pr.Key);
//     foreach (var p in pr)
//     {
//         System.Console.WriteLine(p.Name + " " + p.Age);
//     }
//     System.Console.WriteLine();
// }
// System.Console.WriteLine();

// var personsGroups1 =
// (from p in persons
//  group p by p.Name[0] into g
//  select g
// ).ToList();
// foreach (var pr in personsGroups1)
// {
//     Console.WriteLine(pr.Key);
//     foreach (var p in pr)
//     {
//         System.Console.WriteLine(p.Name + " " + p.Age);
//     }
//     System.Console.WriteLine();
// }
// System.Console.WriteLine();


// //#4
// var personWithCities = persons.Join(
//     cities,
//     p => p.CityId,
//     c => c.Id,
//     (p, c) => new
//     {
//         personsName = p.Name,
//         cityName = c.Name
//     }
// );
// foreach (var pc in personWithCities)
// {
//     Console.WriteLine(pc.personsName + " " + pc.cityName);
// }
// System.Console.WriteLine();

// var personWithCities1 =
// (from p in persons
//  join c in cities on p.CityId equals c.Id
// select new
// {
//     personsName = p.Name,
//     cityName = c.Name
// }).ToList();
// foreach (var pc in personWithCities1)
// {
//     Console.WriteLine(pc.personsName + " " + pc.cityName);
// }
// System.Console.WriteLine();


//#5
// var personsWithGlasnie = persons.Where(p => p.Name.StartsWith('A') 
// || p.Name.StartsWith('E') || p.Name.StartsWith('U') 
// || p.Name.StartsWith('I') || p.Name.StartsWith('O'));
// System.Console.WriteLine(personsWithGlasnie.Sum(p => p.Age));
// System.Console.WriteLine();

// var personsWithGlasnie1 =
// (from p in persons
//  where p.Name.StartsWith('A')
//  || p.Name.StartsWith('E') || p.Name.StartsWith('U')
//  || p.Name.StartsWith('I') || p.Name.StartsWith('O')
//  select p).ToList();
// System.Console.WriteLine(personsWithGlasnie1.Sum(p => p.Age));
// System.Console.WriteLine();


//#6
// var personsCountPerGroups = persons.GroupBy(p => p.Name[0]).Distinct();
// foreach (var pr in personsCountPerGroups)
// {
//     Console.WriteLine(pr.Key + " " + pr.Count());
// }
// System.Console.WriteLine();

// var personsCountPerGroups1 =
// (from p in persons
//  group p by p.Name[0] into g
//  select g);
// foreach (var pr in personsCountPerGroups1)
// {
//     Console.WriteLine(pr.Key + " " + pr.Count());
// }
// System.Console.WriteLine();


// //$7
// var personByCities = persons.Join(
//     cities,
//     p => p.CityId,
//     c => c.Id,
//     (p, c) => new
//     {
//         personsName = p.Name,
//         cityName = c.Name,
//         cityId = p.CityId
//     }
//     );

// var personsGroupedByCity = personByCities.GroupBy(p => p.cityName);
// var cityWithMaxPerson = personsGroupedByCity.OrderByDescending(p => p.Count()).First();
// System.Console.WriteLine(cityWithMaxPerson.Key + " " + cityWithMaxPerson.Count());

// var personByCities1 =
// (from p in persons
//  join c in cities on p.CityId equals c.Id
//  select new
//  {
//      personsName = p.Name,
//      cityName = c.Name,
//      cityId = p.CityId
//  }).GroupBy(c => c.cityName);

// var cityWithMaxPerson1 = personByCities1.OrderByDescending(p => p.Count()).First();
// System.Console.WriteLine(cityWithMaxPerson1.Key + " " + cityWithMaxPerson1.Count());


// //#8
// var KidsByCity = persons.Join(
//     cities,
//     p => p.CityId,
//     c => c.Id,

//     (p, c) => new
//     {
//         personsName = p.Name,
//         cityName = c.Name,
//         PersonAge = p.Age
//     }
//     ).Where(pc => pc.PersonAge > 1 && pc.PersonAge < 8 && pc.cityName[0] == 'A')
//     .GroupBy(pc => pc.cityName);

// foreach (var pc in KidsByCity)
// {
//     System.Console.WriteLine(pc.Key);
//     foreach (var p in pc)
//     {
//         System.Console.WriteLine(p.personsName + " " + p.PersonAge);
//     }
// }

// var KidsByCity1 =
// (from p in persons
//  join c in cities on p.CityId equals c.Id
//  where p.Age > 1 && p.Age < 8 && c.Name[0] == 'A'
//  select new
//  {
//      personsName = p.Name,
//      cityName = c.Name,
//      PersonAge = p.Age
//  }).GroupBy(pc => pc.cityName);

// foreach (var pc in KidsByCity1)
// {
//     System.Console.WriteLine(pc.Key);
//     foreach (var p in pc)
//     {
//         System.Console.WriteLine(p.personsName + " " + p.PersonAge);
//     }
// }