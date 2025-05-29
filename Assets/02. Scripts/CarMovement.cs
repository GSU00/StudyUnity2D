using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float moveSpeed = 3f;

    public Rigidbody2D carRb;

    float h;

    void Update()
    {
        h = Input.GetAxis("Horizontal");

        // transform 이동
        //transform.position += Vector3.right * h * moveSpeed * Time.deltaTime;

    }

    // 고정 프레임으로 실행되는 유니티 기본 함수
    private void FixedUpdate()
    {
        // Rigidbody의 속도를 활용한 이동
        carRb.linearVelocityX = h * moveSpeed;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision Enter");
        Debug.Log(other.gameObject.name);
        // other.gameObject.SetActive(false);
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        Debug.Log("Collision Stay");
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        Debug.Log("Collision Exit");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Collider Enter");
        Debug.Log(other.gameObject.name);
        // other.gameObject.SetActive(false);
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("Collider Stay");
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("Collider Exit");
    }
}
