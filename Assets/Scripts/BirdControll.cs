using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdControll : MonoBehaviour
{
    private Rigidbody2D _rigidbody;

    [SerializeField] private float _jumpVelocity = 1;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    public void Jump()
    {
        _rigidbody.velocity = Vector2.up * _jumpVelocity;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))    //��� ��� ��� �� ������ �� ��������
        {
            Jump();
        }    
    }
}
