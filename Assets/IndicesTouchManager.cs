using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndicesTouchManager : MonoBehaviour
{
    [SerializeField]
    float PinchDistance;

    [SerializeField]
    Transform hand1;

    [SerializeField]
    Transform hand2;

    bool PinchReady = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(hand1.position,hand2.position) <= PinchDistance && PinchReady)
        {
            Debug.Log("PINCH");
            PinchReady = false;
        }

        if(Vector3.Distance(hand1.position,hand2.position) >= PinchDistance)
        {
            PinchReady = true;

        }
    }
}