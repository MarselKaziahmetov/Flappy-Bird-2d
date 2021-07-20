using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    private float _timer = 0;
    private float _timeToDestroy = 5;

    [SerializeField] private float _SpawnTime = 2.5f;
    [SerializeField] private GameObject _pipe;
    [SerializeField] private float _height;

    private void PipeSpawnerAndDestroyer()
    {
        GameObject _newPipe = Instantiate(_pipe);
        _newPipe.transform.position = transform.position + new Vector3(0f, Random.Range(-_height, _height), 0f);
        Destroy(_newPipe, _timeToDestroy);
    }

    private void Update()
    {
        switch (AddScore._localScore)
        {
            case 20:
                _SpawnTime = 2;
                break;
            case 50:
                _SpawnTime = 1.5f;
                break;
            case 100:
                _SpawnTime = 1;
                break;
        }
    }

    void FixedUpdate()
    {
        if (_timer > _SpawnTime)
        {
            PipeSpawnerAndDestroyer();
            _timer = 0;
        }

        _timer += Time.deltaTime;
    }
}
