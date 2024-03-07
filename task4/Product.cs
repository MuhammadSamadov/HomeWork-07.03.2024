namespace task4;

public class Product
{
    string? _name;
    double _price;
    int _quantity;
    public Product(string name,double price,int quantity)
    {
        _name=name;
        _price=price;
        _quantity=quantity;
    }
    public string GetInfo()
    {
        return $"Name:{_name}\nPrice:{_price}\nPcs:{_quantity}";
    }

}
