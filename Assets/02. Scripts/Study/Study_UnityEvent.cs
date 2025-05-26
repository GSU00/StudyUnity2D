using UnityEngine;

public class Study_UnityEvent : MonoBehaviour
{
    void Awake() // 제일 먼저 1번만 실행
    {
        Debug.Log("Awake");
    }

    void Start() // 1번만 실행
    {
        Debug.Log("Start");
    }

    void OnEnable() // GameObject의 Active 상태가 On 될 때마다 실행
    {
        Debug.Log("OnEnable");
    }

    void OnDisable() // GameObject의 Active 상태가 Off 될 때마다 실행
    {
        Debug.Log("DisnEnable");
    }

    void Update()
    {

    }
}
