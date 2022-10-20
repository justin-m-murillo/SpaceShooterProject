using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Scrolls planet down the y axis
/// </summary>
public class ScrollPlanet : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.y -= speed * Time.deltaTime;
        transform.position = pos;
    }
}
