using UnityEngine;

public class Study_Overloading : MonoBehaviour
{
    void Start()
    {
        Attack();
        Attack(true);
        Attack(10);

        GameObject monsterObj = new GameObject("����");

        Attack(10, monsterObj);
    }

    public void Attack()
    {
        Debug.Log("����");
    }

    public void Attack(bool isMagic)
    {
        if (isMagic)
            Debug.Log("���� ����");
    }
    
    public void Attack(int damage)
    {
        Debug.Log($"{damage} ������ ��ŭ ����");
    }
    
    public void Attack(int damage, GameObject target)
    {
        Debug.Log($"{target.name}���� {damage}������ ��ŭ ����");
    }
}
