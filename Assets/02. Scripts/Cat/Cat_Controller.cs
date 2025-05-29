using UnityEngine;

public class Cat_Controller : MonoBehaviour
{
    private Rigidbody2D catRb;
    public float jumpPower = 7f;

    public bool isGround = false;
    public int jumpCount = 0;

    void Start()
    {
        catRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 스페이스 키 입력, 2단 점프 방지
        //if (Input.GetKeyDown(KeyCode.Space) && isGround)
        // 스페이스 키 입력, 2단 점프까지만
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < 2)
        {
            catRb.AddForceY(jumpPower, ForceMode2D.Impulse);
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
        }
    }
}
