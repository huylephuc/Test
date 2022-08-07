using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotCamera : MonoBehaviour
{
    public Vector2 turn;
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            turn.x += Input.GetAxis("Mouse X");
            turn.x = Mathf.Clamp(turn.x, -60, 60);
            transform.rotation = Quaternion.Euler(0, turn.x, 0);
        }
    }
}
