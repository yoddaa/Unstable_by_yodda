using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MouseMovement : MonoBehaviour
{
   // public Vector3 scanPos;//y

    private Vector3 screenPoint;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 mousePos = Input.mousePosition;
            {
                Debug.Log(mousePos.x);
                Debug.Log(mousePos.y);
            }
        }
    }


    //void OnMouseDown()
    //{
    //    screenPoint = Camera.main.WorldToScreenPoint(scanPos);


    //    offset = scanPos - Camera.main.ScreenToWorldPoint(
    //        new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));

    //}


    //void OnMouseDrag()
    //{
    //    Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);


    //    Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
    //    transform.position = curPosition;

    //}
}
