using UnityEngine;

public class audioManager : MonoBehaviour
{
    AudioSource _au;

    //Sounds.
    [SerializeField] public AudioClip _scoreSound;
    [SerializeField] public AudioClip _wrongAudio;
    void Start()
    {
        _au = GetComponent<AudioSource>();
    }
    public void Score()
    {
        _au.PlayOneShot(_scoreSound);
    }
    public void Wrong()
    {
        _au.PlayOneShot(_wrongAudio);
    }
    
}
