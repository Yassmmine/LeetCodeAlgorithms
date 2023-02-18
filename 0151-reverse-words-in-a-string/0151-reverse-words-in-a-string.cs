public class Solution {
    public string ReverseWords(string s) {
         Stack<string> reverse = new Stack<string>(); //Space: O(n)
            StringBuilder sb = new StringBuilder(s.Trim()); //Space: O(n), Trim input string as we need ignore spaces at the start and end.

            for (int i = 0; i < sb.Length; i++) //Time: O(n)
            {
                StringBuilder word = new StringBuilder(); //always use StringBuilder if using string inside a loop
                while (i < sb.Length && sb[i] != ' ') //travel till you find next space, this will crop each word for you
                {
                    word.Append(sb[i]);
                    i++;
                }
                reverse.Push(word.ToString()); //add cropped word to stack

                while (i < sb.Length && sb[i + 1] == ' ') i++; //ignore extra spaces, we only care about 1 space, if there are 4 or 10000 spaces we are going to ignore all of them

                if (i < sb.Length) reverse.Push(" "); //add one space after each word          
            }
            return String.Join("", reverse); //Time: O(n):  just join all the string from stack and return result

    }
}