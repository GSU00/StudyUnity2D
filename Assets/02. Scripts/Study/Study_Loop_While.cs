using UnityEngine;

public class Study_Loop_While : MonoBehaviour
{
    private int count = 0;

    void Start()
    {
        while (count <= 10)
        {
            count++;

            // 3�� ��� ����
            if (count % 3 == 0) // count�� 3���� ������ ������ ���� ��, ���� 0�� ������ ���
            {
                Debug.Log("�ڼ� ¦!");
                continue;
            }

            Debug.Log(count);
        }
    }
}
