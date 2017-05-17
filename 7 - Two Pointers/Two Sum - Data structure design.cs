using System;
using System.Collections;
using System.Collections.Generic;

namespace TwoSum
{
    public class TwoSum {
        private List<int> list = null;
        private Dictionary<int, int> dict = null;
        public TwoSum() {
            list = new List<int>();
            dict = new Dictionary<int, int>();
        }

        // Add the number to an internal data structure.
        public void add (int number) {
            if (dict.ContainsKey(number)) {
                dict.Add(number, dict[number] + 1);
            } else {
                dict.Add(number, 1);
            }
        }

        // Find if there exists any pair of numbers which sum is equal to the value.
        public bool find (int value) {
            for (int i = 0; i < dict.Count; i++) {
                int n1 = dict[0];
                int n2 = value - dict[0];
                if ((n1 == n2 && dict[n1] > 1) || (n1 != n2 && dict.ContainsKey(n2))) {
                    return true;
                }
            }
            return false;
        }
    }
}
// Your TwoSum object will be instantiated and called as such:
// TwoSum twoSum = new TwoSum();
// twoSum.add(number);
// twoSum.find(value);