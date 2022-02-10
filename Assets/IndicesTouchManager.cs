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

    bool creandoCubo = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float handsDistance = (Vector3.Distance(lIndex.position,lThumb.position));

        if(Vector3.Distance(lPalm.position,rPalm.position) <= PalmDistance)
        {
            PinchReady = true;
        }

        if(PinchReady)
        {
            if (Vector3.Distance(lIndex.position,lThumb.position) <= PinchDistance && creandoCubo == false)
            {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.transform.position = new Vector3(0.5f, 0.5f, 0);
                creandoCubo = true;
            }
        }

        if(Vector3.Distance(lPalm.position,rPalm.position) >= PalmDistance)
        {
            PinchReady = false;

        }
        if(Vector3.Distance(lIndex.position,lThumb.position) >= PinchDistance)
        {
            creandoCubo = false;

        }
    }
}