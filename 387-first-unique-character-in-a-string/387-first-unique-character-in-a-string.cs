public class Solution {
    public int FirstUniqChar(string s) {
       var dic = new Dictionary<char, int>();
            foreach (var a in s ){
                if (dic.ContainsKey(a))
                {
                    dic[a]++;
                }
                else
                {
                    dic.Add(a, 1);
                }
            };
            var found = dic.FirstOrDefault(a => a.Value == 1);
            if (found.Key != null)
            {
                return s.IndexOf(found.Key);
            }
            else
                return -1;
    }
}