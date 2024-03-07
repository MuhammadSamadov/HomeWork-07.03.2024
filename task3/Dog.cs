namespace task3;

public class Dog
{
    string? _name;
    string? _breed;
    int _age;
    public Dog(string name,string breed,int age)
    {
        _name=name;
        _breed=breed;
        _age=age;
    }
    public string GetInfo()
    {
        return $"Name:{_name}\nBreed:{_breed}\nAge:{_age}";
    }

}
