using System.Collections;
using UnityEngine;

public abstract class Monster : MonoBehaviour
{
    private SpriteRenderer sRanderer;
    private Animator animator;
    public SpawnerManager spawner;

    [SerializeField] protected float hp = 3f;
    [SerializeField] protected float moveSpeed = 5f;

    private int dir = 1;
    private bool isMove = true;
    private bool isHit = false;

    public abstract void Init();

    private void Start()
    {
        sRanderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();

        spawner = FindFirstObjectByType<SpawnerManager>();

        if (Random.Range(0, 2) == 0)
        {
            dir = -1;
            sRanderer.flipX = true;
        }
        else
        {
            dir = 1;
            sRanderer.flipX = false;
        }

        Init();
    }
    void OnMouseDown()
    {
        //Hit(1);
        StartCoroutine(Hit(1));
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        if (!isMove) return;
        
        transform.position += Vector3.right * moveSpeed * dir * Time.deltaTime;

        if (transform.position.x > 8 || transform.position.x < -8)
        {
            sRanderer.flipX = !sRanderer.flipX;
            dir = -dir;
        }
        
    }

    IEnumerator Hit(float damage)
    {
        if (isHit) yield break; 

        isHit = true;
        isMove = false;
        animator.SetTrigger("Hit");

        hp -= damage;

        if (hp <= 0)
        {
            animator.SetTrigger("Death");

            spawner.DropCoin(transform.position);

            yield return new WaitForSeconds(3f);
            gameObject.SetActive(false);
            yield break;
        }

        yield return new WaitForSeconds(0.66f);
        isMove = true;
        isHit = false;
    }
}
