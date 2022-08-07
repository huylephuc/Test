using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject[] cube;
    public float speed;
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (cube[1].transform == hit.transform)
                {
                    cube[0].transform.position = Vector3.MoveTowards(cube[0].transform.position, cube[1].transform.position, speed * Time.deltaTime);
                }
                else if (cube[2].transform == hit.transform)
                {
                    cube[0].transform.position = Vector3.MoveTowards(cube[0].transform.position, cube[2].transform.position, speed * Time.deltaTime);
                }
            }
        }
    }
}
