// OPTIMAL APPROACH (Real HashMap)
// 💡 Idea: Hashing + Buckets

// We use:

// index = key % size

// Each index stores a bucket (list of pairs) → handles collisions

public class MyHashMap
{
    private List<(int key, int value)>[] buckets;
    private int size = 1000;

    public MyHashMap()
    {
        buckets = new List<(int, int)>[size];
        for (int i = 0; i < size; i++)
        {
            buckets[i] = new List<(int, int)>();
        }
    }

    private int Hash(int key)
    {
        return key % size;
    }

    public void Put(int key, int value)
    {
        int index = Hash(key);

        foreach (var pair in buckets[index])
        {
            if (pair.key == key)
            {
                buckets[index].Remove(pair);
                buckets[index].Add((key, value));
                return;
            }
        }

        buckets[index].Add((key, value));
    }

    public int Get(int key)
    {
        int index = Hash(key);

        foreach (var pair in buckets[index])
        {
            if (pair.key == key)
            {
                return pair.value;
            }
        }

        return -1;
    }

    public void Remove(int key)
    {
        int index = Hash(key);

        foreach (var pair in buckets[index])
        {
            if (pair.key == key)
            {
                buckets[index].Remove(pair);
                return;
            }
        }
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */