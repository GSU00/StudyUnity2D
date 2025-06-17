using UnityEngine;

public class BrokenWall : MonoBehaviour, IDamageable
{
    public float hp = 100f;

    public void TakeDamage(float damage)
    {
        Debug.Log($"{damage}만큼 피해를 입혔습니다.");

        hp -= damage;
        if (hp <= 0)
            Death();
    }

    public void Death()
    {
        Debug.Log("벽이 파괴되었습니다.");
    }
}
