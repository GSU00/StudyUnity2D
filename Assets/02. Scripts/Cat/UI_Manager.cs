using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Cat
{
    public class UI_Manager : MonoBehaviour
    {
        public Sound_Manager soundManager;

        public GameObject playObj;
        public GameObject introUI;
        public GameObject playUI;
        public GameObject videoPanel;

        public TMP_InputField inputField;
        public TextMeshProUGUI nameTextUI;

        public Button startButton;
        public Button restartButton;

        private void Awake()
        {
            introUI.SetActive(true);
            playObj.SetActive(false);
            playUI.SetActive(false);
        }

        void Start()
        {
            startButton.onClick.AddListener(OnStartButton);
            restartButton.onClick.AddListener(OnRestartButton);
        }

        public void OnStartButton()
        {
            bool isNoText = inputField.text == "";

            if (isNoText)
            {
                Debug.Log("입력한 텍스트 없음");
            }
            else
            {
                introUI.SetActive(false);
                playObj.SetActive(true);
                playUI.SetActive(true);
                GameManager.isPlay = true;

                soundManager.SetBGMSound("Play");

                Debug.Log($"{nameTextUI} 입력");
                nameTextUI.text = inputField.text;
            }
        }

        public void OnRestartButton()
        {
            GameManager.ResetPlayUI();
            videoPanel.SetActive(false);
            playObj.SetActive(true);
            playUI.SetActive(true);
        }
    }
}