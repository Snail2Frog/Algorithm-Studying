﻿namespace Programmers.MiddleLetters
{
    /// <summary>
    /// https://programmers.co.kr/learn/courses/30/lessons/12903
    /// </summary>
    /// <remarks>
    /// 단어 s의 가운데 글자를 반환하는 함수, solution을 만들어 보세요.
    /// 단어의 길이가 짝수라면 가운데 두글자를 반환하면 됩니다.
    ///
    /// 제한 조건
    /// s는 길이가 1 이상, 100이하인 스트링입니다.
    /// </remarks>
    /// <example>
    /// s	return
    /// abcde	"c"
    /// qwer	"we"
    /// </example>
    interface IMiddleLetters : IQuestion<string, string>
    {
    }
}
