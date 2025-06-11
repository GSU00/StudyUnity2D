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
        public static int score; // ��� ���� ����
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

                // playTimeUI.text = string.Format("�÷��̽ð� : {0:F1}��", timer); // timer.ToString();

                playTimeUI.text = $"�÷��̽ð� : {timer:F1}��";
                scoreUI.text = $"X {score}";
            }
        }
    }
}
