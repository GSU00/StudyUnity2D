using System;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class Study_Array : MonoBehaviour
{
    // public : 다른 클래스에서 접근가능 + 유니티 에디터에서도
    // privat : default, 자신의 클래스만 접근가능
    public int[] arrayNumber = new int[5] { 1, 2, 3, 4, 5 };

    public List<int> listNumber = new List<int>();

    int number1 = 1;
    private int number2 = 2;

    public int number3 = 3;
    [SerializeField] // 필드직렬화 : 보안높음, but 유니티에서 접근가능하도록 변경 <-> [DeserializeField] 역직렬화 : 직렬화된 필드를 원래대로
    private int number4 = 4;
    [SerializeField] int number5 = 5;

    void Start()
    {
        Debug.Log($"Array의 첫번째 값 : {arrayNumber[0]}");
        Debug.Log($"Array의 세번째 값 : {arrayNumber[2]}");
        // Debug.Log($"Array의 여섯번째 값 : {arrayNumber[5]}");

        listNumber.Add(1);
        listNumber.Add(2);
        listNumber.Add(3);
        listNumber.Add(4);
        listNumber.Add(5);

                                            // arrayNumber.Length
        Debug.Log($"현재 List에 있는 데이터 수 : {listNumber.Count}");

        Debug.Log($"현재 List의 마지막 데이터 : {listNumber[listNumber.Count - 1]}");
    }
}
