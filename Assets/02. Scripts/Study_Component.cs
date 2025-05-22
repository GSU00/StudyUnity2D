using System.Runtime.Serialization;
using UnityEngine;

//접근제한자          클래스명 : 유니티의 유용한 기능이 들어있다
public class Study_Component : MonoBehaviour
{
    // public 유니티에서 직접 할당가능, 외부에서 접근가능
    // private 클래스 내부에서만 접근가능

    // 접근제한자 타입  변수명
    private GameObject obj; // 큐브 게임오브젝트를 가져오고싶다

    public Transform objTf;

    public string changeName;


    void Start()
    {
        // 모든 객체에 접근하여 이름확인
        // obj = GameObject.Find("Main Camera");

        // 태그를 가진 객체에만 접근
        // Player라는 Tag를 가진 게임오브젝트를 찾아서 obj에 할당
        obj = GameObject.FindGameObjectWithTag("Player");

        objTf = GameObject.FindGameObjectWithTag("Player").transform;
        // GameObject 데이터 타입, gameObject 변수
        // objTf.gameObject == obj
        objTf.gameObject.SetActive(false);

        obj.name = changeName;

        Debug.Log($"<color=#FFFF00>이름 : {obj.name}</color>"); // 게임오브젝트의 이름
        Debug.Log($"태그 : {obj.tag}"); // 게임오브젝트의 태그
        Debug.Log($"위치 : {obj.transform.position}"); // 게임오브젝트의 Transform 컴포넌트의 위치
        Debug.Log($"회전 : {obj.transform.rotation}"); // 게임오브젝트의 Transform 컴포넌트의 회전
        Debug.Log($"크기 : {obj.transform.localScale}"); // 게임오브젝트의 Transform 컴포넌트의 크기

        // MeshFilter 컴포넌트에 접근해서 mesh를 Log 메세지로 출력하는 기능
        Debug.Log($"Mesh 데이터 : {obj.GetComponent<MeshFilter>().mesh}");

        // MeshRenderer 컴포넌트에 접근해서 material을 Log 메세지로 출력하는 기능
        Debug.Log($"Material 데이터 : {obj.GetComponent<MeshRenderer>().material}");

        // obj의 MeshRenderer에 접근해서 활성상태를 false로 변경하겠다.
        obj.GetComponent<MeshRenderer>().enabled = false;

        // obj의 GameObject 활성상태를 false로 변경하겠다.
        obj.SetActive(false);
    }
}
