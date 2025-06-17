using UnityEngine;

public class TownPerson : MonoBehaviour, IMove, ITalk
{
    public float hp;
    public float moveSpeed;

    public void Move()
    {
        Debug.Log("이동");
    }

    public void Talk()
    {
        Debug.Log("말하기");
    }
}
