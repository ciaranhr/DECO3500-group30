using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBall : MonoBehaviour
{
     private Rigidbody rb;
    private Vector2 startTouchPosition;
    private Vector2 endTouchPosition;
    public float throwForce = 500f;  // Adjust the throw force

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                startTouchPosition = touch.position;
            }

            if (touch.phase == TouchPhase.Ended)
            {
                endTouchPosition = touch.position;
                Throw();
            }
        }
    }

    void Throw()
    {
        Vector2 direction = endTouchPosition - startTouchPosition;
        Vector3 throwDirection = new Vector3(direction.x, direction.y, 1f); // Forward movement in Z-axis
        rb.AddForce(throwDirection * throwForce);
    }
}
