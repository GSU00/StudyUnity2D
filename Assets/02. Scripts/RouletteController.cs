using UnityEngine;

public class RouletteController : MonoBehaviour
{
    public float rotSpeed = 0f;

    public bool isStop = false;

    void Update()
    {
        transform.Rotate(Vector3.forward * rotSpeed);
        // == transform.Rotate(0f, 0f, rotSpeed);

        // 마우스 왼쪽 버튼을 눌렀을 때 회전하는 기능
        if (Input.GetMouseButtonDown(0))
        {
            rotSpeed = Random.Range(5f,10f);
        }

        // 키보드 스페이스 버튼을 눌렀을 때
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isStop = true;
        }

        // 키보드 R 버튼을 눌렀을 때
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
