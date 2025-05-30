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
        h = Input.GetAxis("Horizontal"); // Ű �Է�

        jump();
    }

    void FixedUpdate()
    {
        Move();
    }

    /// <summary>
    /// ĳ������ �������� ���� �̹����� Flip ���°� ���ϴ� ���
    /// </summary>
    private void Move()
    {
        if (h != 0) // ������ ��
        {
            if (isGround)
            {
                renderers[0].gameObject.SetActive(false); // idle
                renderers[1].gameObject.SetActive(true); // run
                renderers[2].gameObject.SetActive(false); // jump
            }

            characterRb.linearVelocityX = h * moveSpeed; // �������� �̵�

            // �̵����⿡ ���� ��������Ʈ �¿����
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
        else if (h == 0 && isGround) // �ȿ����� ��
        {
            renderers[0].gameObject.SetActive(true); // idle
            renderers[1].gameObject.SetActive(false); // run
            renderers[2].gameObject.SetActive(false); // jump
        }
    }

    private void jump()
    {
        // �����̽� Ű �Է�, 2�� ����������
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
