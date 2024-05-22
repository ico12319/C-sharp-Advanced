
var countriesCount = int.Parse(Console.ReadLine());

var continentData = new Dictionary<string, Continent>();

for (int i = 0; i < countriesCount; i++)
{
    var tokens = Console.ReadLine().Split();
    var continentName = tokens[0];
    var countryName = tokens[1];
    var cityName = tokens[2];

    if (!continentData.ContainsKey(continentName))
    {
        continentData.Add(continentName, new Continent(continentName));
    }


    var continent = continentData[continentName];

    Country country = continent.GetCountryByName(countryName);
    if (country == null)
    {
        country = new Country(countryName);
        continent.addCountry(country);
    }

    City city = new City(cityName);
    country.addCity(city);
}

foreach (var item in continentData)
{
    item.Value.printContinent();
}

Console.ReadKey();
   



public class City
{
    private string name;

    public string Name { get; private set; }

    public City(string name)
    {
        this.Name = name;
    }

    public override string ToString()
    {
        return Name;
    }

}


public class Country
{
    private string countryName;
    private List<City> cities;




    public string Name { get; private set; }
    public Country()
    {
        this.cities = new List<City>();
    }


    public Country(string name)
    {
        this.Name = name;
        this.cities = new List<City>();
    }

    public void addCity(City city)
    {
        cities.Add(city);
    }

    public void printCountry()
    {
        Console.Write($"{Name} -> ");
        Console.WriteLine(string.Join(", ", cities));
    }

    public bool containsCity(string cityName)
    {
        for (int i = 0; i < cities.Count; i++)
        {
            if (cities[i].Name == cityName)
                return true;
        }
        return false;
    }
}

public class Continent
{
    private string name;
    List<Country> countries;

    public Continent()
    {
        countries = new List<Country>();
    }

    public Continent(string name)
    {
        this.name = name;
        this.countries = new List<Country>();
    }

    public void addCountry(Country country)
    {
        countries.Add(country);
    }

    public void printContinent()
    {
        Console.WriteLine($"{name}:");
        for (int i = 0; i < countries.Count; i++)
        {
            countries[i].printCountry();
        }
    }

    public bool containsCountry(string countryName)
    {
        for (int i = 0; i < countries.Count; i++)
        {
            if (countries[i].Name == countryName)
                return true;
        }
        return false;
    }

    public Country GetCountryByName(string name)
    {
        return countries.Find(c => c.Name == name);
    }







}