using UnityEngine;

public class Study_Operator : MonoBehaviour
{
    public int currentLevel = 10;
    public int maxLevel = 99;

    void Start()
    {
        string msg = currentLevel >= maxLevel ? "���� �����Դϴ�." : "���� ������ �ƴմϴ�.";

        Debug.Log(msg);

        if (currentLevel >= maxLevel)
        {
            Debug.Log($"���� ������ �����Դϴ�.");
        }
        else
        {
            Debug.Log($"���� ������ ������ �ƴմϴ�.");
        }
    }
}
