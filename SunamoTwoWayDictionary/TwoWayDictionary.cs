namespace SunamoTwoWayDictionary;

public class TwoWayDictionary<TKey, TValue> where TKey : notnull where TValue : notnull
{
    public Dictionary<TKey, TValue> ForwardDictionary { get; set; }

    public Dictionary<TValue, TKey> ReverseDictionary { get; set; }

    public TwoWayDictionary(int capacity)
    {
        ForwardDictionary = new Dictionary<TKey, TValue>(capacity);
        ReverseDictionary = new Dictionary<TValue, TKey>(capacity);
    }

    public TwoWayDictionary()
    {
        ForwardDictionary = new Dictionary<TKey, TValue>();
        ReverseDictionary = new Dictionary<TValue, TKey>();
    }

    public void Add(TKey key, TValue value)
    {
        ForwardDictionary.Add(key, value);
        ReverseDictionary.Add(value, key);
    }
}
