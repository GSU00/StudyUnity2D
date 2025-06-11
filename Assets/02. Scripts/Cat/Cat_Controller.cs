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
        // 스페이스 키 입력, 2단 점프 방지
        //if (Input.GetKeyDown(KeyCode.Space) && isGround)
        // 스페이스 키 입력, 2단 점프까지만
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < 5)
        {
            catAnim.SetTrigger("Jump");
            catAnim.SetBool("IsGround", false);

            catRb.AddForceY(jumpPower, ForceMode2D.Impulse);
            jumpCount++;

            soundManager.OnJumpSound();

            if (catRb.linearVelocityY > limitPower) // 자연스러운 점프를 위한 속도 제한
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

            if (GameManager.score == 10) // 사과를 10개 먹어서 성공
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
        if (other.gameObject.CompareTag("Pipe")) // 파이프에 부딪혀서 실패
        {
            soundManager.OnColliderSound();

            gameOverUI.SetActive(true); // 게임 오버 켜기
            fadeUI.SetActive(true); // 페이드 켜기
            playUI.SetActive(false);
            fadeUI.GetComponent<FadePanel>().OnFade(3f, Color.black); // 페이드 실행
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
