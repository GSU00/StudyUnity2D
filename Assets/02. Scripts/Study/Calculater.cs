using UnityEngine;

public class Calculater : MonoBehaviour
{
    public int number1, number2;

    void Start()
    {
        int a = AddMethod(); // �Լ�ȣ��

        int s = SubMethod(); // �Լ�ȣ��

        Debug.Log($"number1 + number2 = {a}, number1 - number2 = {s}");
    }

    int AddMethod()
    {
        // �������� result
        int result = number1 + number2;
    
        return result;
    }
    int SubMethod()
    {
        // �������� result
        int result = number1 - number2;
    
        return result;
    }
}
