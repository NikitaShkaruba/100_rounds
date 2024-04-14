using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRunner : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidbody;

    // Update is called once per frame
    void FixedUpdate()
    {
        const float speed = 4f;

        rigidbody.velocity = new Vector2(1 * speed, 0);
    }
}
