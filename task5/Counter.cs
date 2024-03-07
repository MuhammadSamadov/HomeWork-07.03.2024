namespace task5;

public class Counter
{
    int _value;
    public Counter(int value)
    {
        _value=value;
    }
    public void Decrement()
    {
        _value--;
        if(_value<0)
        {
            return ;
        }
    }
    public void Reset()
    {
        if(_value>0)
        {
            _value=0;
        }
    }
    public int PrintValue()
    {
        return _value;
    }
}
