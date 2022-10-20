using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Main player movement script
/// </summary>
public class PlayerMove : MonoBehaviour
{
    public float speed = 0.01f; // movement speed

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        transform.position = CheckMovement(pos);

    }

    /// <summary>
    /// Checks for player input to move ship
    /// </summary>
    /// <param name="pos"></param>
    private Vector3 CheckMovement(Vector3 pos)
    {
        if (Input.GetKey(KeyCode.D))
        {
            pos.x += speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            pos.x -= speed;
        }

        if (Input.GetKey(KeyCode.W))
        {
            pos.y += speed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            pos.y -= speed;
        }

        return pos;
    }

}
