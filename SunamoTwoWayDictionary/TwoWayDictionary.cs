namespace SunamoTwoWayDictionary;

/// <summary>
/// Represents the two way dictionary t key t value type.
/// </summary>
public class TwoWayDictionary<TKey, TValue> where TKey : notnull where TValue : notnull
{
    /// <summary>
    /// Gets or sets the forward dictionary.
    /// </summary>
    public Dictionary<TKey, TValue> ForwardDictionary { get; set; }

    /// <summary>
    /// Gets or sets the reverse dictionary.
    /// </summary>
    public Dictionary<TValue, TKey> ReverseDictionary { get; set; }

    /// <summary>
    /// Two way dictionary.
    /// </summary>
    /// <param name="capacity">The capacity.</param>
    /// <returns>The two way dictionary result.</returns>
    public TwoWayDictionary(int capacity)
    {
        ForwardDictionary = new Dictionary<TKey, TValue>(capacity);
        ReverseDictionary = new Dictionary<TValue, TKey>(capacity);
    }

    /// <summary>
    /// Initializes a new instance of the two way dictionary class.
    /// </summary>
    /// <param name="capacity">The capacity.</param>
    public TwoWayDictionary()
    {
        ForwardDictionary = new Dictionary<TKey, TValue>();
        ReverseDictionary = new Dictionary<TValue, TKey>();
    }

    /// <summary>
    /// Initializes a new instance of the add class.
    /// </summary>
    public void Add(TKey key, TValue value)
    {
        ForwardDictionary.Add(key, value);
        ReverseDictionary.Add(value, key);
    }
}
