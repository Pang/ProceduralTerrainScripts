using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objects : MonoBehaviour
{
    void Start()
    {
        FindLand();
    }

    public void FindLand()
    {
        Ray ray = new Ray(transform.position, -transform.up);
        RaycastHit hitInfo;
        if (Physics.Raycast(ray, out hitInfo))
        {
            transform.position = new Vector3(hitInfo.point.x, hitInfo.point.y, hitInfo.point.z);
        }
        else
        {
            ray = new Ray(transform.position, transform.up);
            if (Physics.Raycast(ray, out hitInfo))
            {
                transform.position = new Vector3(hitInfo.point.x, hitInfo.point.y, hitInfo.point.z);
            }
        }
    }
}
