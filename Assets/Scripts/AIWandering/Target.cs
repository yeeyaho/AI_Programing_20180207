using UnityEngine;
using System.Collections;

public class Target : MonoBehaviour
{
    public Transform targetMarker;

    void Start ()
    {
    }

    void Update ()
    {

        //Get the point of the hit position when the mouse is being clicked
        //int button = 0;
        //if(Input.GetMouseButtonDown(button))
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(ray.origin, ray.direction, out hitInfo)) 
            {      
                targetMarker.position = hitInfo.point;
            }
        }
    }

}