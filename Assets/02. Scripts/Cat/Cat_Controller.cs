using UnityEngine;
using Cat;
using UnityEngine.Video;
using System.Collections;

public class Cat_Controller : MonoBehaviour
{
    public Sound_Manager soundManager;
    public Video_Manager videoManager;

    public GameObject gameOverUI;
    public GameObject fadeUI;
    public GameObject playUI;

    private Rigidbody2D catRb;
    private Animator catAnim;

    public float jumpPower = 20f;
    public float limitPower = 10f;
    public bool isGround = false;
    public int jumpCount = 0;

    void Awake()
    {
        catRb = GetComponent<Rigidbody2D>();
        catAnim = GetComponent<Animator>();
    }

    void OnEnable()
    {
        transform.localPosition = Vector3.zero;
        GetComponent<CircleCollider2D>().enabled = true;
        soundManager.audioSource.mute = false;
    }

    void Update()
    {
        // �����̽� Ű �Է�, 2�� ���� ����
        //if (Input.GetKeyDown(KeyCode.Space) && isGround)

        // �����̽� Ű �Է�, 2�� ����������
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < 10)
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
                fadeUI.GetComponent<FadePanel>().OnFade(3f, Color.white, true);
                this.GetComponent<CircleCollider2D>().enabled = false;

                //Invoke("HappyVideo", 5f);
                StartCoroutine(EndingRoutine(true));
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
            fadeUI.GetComponent<FadePanel>().OnFade(3f, Color.black, true); // ���̵� ����
            this.GetComponent<CircleCollider2D>().enabled = false;

            //Invoke("SadVideo", 5f);
            StartCoroutine(EndingRoutine(false));
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

    IEnumerator EndingRoutine(bool isHappy)
    {
        yield return new WaitForSeconds(3.5f); // ����ŭ ���

        videoManager.VideoPlay(isHappy);
        yield return new WaitForSeconds(1f);
        // yield return new WaitUntil(()=> videoManager.vPlayer.isPlaying); //�ڿ����� bool���� true�� �ȶ����� ���

        var newColor = isHappy ? Color.white : Color.black;
        fadeUI.GetComponent<FadePanel>().OnFade(3f, newColor, false); // ���̵� ����

        fadeUI.SetActive(false);
        gameOverUI.SetActive(false);
        soundManager.audioSource.Stop();
        //soundManager.audioSource.mute = true;

        Debug.Log("���� ��� �Ϸ�");

        transform.parent.gameObject.SetActive(false); // PLAY ������Ʈ Off
    }

    //private void HappyVideo()
    //{
    //    videoManager.VideoPlay(true);
    //    fadeUI.SetActive(false);
    //    gameOverUI.SetActive(false);

    //    soundManager.audioSource.mute = true;
    //}
    
    //private void SadVideo()
    //{
    //    videoManager.VideoPlay(false);
    //    fadeUI.SetActive(false);
    //    gameOverUI.SetActive(false);

    //    soundManager.audioSource.mute = true;
    //}
}
