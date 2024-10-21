using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
public class DragBall : MonoBehaviour
{
    private Camera mainCamera;
    private Vector3 offset;
    private Plane plane;

    void Start()
    {
        mainCamera = Camera.main;
        plane = new Plane(Vector3.up, transform.position);
    }

    void Update()
    {
        // Handle touch input
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Ray ray = mainCamera.ScreenPointToRay(touch.position);
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    // Check if the touch hits the ball
                    float distance;
                    if (plane.Raycast(ray, out distance))
                    {
                        Vector3 hitPoint = ray.GetPoint(distance);
                        if (Vector3.Distance(hitPoint, transform.position) < 1f) // Adjust the distance threshold as needed
                        {
                            offset = transform.position - hitPoint;
                        }
                    }
                    break;

                case TouchPhase.Moved:
                    // Move the ball
                    if (offset != Vector3.zero)
                    {
                        if (plane.Raycast(ray, out distance))
                        {
                            Vector3 hitPoint = ray.GetPoint(distance);
                            transform.position = hitPoint + offset;
                        }
                    }
                    break;

                case TouchPhase.Ended:
                case TouchPhase.Canceled:
                    // Reset the offset
                    offset = Vector3.zero;
                    break;
            }
        }
    }
}