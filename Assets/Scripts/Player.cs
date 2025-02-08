using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public bool BasketFlag;
    public float MoveVector;

    public float Speed;

    private Rigidbody2D _rigidbody2D;

    private bool _blockLeft, _blockRight;

    // Start is called before the first frame update
    void Start()
    {

        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (MoveVector < 0)
        {
            _rigidbody2D.MovePosition(Vector2.Max(
                _rigidbody2D.position + new Vector2(MoveVector * Speed * Time.fixedDeltaTime, 0),
                new Vector2(-4.5f, _rigidbody2D.position.y)));
        }

        if (MoveVector > 0)
        {
            _rigidbody2D.MovePosition(Vector2.Min(
                _rigidbody2D.position + new Vector2(MoveVector * Speed * Time.fixedDeltaTime, 0),
                new Vector2(4.5f, _rigidbody2D.position.y)));
        }

        if (!BasketFlag)
            transform.rotation = Quaternion.identity;

        if (BasketFlag)
            transform.rotation = new Quaternion(0, 1f, 0, 0);
    }
}