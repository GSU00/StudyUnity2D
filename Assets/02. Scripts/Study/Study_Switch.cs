using UnityEngine;

public class Study_Switch : MonoBehaviour
{
    public enum CalulationType { Plus, Sub, Multiply, Divide }; // ������ ����
    public CalulationType type = CalulationType.Plus;

    public int input1, input2, result;

    private void Start()
    {
        Debug.Log($"��� ��� : {Calculation()}");
    }

    private int Calculation()
    {
        switch (type)
        {
            case CalulationType.Plus:
                result = input1 + input2;
                break;
            case CalulationType.Sub:
                result = input1 - input2;
                break;
            case CalulationType.Multiply:
                result = input1 * input2;
                break;
            case CalulationType.Divide:
                result = input1 / input2;
                break;
        }

        return result;
    }
}
