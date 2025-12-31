namespace SunamoTwoWayDictionary;

public class TwoWayDictionary<T, U>
{
    public Dictionary<T, U> D1;
    public Dictionary<U, T> D2;

    public TwoWayDictionary(int c)
    {
        D1 = new Dictionary<T, U>(c);
        D2 = new Dictionary<U, T>(c);
    }

    public TwoWayDictionary()
    {
        D1 = new Dictionary<T, U>();
        D2 = new Dictionary<U, T>();
    }

    public void Add(T key, U value)
    {
        D1.Add(key, value);
        D2.Add(value, key);
    }
}