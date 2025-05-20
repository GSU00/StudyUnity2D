using UnityEngine;

public class Calculater : MonoBehaviour
{
    public int number1, number2;

    void Start()
    {
        int a = AddMethod(); // 함수호출

        int s = SubMethod(); // 함수호출

        Debug.Log($"number1 + number2 = {a}, number1 - number2 = {s}");
    }

    int AddMethod()
    {
        // 지역변수 result
        int result = number1 + number2;
    
        return result;
    }
    int SubMethod()
    {
        // 지역변수 result
        int result = number1 - number2;
    
        return result;
    }
}
