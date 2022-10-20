using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Player character focuses aim towards the direction of mouse pointer
/// </summary>
public class PlayerAim : MonoBehaviour
{

    /*// Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition; // get mouse position
        mousePos.z = 0; // zero mouse z
        Vector3 objectPos = Camera.main.WorldToScreenPoint(transform.position); // get player's position in screen space

        mousePos.x -= objectPos.x;
        mousePos.y -= objectPos.y;

        float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle + 270));

    }*/

    private void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 rotation = mousePos - transform.position;
        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rotZ + 270);
    }

}
