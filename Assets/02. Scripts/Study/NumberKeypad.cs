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

        Debug.Log($"{numString} 입력 -> 현재입력 : {keypadNumber}");
    }

    public void OnCheckNumber()
    {
        if (keypadNumber == password)
        {
            Debug.Log("문열림");

            doorAnim.SetTrigger("Door Open");

            doorLock.SetActive(false);
        }
        else
        {
            keypadNumber = "";
            Debug.Log("비밀번호 오류");
        }
    }
}
