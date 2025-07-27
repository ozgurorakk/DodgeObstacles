using UnityEngine;
using UnityEngine.SceneManagement;

public class managerSc : MonoBehaviour
{
    //Script.
    public static managerSc _managerScript;
    backgroundManager _bgManagerSc;

    //Buttons.
    [SerializeField] private GameObject _startButton;
    [SerializeField] public GameObject _gameOver;

    //High score system.
    [SerializeField] public GameObject _highScoreText;

    private void Awake()
    {
        _managerScript = this;
        Time.timeScale = 0;
        _startButton.SetActive(true);
        _gameOver.SetActive(false);
        _highScoreText.SetActive(true);
        _bgManagerSc = GameObject.Find("Background Music").GetComponent<backgroundManager>();
    }
   

    void Update()
    {

    }
    public void StartButton()
    {
        Time.timeScale = 1;
        _highScoreText.SetActive(false);
        _startButton.SetActive(false);
        _bgManagerSc.DownBackgroundMusic();
    }
    public void OpenMenuFreezeTime()
    {
        _gameOver.SetActive(true);
        Time.timeScale = 0;
    }
    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}
