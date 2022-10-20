using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTraj : MonoBehaviour
{ 
    public float force;

    private Vector3 mousePos;
    private Camera mainCam;
    private Rigidbody2D rb;

    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        rb = GetComponent<Rigidbody2D>();
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = mousePos - transform.position;
        Vector3 rotation = transform.position - mousePos;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * force;
        float rot = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot + 90);

        screenBounds = mainCam.ScreenToWorldPoint(
            new Vector3(Screen.width, Screen.height, mainCam.transform.position.z));
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < screenBounds.x * -1 ||
            transform.position.y < screenBounds.y * -1 ||
            transform.position.x > screenBounds.x ||
            transform.position.y > screenBounds.y)
        {
            Destroy(gameObject);
        }
    }
}
