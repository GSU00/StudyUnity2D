using UnityEngine;

public class TownPerson : MonoBehaviour, IMove, ITalk
{
    public float hp;
    public float moveSpeed;

    public void Move()
    {
        Debug.Log("�̵�");
    }

    public void Talk()
    {
        Debug.Log("���ϱ�");
    }
}
