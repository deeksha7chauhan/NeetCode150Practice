public class TimeMap {
    // Dictionary to store keys with their timestamp-value pairs
    private Dictionary<string, List<Tuple<int, string>>> keyStore;
//Declaration tells your class: "I have a dictionary named keyStore."
//Initialization tells your class: "Now create the actual dictionary so we can use it."
    // Constructor to initialize the dictionary
    public TimeMap() {
        keyStore = new Dictionary<string, List<Tuple<int, string>>>();
    }

    // Method to store a value associated with a key and timestamp
    public void Set(string key, string value, int timestamp) {
        // If key doesn't exist, initialize a new list for that key
        if (!keyStore.ContainsKey(key)) {
            keyStore[key] = new List<Tuple<int, string>>();
        }
        // Add the timestamp-value pair to the list
        keyStore[key].Add(Tuple.Create(timestamp, value));
    }

    // Method to retrieve the most recent value for a key at or before the given timestamp
    public string Get(string key, int timestamp) {
        // If key doesn't exist, return an empty string
        if (!keyStore.ContainsKey(key)) {
            return "";
        }

        var values = keyStore[key]; // Retrieve list of timestamp-value pairs for the given key
        int left = 0, right = values.Count - 1; // Initialize binary search pointers
        string result = ""; // Variable to store the latest valid result

        // Binary search to find the correct timestamp-value pair
        while (left <= right) {
            int mid = left + (right - left) / 2; // Calculate middle index

            // If the timestamp at mid index is less than or equal to the target timestamp
            if (values[mid].Item1 <= timestamp) {
                result = values[mid].Item2; // Update result with current mid value
                left = mid + 1; // Continue searching towards the right
            } else {
                right = mid - 1; // Continue searching towards the left
            }
        }

        return result; // Return the most recent value found or empty string if none found
    }
}
#Time & Space Complexity
Time complexity: O(1) for set() and O(logn) for get().
Space complexity: O(m∗n)
