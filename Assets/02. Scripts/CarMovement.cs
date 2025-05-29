using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float moveSpeed = 3f;

    public Rigidbody2D carRb;

    float h;

    void Update()
    {
        h = Input.GetAxis("Horizontal");

        // transform �̵�
        //transform.position += Vector3.right * h * moveSpeed * Time.deltaTime;

    }

    // ���� ���������� ����Ǵ� ����Ƽ �⺻ �Լ�
    private void FixedUpdate()
    {
        // Rigidbody�� �ӵ��� Ȱ���� �̵�
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
