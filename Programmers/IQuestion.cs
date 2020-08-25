namespace Programmers
{
    public interface IQuestion<T1, T2>
    {
        T2 Solution(T1 input);
    }
}
