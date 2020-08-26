namespace Programmers.MiddleLetters
{
    public class MiddleLetters_DD : IMiddleLetters
    {
        public string Solution(string s)
        {
            int length = s.Length;
            switch(length%2)
            {
                case 0:
                    return $"{s[length/2-1]}{s[length/2]}";
                case 1:
                    return $"{s[length/2]}";
                default:
                    return null;
            }
        }
    }
}
