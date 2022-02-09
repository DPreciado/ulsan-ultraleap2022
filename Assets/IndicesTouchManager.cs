using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndicesTouchManager : MonoBehaviour
{
    [SerializeField]
    float PinchDistance;
    [SerializeField]
    float PalmDistance;

    [SerializeField]
    Transform lIndex;

    [SerializeField]
    Transform lThumb;
    
    [SerializeField]
    Transform rIndex;

    [SerializeField]
    Transform rThumb;
    [SerializeField]
    Transform rPalm;

    [SerializeField]
    Transform lPalm;

    bool PinchReady = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(lPalm.position,rPalm.position) <= PalmDistance)
        {
            Debug.Log("close");
            PinchReady = true;
        }

        if(PinchReady)
        {
            if (Vector3.Distance(lIndex.position,lThumb.position) <= PinchDistance)
            {
                Debug.Log("pinch");
            }
        }

        if(Vector3.Distance(lPalm.position,rPalm.position) >= PalmDistance)
        {
            PinchReady = false;

        }
    }
}