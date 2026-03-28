namespace SunamoTwoWayDictionary;

/// <summary>
/// A dictionary that maintains bidirectional mapping between keys and values,
/// allowing lookup in both directions.
/// </summary>
/// <typeparam name="TKey">The type of the forward key.</typeparam>
/// <typeparam name="TValue">The type of the forward value.</typeparam>
public class TwoWayDictionary<TKey, TValue> where TKey : notnull where TValue : notnull
{
    /// <summary>
    /// Gets or sets the forward dictionary mapping keys to values.
    /// </summary>
    public Dictionary<TKey, TValue> ForwardDictionary { get; set; }

    /// <summary>
    /// Gets or sets the reverse dictionary mapping values to keys.
    /// </summary>
    public Dictionary<TValue, TKey> ReverseDictionary { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="TwoWayDictionary{TKey, TValue}"/> class with specified capacity.
    /// </summary>
    /// <param name="capacity">The initial capacity of both dictionaries.</param>
    public TwoWayDictionary(int capacity)
    {
        ForwardDictionary = new Dictionary<TKey, TValue>(capacity);
        ReverseDictionary = new Dictionary<TValue, TKey>(capacity);
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="TwoWayDictionary{TKey, TValue}"/> class.
    /// </summary>
    public TwoWayDictionary()
    {
        ForwardDictionary = new Dictionary<TKey, TValue>();
        ReverseDictionary = new Dictionary<TValue, TKey>();
    }

    /// <summary>
    /// Adds a key-value pair to both the forward and reverse dictionaries.
    /// </summary>
    /// <param name="key">The key for the forward dictionary.</param>
    /// <param name="value">The value for the forward dictionary, which becomes the key in the reverse dictionary.</param>
    public void Add(TKey key, TValue value)
    {
        ForwardDictionary.Add(key, value);
        ReverseDictionary.Add(value, key);
    }
}
