using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
     //Scripts.
    public static GameManager Instance;
    [SerializeField] audioManager _auManagerSc;

    //Speed++
    [Header("Obstacle Speed")]
    public float baseMoveSpeed = 1f;
    public float acceleration = 0.08f;
    public float maxMoveSpeed;

    //Score text.
    [SerializeField] private Text _scoreText;
    [SerializeField] public int _score = 0;

    //High Score Saver
    private int _highScore;
    [SerializeField] public Text _highScoreText;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }
    private void Start()
    {
        _auManagerSc = GameObject.Find("Audio Manager").GetComponent<audioManager>();

        _score = 0;
        _scoreText.text = _score.ToString();

        _highScore = PlayerPrefs.GetInt("HighScore", 0);
        _highScoreText.text = "High Score: " + _highScore.ToString();
    }

    private void Update()
    {
        if (baseMoveSpeed < maxMoveSpeed)
        {
            baseMoveSpeed += acceleration * Time.deltaTime;
        }
    }
    public void AddScore()
    {
        _score++;

        _scoreText.text = _score.ToString();

        _auManagerSc.Score();
        //Check High Score
        if (_score > _highScore)
        {
            _highScore = _score;
            PlayerPrefs.SetInt("HighScore", _highScore);
            _highScoreText.text = "High Score: " + _highScoreText.ToString();
        }
    }
}
