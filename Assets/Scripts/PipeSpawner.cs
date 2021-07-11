using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    private float _timer = 0;
    private float _timeToDestroy = 5;

    [SerializeField] private float _SpawnTime = 3;
    [SerializeField] private GameObject _pipe;
    [SerializeField] private float _height;

    private void PipeSpawnerAndDestroyer()
    {
        GameObject _newPipe = Instantiate(_pipe);
        _newPipe.transform.position = transform.position + new Vector3(0f, Random.Range(-_height, _height), 0f);
        Destroy(_newPipe, _timeToDestroy);
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
