using UnityEngine;

public class CharacterMovement2D : MonoBehaviour
{
    private Rigidbody2D characterRb;
    public SpriteRenderer[] renderers;

    public float moveSpeed;
    private float h;

    public float jumpPower = 5f;
    public int jumpCount = 0;

    public bool isGround = false;

    void Start()
    {
        characterRb = GetComponent<Rigidbody2D>();

        renderers = GetComponentsInChildren<SpriteRenderer>(true);
    }

    void Update()
    {
        h = Input.GetAxis("Horizontal"); // 키 입력

        jump();
    }

    void FixedUpdate()
    {
        Move();
    }

    /// <summary>
    /// 캐릭터의 움직임의 따라 이미지의 Flip 상태가 변하는 기능
    /// </summary>
    private void Move()
    {
        if (h != 0) // 움직일 때
        {
            if (isGround)
            {
                renderers[0].gameObject.SetActive(false); // idle
                renderers[1].gameObject.SetActive(true); // run
                renderers[2].gameObject.SetActive(false); // jump
            }

            characterRb.linearVelocityX = h * moveSpeed; // 물리적인 이동

            // 이동방향에 따라 스프라이트 좌우반전
            if (h > 0)
            {
                renderers[0].flipX = false;
                renderers[1].flipX = false;
                renderers[2].flipX = false;
            }
            else
            {
                renderers[0].flipX = true;
                renderers[1].flipX = true;
                renderers[2].flipX = true;
            }
        }
        else if (h == 0 && isGround) // 안움직일 떄
        {
            renderers[0].gameObject.SetActive(true); // idle
            renderers[1].gameObject.SetActive(false); // run
            renderers[2].gameObject.SetActive(false); // jump
        }
    }

    private void jump()
    {
        // 스페이스 키 입력, 2단 점프까지만
        if (Input.GetButtonDown("Jump") && jumpCount < 2)
        {
            characterRb.AddForceY(jumpPower, ForceMode2D.Impulse);
            jumpCount++;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGround = true;
            jumpCount = 0;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGround = false;

            renderers[0].gameObject.SetActive(false); // idle
            renderers[1].gameObject.SetActive(false); // run
            renderers[2].gameObject.SetActive(true); // jump
        }
    }
}
