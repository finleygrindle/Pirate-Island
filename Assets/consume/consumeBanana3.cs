using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class consumeBanana3 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                BoxCollider bc = hit.collider as BoxCollider;
                if (bc != null)
                {
                    Destroy(bc.gameObject);
                }
            }
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "banana (3)"){
            Destroy(col.gameObject);
        }
    }
}