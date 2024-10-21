using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    
    // GameObject activeChild;
    // GameObject hitTargetParent;

    // // This will be called when the "Composition" button is clicked
    // public void OnCompositionClick(GameObject targetParent)
    // {
    //     GameObject activeChild;
    //     GameObject hitTargetParent;
        
    //     hitTargetParent = targetParent;
    //     activeChild = GetActiveChild(hitTargetParent);

    //     if (activeChild.name != "default")
    //     {
    //         activeChild.SetActive(false);
    //         GetChild(hitTargetParent, "default").SetActive(true);
    //     }

    //     activeChild = GetActiveChild(hitTargetParent);
    // }

    // // This will be called when the "Send" button is clicked
    // public void OnSendClick(GameObject targetParent)
    // {
    //     hitTargetParent = targetParent;
    //     activeChild = GetActiveChild(hitTargetParent);

    //     if (activeChild.name != "SendBall")
    //     {
    //         activeChild.SetActive(false);
    //         GetChild(hitTargetParent, "SendBall").SetActive(true);
    //     }

    //     activeChild = GetActiveChild(hitTargetParent);
    // }

    // // This will be called when the "Colours" button is clicked
    // public void OnColoursClick(GameObject targetParent)
    // {
    //     hitTargetParent = targetParent;
    //     activeChild = GetActiveChild(hitTargetParent);

    //     if (activeChild.name != "ColourInfo")
    //     {
    //         activeChild.SetActive(false);
    //         GetChild(hitTargetParent, "ColourInfo").SetActive(true);
    //     }

    //     activeChild = GetActiveChild(hitTargetParent);
    // }

    // // This will be called when the "RuleOfThirdsInfo" button is clicked
    // public void OnRuleOfThirdsInfoClick(GameObject target)
    // {
    //     Destroy(target);
    // }

    // private GameObject GetActiveChild(GameObject parent)
    // {
    //     GameObject emptyObject = new GameObject("EmptyObject");
    //     GameObject currentObject;
    //     string[] ignore = { "Colours", "Composition", "Send" };

    //     for (int i = 0; i < parent.transform.childCount; i++)
    //     {
    //         currentObject = parent.transform.GetChild(i).gameObject;
    //         if (!ignore.Contains(currentObject.name))
    //         {
    //             if(currentObject.activeInHierarchy)
    //             {
    //                 Debug.Log("current active object: " + currentObject);
    //                 return currentObject;
                    
    //             }

    //         }
    //     }
        
    //     return emptyObject;
    // }

    
    // private GameObject GetChild (GameObject parent, string name)
    // {
    //     GameObject emptyObject = new GameObject("EmptyObject");
    //     GameObject currentObject;
    //     // Return the empty GameObject

    //     for (int i = 0; i < parent.transform.childCount; i++) {
    //         currentObject = parent.transform.GetChild(i).gameObject;
    //         if (currentObject.name == name)
    //         {
    //             return currentObject;

    //         }
    //     }
    //     return emptyObject;
    // }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
