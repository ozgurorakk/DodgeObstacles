using UnityEngine;
using UnityEngine.UI;

public class obstaclesSc : MonoBehaviour
{

    //Audio Manager Script.
    [SerializeField] audioManager _auManagerSc;
    private void Start()
    {
        _auManagerSc = GameObject.Find("Audio Manager").GetComponent<audioManager>();
    }
    void Update()
    {
        float _currentSpeed = GameManager.Instance.baseMoveSpeed;
        transform.Translate(Vector2.up * _currentSpeed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("destroyer"))
        {
            Destroy(gameObject);
        }
        if (collision.CompareTag("scoreCounter"))
        {
            GameManager.Instance.AddScore();
        }
        if (collision.CompareTag("circle"))
        {
            _auManagerSc.Wrong();
            managerSc._managerScript.OpenMenuFreezeTime();
        }
    }
    
}
