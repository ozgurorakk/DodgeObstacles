using UnityEngine;

public class backgroundManager : MonoBehaviour
{
    [SerializeField] AudioSource _au;

    //Music source.
    [SerializeField] AudioClip _bgMusic;
    void Start()
    {
        _au = GetComponent<AudioSource>();
    }

   public void DownBackgroundMusic()
    {
        _au.volume = 0.1f;
    }
}
