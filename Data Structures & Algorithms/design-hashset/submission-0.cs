public class MyHashSet {
    private List<int>[] buckets;
    private int size = 1000;

    public MyHashSet() {
        buckets = new List<int>[size];
        for(int i = 0; i<size; i++){
            buckets[i] = new List<int>();
        }
    }

    private int Hash(int key){
        return key % size;
    }
    
    public void Add(int key) {
        int index = Hash(key);
        if(!buckets[index].Contains(key)){
            buckets[index].Add(key);
        }
    }
    
    public void Remove(int key) {
        int index = Hash(key);
        buckets[index].Remove(key);
    }
    
    public bool Contains(int key) {
        int index = Hash(key);
        return buckets[index].Contains(key);
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */