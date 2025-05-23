using UnityEngine;

public class Study_GameObject : MonoBehaviour
{
    public GameObject prefab;

    public Vector3 pos;
    public Quaternion rot;

    // Start 보다 빨리 실행되는 Awake, 시스템 주축 세팅
    void Awake()
    {
        CreateImporster();
    }

    /// <summary>
    /// 어몽어스 캐릭터를 생성하고 이름을 변경하는 기능
    /// </summary>
    public void CreateImporster()
    {
        GameObject obj = Instantiate(prefab, pos, rot); // GameObject를 생성하는 기능, (생성할 데이터, 위치, 회전)
        obj.name = "임포스터";

        //// 지역변수에 담아서 쓰면 가독성 증가
        //Transform objTf = obj.transform;
        //int count = objTf.childCount;

        //Debug.Log($"캐릭터의 자식 오브젝트의 수 : {count}");
        //Debug.Log($"캐릭터의 첫번째 자식 오브젝트의 이름 : {objTf.GetChild(0).name}");
        //Debug.Log($"캐릭터의 마지막 자식 오브젝트의 이름 : {objTf.GetChild(count - 1).name}");
        //Debug.Log($"캐릭터의 첫번째 자식 오브젝트의 첫번째 자식 오브젝트의 이름 : {objTf.GetChild(0).GetChild(0).name}");
    }
}
