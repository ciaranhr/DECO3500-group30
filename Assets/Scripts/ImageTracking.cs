using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ImageTracker : MonoBehaviour
{
    private ARTrackedImageManager trackedImages;
    public GameObject[] arPrefabs;
    public GameObject infoPopup;
    private GameObject instance;


    List<GameObject> ARObjects = new List<GameObject>();


    void Awake()
    {
        trackedImages = GetComponent<ARTrackedImageManager>();
    }

    void OnEnable()
    {
        trackedImages.trackedImagesChanged += OnTrackedImagesChanged;
    }

    void OnDisable()
    {
        trackedImages.trackedImagesChanged -= OnTrackedImagesChanged;
    }

    private GameObject GetChild (GameObject parent, string name)
    {
        GameObject emptyObject = new GameObject("EmptyObject");
        GameObject currentObject;
        // Return the empty GameObject

        for (int i = 0; i < parent.transform.childCount; i++) {
            currentObject = parent.transform.GetChild(i).gameObject;
            if (currentObject.name == name)
            {
                return currentObject;

            }
        }
        return emptyObject;
    }

    private GameObject GetActiveChild(GameObject parent)
    {
        GameObject emptyObject = new GameObject("EmptyObject");
        GameObject currentObject;
        string[] ignore = { "Colours", "Composition", "Send" };

        for (int i = 0; i < parent.transform.childCount; i++)
        {
            currentObject = parent.transform.GetChild(i).gameObject;
            if (!ignore.Contains(currentObject.name))
            {
                if(currentObject.activeInHierarchy)
                {
                    Debug.Log("current active object: " + currentObject);
                    return currentObject;
                    
                }

            }
        }
        return emptyObject;
    }


    // Event Handler
    private void OnTrackedImagesChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        //Create object based on image tracked
        foreach (var trackedImage in eventArgs.added)
        {
            foreach (var arPrefab in arPrefabs)
            {
                if (trackedImage.referenceImage.name == arPrefab.name)
                {
                    
                    var newPrefab = Instantiate(arPrefab, trackedImage.transform);
                    ARObjects.Add(newPrefab);
                    GetChild(newPrefab, "ColourInfo").SetActive(false);
                    GetChild(newPrefab, "CompositionExtra1").SetActive(false);
                    GetChild(newPrefab, "SendBall").SetActive(false);
                    /*
                    newPrefab = Instantiate(GetChild(arPrefab, "Send"), trackedImage.transform);
                    ARObjects.Add(newPrefab);
                    newPrefab = Instantiate(GetChild(arPrefab, "Composition"), trackedImage.transform);
                    ARObjects.Add(newPrefab);
                    newPrefab = Instantiate(GetChild(arPrefab, "Default"), trackedImage.transform);
                    ARObjects.Add(newPrefab);
                   */
                }
            }
        }

        //Update tracking position
        foreach (var trackedImage in eventArgs.updated)
        {
            foreach (var gameObject in ARObjects)
            {
                if (gameObject.name == trackedImage.name)
                {
                    gameObject.SetActive(trackedImage.trackingState == TrackingState.Tracking);
                }
            }
        } 
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                Debug.Log(hit.transform.name + " : " + hit.transform.tag);
                GameObject hitTargetParent = hit.transform.parent.gameObject;
                GameObject activeChild = GetActiveChild(hitTargetParent);
                if (hit.transform.tag == "Composition")
                {
                    if (activeChild.name != "default")
                    {
                        activeChild.SetActive(false);
                        GetChild(hitTargetParent, "default").SetActive(true);
                        
                    }
                    activeChild = GetActiveChild(hitTargetParent);
                }

                else if (hit.transform.tag == "Send")
                {
                    if (activeChild.name != "SendBall")
                    {
                        activeChild.SetActive(false);
                        GetChild(hitTargetParent, "SendBall").SetActive(true);

                    }
                    activeChild = GetActiveChild(hitTargetParent);
                }

                else if (hit.transform.tag == "Colours")
                {
                    if (activeChild.name != "ColourInfo")
                    {
                        activeChild.SetActive(false);
                        GetChild(hitTargetParent, "ColourInfo").SetActive(true);
                        
                    }
                    activeChild = GetActiveChild(hitTargetParent);
                }

            if (hit.transform.tag == "RuleOfThirdsInfo")
                {
                    Destroy(hit.transform.gameObject);
                }
            }
        }
    }
}
