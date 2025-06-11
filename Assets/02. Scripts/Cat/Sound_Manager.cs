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
                audioSource.clip = introBgmClip; // ����� �ҽ��� ���� ���� ����
            else if (bgmName == "play")
                audioSource.clip = playBgmClip;
            
            audioSource.loop = true; // �ݺ� ���
            audioSource.volume = 0.1f; // �Ҹ� ����

            audioSource.Play(); // ����

            // audioSource.Stop(); // ����
            // audioSource.Pause(); // �Ͻ�����
        }

        public void OnJumpSound()
        {
            audioSource.PlayOneShot(jumpClip); // �̺�Ʈ ����
        }
        public void OnColliderSound()
        {
            audioSource.PlayOneShot(colliderClip);
        }
    }
}
