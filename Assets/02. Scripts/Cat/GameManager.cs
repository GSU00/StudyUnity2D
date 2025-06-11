using TMPro;
using UnityEngine;

namespace Cat
{
    public class GameManager : MonoBehaviour
    {
        public Sound_Manager soundManager;

        public TextMeshProUGUI playTimeUI;
        public TextMeshProUGUI scoreUI;

        private float timer;
        public static int score; // 사과 먹은 갯수
        public static bool isPlay;

        private void Start()
        {
            soundManager.SetBGMSound("Intro");
        }

        private void Update()
        {
            if (isPlay)
            {
                timer += Time.deltaTime;

                // playTimeUI.text = string.Format("플레이시간 : {0:F1}초", timer); // timer.ToString();

                playTimeUI.text = $"플레이시간 : {timer:F1}초";
                scoreUI.text = $"X {score}";
            }
        }
    }
}
