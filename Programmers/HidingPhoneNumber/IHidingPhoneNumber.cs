﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Programmers.HidingPhoneNumber
{
    /// <summary>
    /// https://programmers.co.kr/learn/courses/30/lessons/12948
    /// </summary>
    /// 
    /// 문제 설명
    /// 프로그래머스 모바일은 개인정보 보호를 위해 고지서를 보낼 때 고객들의 전화번호의 일부를 가립니다.
    /// 전화번호가 문자열 phone_number로 주어졌을 때, 전화번호의 뒷 4자리를 제외한 나머지 숫자를 전부 *으로 가린 문자열을
    /// 리턴하는 함수, solution을 완성해주세요.
    /// 
    /// 제한사항
    /// s는 길이 4 이상, 20이하인 문자열입니다.
    /// 
    /// 입출력 예
    /// phone_number	return
    /// 01033334444	    *******4444
    /// 027778888	    *****8888
    interface IHidingPhoneNumber : IQuestion<string, string>
    {
    }
}
