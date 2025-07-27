using UnityEngine;

public class spawnerSc : MonoBehaviour
{
    //Between X: -2.005 & X: 2.005


    [SerializeField] private GameObject _obstaclePrefab;
    [SerializeField] private float _spawnInvertal = 0.8f;
    [SerializeField] private float _minX = -2.005f;
    [SerializeField] private float _maxX = 2.005f;

    private float _timer;

    private void Update()
    {
        _timer += Time.deltaTime;
        if (_timer > _spawnInvertal)
        {
            SpawnObstacle();
            _timer = 0;
        }
    }
    private void SpawnObstacle()
    {
        float randomX = Random.Range(_minX, _maxX);
        Vector3 spawnPos = new Vector3(randomX, transform.position.y, 0);
        Instantiate(_obstaclePrefab, spawnPos, Quaternion.identity);
    }
}
