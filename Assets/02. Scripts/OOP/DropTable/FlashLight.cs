using UnityEngine;

public class FlashLight : MonoBehaviour, IDropItem
{
    public GameObject lightObj;
    public bool isLight;

    public void Grab(Transform grabPos)
    {
        transform.SetParent(grabPos);
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.identity;

        Debug.Log("����Ʈ�� �ֿ���.");
    }

    public void Use()
    {
        isLight = !isLight;
        lightObj.SetActive(isLight);

        Debug.Log("����Ʈ�� �Ҵ�");
    }

    public void Drop()
    {
        transform.SetParent(null);
        transform.position = Vector3.zero;

        Debug.Log("����Ʈ�� ������.");
    }
}
