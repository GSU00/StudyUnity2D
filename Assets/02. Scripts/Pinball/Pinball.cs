using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Pinball : MonoBehaviour
{
    public Pinball_Manager pinballManager;

    private void OnCollisionEnter2D(Collision2D other)
    {
        //if (other.gameObject.CompareTag("Score10"))
        //{
        //    pinballManager.totalScore += 10;
        //    Debug.Log("10¡° »πµÊ");
        //}
        //else if (other.gameObject.CompareTag("Score20"))
        //{
        //    pinballManager.totalScore += 20;
        //    Debug.Log("20¡° »πµÊ");
        //}
        //else if (other.gameObject.CompareTag("Score30"))
        //{
        //    pinballManager.totalScore += 30;
        //    Debug.Log("30¡° »πµÊ");
        //}
        //else if (other.gameObject.CompareTag("Score50"))
        //{
        //    pinballManager.totalScore += 50;
        //    Debug.Log("50¡° »πµÊ");
        //}

        // ¿ß π›∫πµ«¥¬ ifπÆ¿ª ∞°µ∂º∫ ≥Ù∞‘ switch πÆ¿∏∑Œ ∫Ø∞Ê 
        int score = 0;
        switch (other.gameObject.tag)
        {
            case "Score10":
                score = 10; 
                break;
            case "Score20":
                score = 20;
                break;
            case "Score30":
                score = 30;
                break;
            case "Score50":
                score = 50;
                break;
            default:
                return;
        }

        pinballManager.totalScore += score;
        Debug.Log($"{score}¡° »πµÊ");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("GameOver"))
        {
            Debug.Log($"∞‘¿” ¡æ∑·\n√÷¡æ¡°ºˆ : {pinballManager.totalScore}");
        }
    }
}
