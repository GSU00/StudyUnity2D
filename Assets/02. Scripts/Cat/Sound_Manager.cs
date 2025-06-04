using UnityEngine;

namespace Cat
{
    public class Sound_Manager : MonoBehaviour
    {
        public AudioSource audioSource;
        public AudioClip bgmClip;
        public AudioClip jumpClip;

        private void Start()
        {
            SetBGMSound();
        }

        public void SetBGMSound()
        {
            audioSource.clip = bgmClip; // ����� �ҽ��� ���� ���� ����
            audioSource.playOnAwake = true; // ������ �� �ڵ� ���
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
    }
}
