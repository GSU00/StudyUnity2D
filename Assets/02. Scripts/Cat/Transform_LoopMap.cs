using UnityEngine;

public class Transform_LoopMap : MonoBehaviour
{
    public float moveSpeed = 3f;

    // �̹����� ���̰� 40�̱� ������ x = 40f
    public Vector3 returnPos = new Vector3(40f, 2.1f, 0f);

    void Update()
    {
        // ����� �������� �̵��ϴ� ���
        // ��ǻ�� ���ɿ� ���� �޶����� ���̱� ������ �Ǽ��̽� �߻� ����
        //transform.position += Vector3.left * moveSpeed * Time.DeltaTime;

        transform.position += Vector3.left * moveSpeed * Time.fixedDeltaTime;

        if (transform.position.x <= -40f) // �̹����� x�� ���� -40�� �Ѵ� ����
        {
            transform.position = returnPos; // �ٽ� ����ϱ� ���� ������ 40���� �ʱ�ȭ
        }
    }
}
