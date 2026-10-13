using UnityEngine;

public class KingABDUA : MonoBehaviour
{
    public AudioSource audioSource;

    public void Toggle()
    {
        if (audioSource.isPlaying) audioSource.Stop();
        else audioSource.Play();
    }
}