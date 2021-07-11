using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    [SerializeField] private float _speed;

    void FixedUpdate()
    {
        transform.position += Vector3.left * _speed * Time.deltaTime;
    }
}
