using UnityEngine;
using UnityEngine.Audio;

public class FireSound : MonoBehaviour
{
    private AudioSource audioSource;
    // [SerializeField] private AudioClip fireSound1;
    [SerializeField] private AudioResource audioResource;

    void Start() {
        audioSource = GetComponent<AudioSource>();
        // audioSource.clip = fireSound1;
        audioSource.resource = audioResource;
        audioSource.Play();
    }


}
