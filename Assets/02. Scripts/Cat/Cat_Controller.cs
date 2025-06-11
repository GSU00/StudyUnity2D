using UnityEngine;
using Cat;
using UnityEngine.Video;

public class Cat_Controller : MonoBehaviour
{
    public Sound_Manager soundManager;

    public GameObject gameOverUI;
    public GameObject fadeUI;
    public GameObject playUI;

    private Rigidbody2D catRb;
    private Animator catAnim;

    public float jumpPower = 10f;
    public float limitPower = 7f;
    public bool isGround = false;
    public int jumpCount = 0;

    public GameObject happyVideo;
    public GameObject sadVideo;

    void Start()
    {
        catRb = GetComponent<Rigidbody2D>();
        catAnim = GetComponent<Animator>();
    }

    void Update()
    {
        // �����̽� Ű �Է�, 2�� ���� ����
        //if (Input.GetKeyDown(KeyCode.Space) && isGround)
        // �����̽� Ű �Է�, 2�� ����������
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < 5)
        {
            catAnim.SetTrigger("Jump");
            catAnim.SetBool("IsGround", false);

            catRb.AddForceY(jumpPower, ForceMode2D.Impulse);
            jumpCount++;

            soundManager.OnJumpSound();

            if (catRb.linearVelocityY > limitPower) // �ڿ������� ������ ���� �ӵ� ����
                catRb.linearVelocityY = limitPower;
        }

        var catRotation = transform.eulerAngles;
        catRotation.z = catRb.linearVelocityY * 2.5f;
        transform.eulerAngles = catRotation;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Apple"))
        {
            other.gameObject.SetActive(false);
            other.transform.parent.GetComponent<ItemEvent>().particle.SetActive(true);

            GameManager.score++;

            if (GameManager.score == 10) // ����� 10�� �Ծ ����
            {
                fadeUI.SetActive(true);
                playUI.SetActive(false);
                fadeUI.GetComponent<FadePanel>().OnFade(3f, Color.white);
                this.GetComponent<CircleCollider2D>().enabled = false;

                Invoke("HappyVideo", 5f);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Pipe")) // �������� �ε����� ����
        {
            soundManager.OnColliderSound();

            gameOverUI.SetActive(true); // ���� ���� �ѱ�
            fadeUI.SetActive(true); // ���̵� �ѱ�
            playUI.SetActive(false);
            fadeUI.GetComponent<FadePanel>().OnFade(3f, Color.black); // ���̵� ����
            this.GetComponent<CircleCollider2D>().enabled = false;

            Invoke("SadVideo", 5f);
        }

        if (other.gameObject.CompareTag("Ground"))
        {
            catAnim.SetBool("IsGround", true);
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

    private void HappyVideo()
    {
        happyVideo.SetActive(true);
        fadeUI.SetActive(false);
        gameOverUI.SetActive(false);

        soundManager.audioSource.mute = true;
    }

    private void SadVideo()
    {
        sadVideo.SetActive(true);
        fadeUI.SetActive(false);
        gameOverUI.SetActive(false);

        soundManager.audioSource.mute = true;
    }
}
