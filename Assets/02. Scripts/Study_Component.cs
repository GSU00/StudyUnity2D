using UnityEngine;

public class Study_Component : MonoBehaviour
{
    // public ����Ƽ���� ���� �Ҵ簡��
    private GameObject obj; // ť�� ���ӿ�����Ʈ�� ��������ʹ�

    public string changeName;






    void Start()
    {
        obj = GameObject.Find("Main Camera");
        
        obj.name = changeName;
    }
}
