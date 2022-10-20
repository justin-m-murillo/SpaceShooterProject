using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Scrolls the texture over the main background
/// </summary>
public class ScrollBG : MonoBehaviour
{
    Material mat;
    Vector2 offset;

    public float xVel;
    public float yVel;

    private void Awake()
    {
        mat = GetComponent<Renderer>().material;
    }

    private void Start()
    {
        offset = new Vector2(xVel, yVel);
    }

    // Update is called once per frame
    void Update()
    {
        mat.mainTextureOffset += offset * Time.deltaTime;
    }
}
