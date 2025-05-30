using UnityEngine;

public class Movement : MonoBehaviour
{
    // ����Ƽ �����Ϳ��� ���� : �ǽð����� ���� �ٲ㰡�鼭 �׽�Ʈ�� �ʿ��� ����� ����
    public float moveSpeed = 10f;

    public static int coinCount = 0;

    void Update()
    {

        /// Input System (Old - Legacy)
        /// �Է°��� ���� ��ӵ� �ý���
        /// �̵� -> WASD, ȭ��ǥŰ����
        /// ���� -> Space
        /// �ѽ�� -> ���콺 ����

        //// GetKeyDown, GetKeyUp => 1�� ����, GetKey => ���ӽ���
        //if (Input.GetKey(KeyCode.W)) // ������ ���� ���
        //{
        //    // Z������ 1��ŭ moveSpeed ����ŭ �̵�
        //    // position ��ġ, rotation ����, scale ũ��
        //    this.transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.S)) // �ڷ� ���� ���
        //{
        //    this.transform.position += Vector3.back * moveSpeed * Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.A)) // �������� ���� ���
        //{
        //    this.transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.D)) // ���������� ���� ���
        //{
        //    this.transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        //}

        
        // �̵��ϴ� ���
        // Input.GetAxisRaw() �ﰢ�� ����
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        // Input.GetAxis() �ε巴�� ����
        //float h = Input.GetAxis("Horizontal");
        //float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, 0, v);

        Vector3 normalDir = dir.normalized; // ����ȭ���� (-1 ~ 1) -> ��������
        
        //Debug.Log($"���� �Է� : {normalDir}");

        transform.position += normalDir * moveSpeed * Time.deltaTime;

        // �ٶ󺸴�(ȸ���ϴ�) ���
        transform.LookAt(transform.position + normalDir);
    }
}
