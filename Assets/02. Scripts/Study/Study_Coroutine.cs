using System.Collections;
using UnityEngine;

public class Study_Coroutine : MonoBehaviour
{
    bool isStop = false;

    void Start()
    {
        StartCoroutine(BombRoutine());
    }

    IEnumerator BombRoutine() // 대기를 할 수 있는 기능
    {
        int t = 10;
        while (t > 0)
        {
            Debug.Log($"{t}초 남았습니다.");
            yield return new WaitForSeconds(1f);
            t--;
            if (isStop)
            {
                Debug.Log("폭탄이 해제되었습니다.");
                yield break;
            }
        }
        Debug.Log("폭탄이 터졌습니다.");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            isStop = true;
    }
}
