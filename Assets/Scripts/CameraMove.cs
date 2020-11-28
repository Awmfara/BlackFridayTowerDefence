using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField]
    private float dragSpeed = 2;
    [SerializeField]
    float zoomSpeed = 2;
    Vector3 startingPosition = default;
    private Vector3 dragOrigin;

    private float currentZoom = default;

    private void Start()
    {
        startingPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        currentZoom = transform.position.z;
        currentZoom -= currentZoom + Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;
        
        if (Input.GetKey(KeyCode.X))
        {
            transform.position = startingPosition;
        }

        if (Input.GetMouseButtonDown(1))
        {
            dragOrigin = Input.mousePosition;
            return;
        }
        if (!Input.GetMouseButton(1))
        {
            // transform.Translate(new Vector3(transform.position.x, currentZoom, transform.position.y), Space.World);
            return;
        }
        Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - dragOrigin);
        Vector3 move = new Vector3(-pos.x * dragSpeed, currentZoom, -pos.y * dragSpeed);
        transform.Translate(move, Space.World);

       


    }
}
