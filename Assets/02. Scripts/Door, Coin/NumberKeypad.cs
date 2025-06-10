using UnityEngine;

public class NumberKeypad : MonoBehaviour
{
    public Animator doorAnim;

    public GameObject doorLock;

    public string password;
    public string keypadNumber;

    public void OnInputNumber(string numString)
    {
        keypadNumber += numString;

        Debug.Log($"{numString} �Է� -> �����Է� : {keypadNumber}");
    }

    public void OnCheckNumber()
    {
        if (keypadNumber == password)
        {
            Debug.Log("������");

            doorAnim.SetTrigger("Door Open");

            doorLock.SetActive(false);
        }
        else
        {
            keypadNumber = "";
            Debug.Log("��й�ȣ ����");
        }
    }
}
