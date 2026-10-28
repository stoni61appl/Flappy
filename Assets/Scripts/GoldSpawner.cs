
using UnityEngine;
using static UnityEngine.Audio.ProcessorInstance;

public class GoldSpawner : MonoBehaviour
{
    [SerializeField] private float _maxTime = 3f;
    [SerializeField] private float _heightRange = 2f;
    [SerializeField] private GameObject _gold;

    private float _timer;

    void Update()
    {
        _timer += Time.deltaTime;

        if (_timer >= _maxTime)
        {
            SpawnGold();
            _timer = 0f;
        }
    }

    private void SpawnGold()
    {
        float randomHeight = Random.Range(-_heightRange,_heightRange);

        Vector3 spawnPosition = transform.position + Vector3.up * randomHeight;

        Instantiate(_gold, spawnPosition, Quaternion.identity);

        
    }
}
