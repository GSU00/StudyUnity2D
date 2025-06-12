using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class RemoteController : MonoBehaviour
{
    [Header("영상 스크린 오브젝트")]
    public GameObject videoScreen;
    public Button[] buttonUI;
    public VideoClip[] clips;
    private VideoPlayer videoPlayer;

    public int currentClipIndex = 0; // 현재 영상 index

    public bool isOn = false;
    public bool isMute = false;

    private void Awake()
    {
        videoPlayer = videoScreen.GetComponent<VideoPlayer>();
        videoPlayer.clip = clips[0]; // Default 영상 설정
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

        /// GameObject 속성을 활용해서 적은 방법
        /// videoScreen.SetActive(!videoScreen.activeSelf);

        /// NOT을 활용하여 줄여서 적은 방법
        /// isOn = !isOn;
        /// videoScreen.SetActive(isOn);

        /// 길게 적은 방법
        /// if (!isOn) // isOn == false
        /// {
        ///     videoScreen.SetActive(true);
        ///     isOn = true; // 현재 티비 On
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
