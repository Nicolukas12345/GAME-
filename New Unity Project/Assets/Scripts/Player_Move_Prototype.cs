using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move_Prototype : MonoBehaviour
{
    [SerializedField] private float speed;
    private Rigidbody2D body;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        body.velocity = new Vector3(Input.GetAxis("Horizontal") * speed, body.velocity.y);
    }
}
