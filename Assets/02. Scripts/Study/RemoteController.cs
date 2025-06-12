using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class RemoteController : MonoBehaviour
{
    [Header("���� ��ũ�� ������Ʈ")]
    public GameObject videoScreen;
    public Button[] buttonUI;
    public VideoClip[] clips;
    private VideoPlayer videoPlayer;

    public int currentClipIndex = 0; // ���� ���� index

    public bool isOn = false;
    public bool isMute = false;

    private void Awake()
    {
        videoPlayer = videoScreen.GetComponent<VideoPlayer>();
        videoPlayer.clip = clips[0]; // Default ���� ����
    }

    private void Start()
    {
        buttonUI[0].onClick.AddListener(OnScreenPower);
        buttonUI[1].onClick.AddListener(OnMute);
        buttonUI[2].onClick.AddListener(OnNextChannel);
        buttonUI[3].onClick.AddListener(OnPrevChannel);
    }

    public void OnScreenPower()
    {
        isOn = !isOn;
        videoScreen.SetActive(isOn);

        /// GameObject �Ӽ��� Ȱ���ؼ� ���� ���
        /// videoScreen.SetActive(!videoScreen.activeSelf);

        /// NOT�� Ȱ���Ͽ� �ٿ��� ���� ���
        /// isOn = !isOn;
        /// videoScreen.SetActive(isOn);

        /// ��� ���� ���
        /// if (!isOn) // isOn == false
        /// {
        ///     videoScreen.SetActive(true);
        ///     isOn = true; // ���� Ƽ�� On
        /// }
        /// else // isOn == true
        /// {
        ///     videoScreen.SetActive(false);
        ///     isOn = false;
        /// }
    }

    public void OnMute()
    {
        isMute = !isMute;
        videoPlayer.SetDirectAudioMute(0, isMute);
    }

    public void OnNextChannel()
    {
        currentClipIndex++;
        if (currentClipIndex >= clips.Length)
            currentClipIndex = 0;


        videoPlayer.clip = clips[currentClipIndex];
        videoPlayer.Play();
    }

    public void OnPrevChannel()
    {
        currentClipIndex--;
        if (currentClipIndex < 0)
            currentClipIndex = clips.Length - 1;

        videoPlayer.clip = clips[currentClipIndex];
        videoPlayer.Play();
    }
}
