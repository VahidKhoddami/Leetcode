// Insert delete get random O(1): https://leetcode.com/problems/insert-delete-getrandom-o1/
/*
 Example 1:

Input
["RandomizedSet", "insert", "remove", "insert", "getRandom", "remove", "insert", "getRandom"]
[[], [1], [2], [2], [], [1], [2], []]
Output
[null, true, false, true, 2, true, false, 2]

Explanation
RandomizedSet randomizedSet = new RandomizedSet();
randomizedSet.insert(1); // Inserts 1 to the set. Returns true as 1 was inserted successfully.
randomizedSet.remove(2); // Returns false as 2 does not exist in the set.
randomizedSet.insert(2); // Inserts 2 to the set, returns true. Set now contains [1,2].
randomizedSet.getRandom(); // getRandom() should return either 1 or 2 randomly.
randomizedSet.remove(1); // Removes 1 from the set, returns true. Set now contains [2].
randomizedSet.insert(2); // 2 was already in the set, so return false.
randomizedSet.getRandom(); // Since 2 is the only number in the set, getRandom() will always return 2.
 */
public class RandomizedSet
{
    private readonly List<int> _list;
    private readonly Dictionary<int, int> _dictionary;

    public RandomizedSet()
    {
        _list = new List<int>();
        _dictionary = new Dictionary<int, int>();
    }

    public bool Insert(int val)
    {
        if (_dictionary.ContainsKey(val))
        {
            return false;
        }

        _list.Add(val);
        _dictionary.Add(val, _list.Count - 1);
        return true;
    }
    public bool Remove(int val)
    {
        if (!_dictionary.ContainsKey(val))
        {
            return false;
        }

        var index = _dictionary[val];
        var lastElement = _list[_list.Count - 1];
        _list[index] = lastElement;
        _dictionary[lastElement] = index;
        _list.RemoveAt(_list.Count - 1);
        _dictionary.Remove(val);
        return true;
    }

    public int GetRandom()
    {
        var random = new Random();
        var index = random.Next(0, _list.Count);
        return _list[index];
    }

}