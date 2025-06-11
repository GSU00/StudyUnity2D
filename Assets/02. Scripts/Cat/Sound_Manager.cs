using UnityEngine;

namespace Cat
{
    public class Sound_Manager : MonoBehaviour
    {
        public AudioSource audioSource;
        public AudioClip introBgmClip;
        public AudioClip playBgmClip;
        public AudioClip jumpClip;
        public AudioClip colliderClip;

        public void SetBGMSound(string bgmName)
        {
            if (bgmName == "intro")
                audioSource.clip = introBgmClip; // 오디오 소스에 사운드 파일 설정
            else if (bgmName == "play")
                audioSource.clip = playBgmClip;
            
            audioSource.loop = true; // 반복 기능
            audioSource.volume = 0.1f; // 소리 음량

            audioSource.Play(); // 시작

            // audioSource.Stop(); // 정지
            // audioSource.Pause(); // 일시정지
        }

        public void OnJumpSound()
        {
            audioSource.PlayOneShot(jumpClip); // 이벤트 사운드
        }
        public void OnColliderSound()
        {
            audioSource.PlayOneShot(colliderClip);
        }
    }
}
