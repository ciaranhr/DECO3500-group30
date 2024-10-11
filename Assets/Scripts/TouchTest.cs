using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTest : MonoBehaviour
{
    public GameObject infoPopup;
    private GameObject instance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("pressed primary button");
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                Debug.Log("hit");
                Debug.Log(hit.transform.name + " : " + hit.transform.tag);

                if (hit.transform.tag == "MonaLisa")
                {
                    if (instance == null) 
                    {
                        Vector3 pos = hit.point;
                        pos.z += 0.25f;
                        pos.y += 0.25f;
                        instance = Instantiate(infoPopup, pos, transform.rotation);
                 
                    }
                    else if (instance != null)
                    {
                        Destroy(instance);
                    }
                
                }
                if (hit.transform.tag == "RuleOfThirdsInfo")
                {
                    Destroy(hit.transform.gameObject);
                }
            }
        }
    }
}
