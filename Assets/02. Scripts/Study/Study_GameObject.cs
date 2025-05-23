using UnityEngine;

public class Study_GameObject : MonoBehaviour
{
    public GameObject prefab;

    public Vector3 pos;
    public Quaternion rot;

    // Start ���� ���� ����Ǵ� Awake, �ý��� ���� ����
    void Awake()
    {
        CreateImporster();
    }

    /// <summary>
    /// ���� ĳ���͸� �����ϰ� �̸��� �����ϴ� ���
    /// </summary>
    public void CreateImporster()
    {
        GameObject obj = Instantiate(prefab, pos, rot); // GameObject�� �����ϴ� ���, (������ ������, ��ġ, ȸ��)
        obj.name = "��������";

        //// ���������� ��Ƽ� ���� ������ ����
        //Transform objTf = obj.transform;
        //int count = objTf.childCount;

        //Debug.Log($"ĳ������ �ڽ� ������Ʈ�� �� : {count}");
        //Debug.Log($"ĳ������ ù��° �ڽ� ������Ʈ�� �̸� : {objTf.GetChild(0).name}");
        //Debug.Log($"ĳ������ ������ �ڽ� ������Ʈ�� �̸� : {objTf.GetChild(count - 1).name}");
        //Debug.Log($"ĳ������ ù��° �ڽ� ������Ʈ�� ù��° �ڽ� ������Ʈ�� �̸� : {objTf.GetChild(0).GetChild(0).name}");
    }
}
