using UnityEngine;

public class ColliderEvent : MonoBehaviour
{
    public GameObject fadeUI;

    // ��ȣ�ۿ��ϴ�
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Game Over");
            fadeUI.SetActive(true);
        }
    }
}
