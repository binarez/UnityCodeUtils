using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[System.Serializable]
public class SerializableDictionary<K, V> : Dictionary<K, V>, ISerializationCallbackReceiver
{
    [SerializeField]
    KeyValuePair<K, V>[] serializableKeyValues_ = null;

    public void OnBeforeSerialize()
    {
        serializableKeyValues_ = this.ToArray();
        if(serializableKeyValues_.Length > 0)
        {
            l.o.g.msg("Serializing " + serializableKeyValues_.Length + " key-value pairs.");
        }
    }

    public void OnAfterDeserialize()
    {
        if (serializableKeyValues_ != null)
        {
            Clear();
            foreach (KeyValuePair<K, V> pair in serializableKeyValues_)
            {
                Add(pair.Key, pair.Value);
            }
            serializableKeyValues_ = null; // forget!
        }
    }
}
