using UnityEngine;

public class RouletteController : MonoBehaviour
{
    public float rotSpeed = 0f;

    public bool isStop = false;

    void Update()
    {
        transform.Rotate(Vector3.forward * rotSpeed);
        // == transform.Rotate(0f, 0f, rotSpeed);

        // ���콺 ���� ��ư�� ������ �� ȸ���ϴ� ���
        if (Input.GetMouseButtonDown(0))
        {
            rotSpeed = Random.Range(5f,10f);
        }

        // Ű���� �����̽� ��ư�� ������ ��
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isStop = true;
        }

        // Ű���� R ��ư�� ������ ��
        if (Input.GetKeyDown(KeyCode.R))
        {
            isStop = false;
        }

        if (isStop == true)
        {
            rotSpeed *= 0.98f;
            if (rotSpeed < 0.05f)
            {
                rotSpeed = 0f;
            }
        }
    }
}
