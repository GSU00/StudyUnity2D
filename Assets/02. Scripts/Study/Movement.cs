using UnityEngine;

public class Movement : MonoBehaviour
{
    // 유니티 에디터에서 변경 : 실시간으로 값을 바꿔가면서 테스트한 필요한 경우의 변수
    public float moveSpeed = 10f;

    public static int coinCount = 0;

    void Update()
    {

        /// Input System (Old - Legacy)
        /// 입력값에 대한 약속된 시스템
        /// 이동 -> WASD, 화살표키보드
        /// 점프 -> Space
        /// 총쏘기 -> 마우스 왼쪽

        //// GetKeyDown, GetKeyUp => 1번 실행, GetKey => 연속실행
        //if (Input.GetKey(KeyCode.W)) // 앞으로 가는 기능
        //{
        //    // Z축으로 1만큼 moveSpeed 값만큼 이동
        //    // position 위치, rotation 각도, scale 크기
        //    this.transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.S)) // 뒤로 가는 기능
        //{
        //    this.transform.position += Vector3.back * moveSpeed * Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.A)) // 왼쪽으로 가는 기능
        //{
        //    this.transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.D)) // 오른쪽으로 가는 기능
        //{
        //    this.transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        //}

        
        // 이동하는 기능
        // Input.GetAxisRaw() 즉각적 반응
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        // Input.GetAxis() 부드럽게 증가
        //float h = Input.GetAxis("Horizontal");
        //float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, 0, v);

        Vector3 normalDir = dir.normalized; // 정규화과정 (-1 ~ 1) -> 단위벡터
        
        //Debug.Log($"현재 입력 : {normalDir}");

        transform.position += normalDir * moveSpeed * Time.deltaTime;

        // 바라보는(회전하는) 기능
        transform.LookAt(transform.position + normalDir);
    }
}
