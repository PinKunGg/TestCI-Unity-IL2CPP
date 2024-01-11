using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Vector3 oriPos;
    private RaycastHit hit;

    void Start()
    {
        oriPos = this.transform.position;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            this.transform.position = oriPos;
        }

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100))
            {
                var pos = new Vector3(hit.point.x, hit.point.y + 0.2f, hit.point.z);
                this.transform.position = pos;
            }
        }
    }
}
