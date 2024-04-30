using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowPrompt : MonoBehaviour
{
    public Canvas promptCanvas;

    void OnTriggerEnter(Collider TriggerObject)
    {
        if(TriggerObject.tag == "Player")
        {
            promptCanvas.enabled = true;
        }
    }

    void OnTriggerExit(Collider TriggerObjectGone)
    {
        if(TriggerObjectGone.tag == "Player")
        {
            promptCanvas.enabled = false;
        }
    }
}
