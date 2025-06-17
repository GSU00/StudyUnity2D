using UnityEngine;

public abstract class Monster : MonoBehaviour, IDamageable
{
    public float hp;

    public abstract void SetHealth();

    public void TakeDamage(float damage)
    {
        Debug.Log($"{damage}��ŭ ���ظ� �������ϴ�.");

        hp -= damage;
        if (hp <= 0)
            Death();
    }

    public void Death()
    {
        Debug.Log("���� �ٿ�");
    }
}
