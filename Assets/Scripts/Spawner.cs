using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.Audio.ProcessorInstance;
using System.Collections;
using System.Collections.Generic;


public class Spawner : MonoBehaviour
{

    [SerializeField] private float _maxTime = 2f;
    [SerializeField] private float _heightRange = 0.45f;
    [SerializeField] private GameObject _pipe;

    private float _timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnPipe();
        _timer = 0f;
    }



    // Update is called once per frame
    void Update()
    {
        if (_timer >= _maxTime) 
        {
            SpawnPipe();
            _timer = 0;
        
        }

        _timer += Time.deltaTime;
    }

    private void SpawnPipe()
    {
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-_heightRange, _heightRange));
        GameObject pipe = Instantiate(_pipe, spawnPos, Quaternion.identity);

        Destroy(pipe, 10f);

    }
}
