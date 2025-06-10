using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI playTimeUI;
    private float timer;

    private void Update()
    {
        timer += Time.deltaTime;

        // playTimeUI.text = string.Format("플레이시간 : {0:F1}초", timer); // timer.ToString();

        playTimeUI.text = $"플레이시간 : {timer:F1}초";
    }
}
