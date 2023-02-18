public class Solution {
    public string ReverseWords(string s) {
           var words = s.Split(' ');
            var wordsList=words.Where(a=>!string.IsNullOrEmpty(a)).Reverse().ToList();
            return String.Join(" ", wordsList);
    }
}