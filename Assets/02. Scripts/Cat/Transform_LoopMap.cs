using UnityEngine;

public class Transform_LoopMap : MonoBehaviour
{
    public float moveSpeed = 3f;

    // 이미지의 길이가 40이기 떄문에 x = 40f
    public Vector3 returnPos = new Vector3(40f, 2.1f, 0f);

    void Update()
    {
        // 배경이 왼쪽으로 이동하는 기능
        // 컴퓨터 성능에 따라 달라지는 값이기 때문에 실선이슈 발생 가능
        //transform.position += Vector3.left * moveSpeed * Time.DeltaTime;

        transform.position += Vector3.left * moveSpeed * Time.fixedDeltaTime;

        if (transform.position.x <= -40f) // 이미지의 x축 값이 -40을 넘는 순간
        {
            transform.position = returnPos; // 다시 사용하기 위해 오른쪽 40으로 초기화
        }
    }
}
