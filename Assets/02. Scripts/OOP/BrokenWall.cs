using UnityEngine;

public class BrokenWall : MonoBehaviour, IDamageable
{
    public float hp = 100f;

    public void TakeDamage(float damage)
    {
        Debug.Log($"{damage}��ŭ ���ظ� �������ϴ�.");

        hp -= damage;
        if (hp <= 0)
            Death();
    }

    public void Death()
    {
        Debug.Log("���� �ı��Ǿ����ϴ�.");
    }
}
