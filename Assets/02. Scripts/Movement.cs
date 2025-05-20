using UnityEngine;

public class Movement : MonoBehaviour
{
    // ����Ƽ �����Ϳ��� ���� : �ǽð����� ���� �ٲ㰡�鼭 �׽�Ʈ�� �ʿ��� ����� ����
    public float moveSpeed = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // this.transform.position = this.transform.position + Vector3.forward;
    }

    // Update is called once per frame
    void Update()
    {
        // GetKeyDown, GetKeyUp => 1�� ����, GetKey => ���ӽ���
        if (Input.GetKey(KeyCode.W)) // ������ ���� ���
        {
            // Z������ 1��ŭ moveSpeed ����ŭ �̵�
            // position ��ġ, rotation ����, scale ũ��
            this.transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S)) // �ڷ� ���� ���
        {
            this.transform.position += Vector3.back * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A)) // �������� ���� ���
        {
            this.transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D)) // ���������� ���� ���
        {
            this.transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }
    }
}
