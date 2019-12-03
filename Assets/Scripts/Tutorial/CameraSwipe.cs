using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwipe : MonoBehaviour
{
    private Vector3 StartPos;
    public float speed;
    //[SerializeField] private float LeftGX, LeftGY, RightGX, RightGY;
    [SerializeField] Camera cam;
    Vector3 posDelta;
    Vector3 pos;
    private void Start()
    {
        cam = GetComponent<Camera>();
        posDelta = transform.position;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            StartPos = cam.ScreenToWorldPoint(Input.mousePosition);
        else if (Input.GetMouseButton(0))
        {
            pos = cam.ScreenToWorldPoint(Input.mousePosition) - StartPos;
            posDelta = transform.position - pos;
            //float posDeltaX = Mathf.Clamp(posDelta.x, LeftGX, RightGX);
            //float posDeltaY = Mathf.Clamp(posDelta.y, LeftGY, RightGY);
            //transform.position = new Vector3(posDeltaX, posDeltaY, transform.position.z);
        }
        transform.position = Vector3.MoveTowards(transform.position, posDelta, speed * Time.deltaTime);
    }
}
