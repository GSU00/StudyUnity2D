using UnityEngine;
using UnityEngine.Video;

namespace Cat
{
    public class Video_Manager : MonoBehaviour
    {
        public GameObject videoPanel;

        public VideoPlayer vPlayer;
        public VideoClip[] vClips;

        private void Start()
        {
            vPlayer = GetComponent<VideoPlayer>();
        }

        public void VideoPlay(bool isHappy)
        {
            videoPanel.SetActive(true);

            var clip = isHappy ? vClips[0] : vClips[1];
            vPlayer.clip = clip;
            vPlayer.Play();
        }
    }
}
