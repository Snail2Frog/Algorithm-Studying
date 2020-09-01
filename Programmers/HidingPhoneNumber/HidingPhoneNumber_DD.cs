namespace Programmers.HidingPhoneNumber
{
    public class HidingPhoneNumber_DD : IHidingPhoneNumber
    {
        public string Solution(string phone_number)
        {
            int totalLength = phone_number.Length;
            int hidingLength = totalLength - 4;

            string answer = phone_number.Remove(0, hidingLength);

            answer = answer.PadLeft(totalLength, '*');

            return answer;
        }
    }
}
