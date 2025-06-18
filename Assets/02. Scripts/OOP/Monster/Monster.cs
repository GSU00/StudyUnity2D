using UnityEngine;

public abstract class Monster : MonoBehaviour
{
    private SpriteRenderer sRanderer;

    [SerializeField] protected float hp = 3f;
    [SerializeField] protected float moveSpeed = 5f;

    private int dir = 1;

    public abstract void Init();

    private void Start()
    {
        sRanderer = GetComponent<SpriteRenderer>();

        Init();
    }
    void OnMouseDown()
    {
        Hit(1);
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.position += Vector3.right * moveSpeed * dir * Time.deltaTime;

        if (transform.position.x > 8 || transform.position.x < -8)
        {
            sRanderer.flipX = !sRanderer.flipX;
            dir = -dir;
        }
    }

    void Hit(float damage)
    {
        hp -= damage;

        if (hp <= 0)
        {
            Debug.Log("¸ó½ºÅÍ Á×À½");
            Destroy(gameObject);
        }
    }
}
