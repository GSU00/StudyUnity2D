using UnityEngine;

public abstract class Monster : MonoBehaviour, IDamageable
{
    public float hp;

    public abstract void SetHealth();

    public void TakeDamage(float damage)
    {
        Debug.Log($"{damage}만큼 피해를 입혔습니다.");

        hp -= damage;
        if (hp <= 0)
            Death();
    }

    public void Death()
    {
        Debug.Log("몬스터 다운");
    }
}
