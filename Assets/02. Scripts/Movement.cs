using UnityEngine;

public class Movement : MonoBehaviour
{
    // 유니티 에디터에서 변경 : 실시간으로 값을 바꿔가면서 테스트한 필요한 경우의 변수
    public float moveSpeed = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // this.transform.position = this.transform.position + Vector3.forward;
    }

    // Update is called once per frame
    void Update()
    {
        // GetKeyDown, GetKeyUp => 1번 실행, GetKey => 연속실행
        if (Input.GetKey(KeyCode.W)) // 앞으로 가는 기능
        {
            // Z축으로 1만큼 moveSpeed 값만큼 이동
            // position 위치, rotation 각도, scale 크기
            this.transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S)) // 뒤로 가는 기능
        {
            this.transform.position += Vector3.back * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A)) // 왼쪽으로 가는 기능
        {
            this.transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D)) // 오른쪽으로 가는 기능
        {
            this.transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }
    }
}
