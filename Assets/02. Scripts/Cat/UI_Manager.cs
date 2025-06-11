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

        public TMP_InputField inputField;
        public TextMeshProUGUI nameTextUI;

        public Button startButton;

        private void Awake()
        {
            introUI.SetActive(true);
            playObj.SetActive(false);
            playUI.SetActive(false);
        }

        void Start()
        {
            startButton.onClick.AddListener(OnStartButton);
        }

        public void OnStartButton()
        {
            bool isNoText = inputField.text == "";

            if (isNoText)
            {
                Debug.Log("�Է��� �ؽ�Ʈ ����");
            }
            else
            {
                introUI.SetActive(false);
                playObj.SetActive(true);
                playUI.SetActive(true);
                GameManager.isPlay = true;

                soundManager.SetBGMSound("Play");

                Debug.Log($"{nameTextUI} �Է�");
                nameTextUI.text = inputField.text;
            }
        }
    }
}