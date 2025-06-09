using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Cat
{
    public class UI_Manager : MonoBehaviour
    {
        public GameObject playObj;
        public GameObject introUI;

        public TMP_InputField inputField;
        public TextMeshProUGUI nameTextUI;

        public Button startButton;

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
                playObj.SetActive(true);
                introUI.SetActive(false);

                Debug.Log($"{nameTextUI} �Է�");
                nameTextUI.text = inputField.text;
            }
        }
    }
}