using System;
using System.Collections;
using System.Collections.Generic;
using Photon.Realtime;
using UnityEngine;

public class PassedChekcpoints : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Vehicle")
        {
            TimerMode.passedCheckpoint = TimerMode.passedCheckpoint + 1;
            SoloScript.passedCheckpoint = SoloScript.passedCheckpoint + 1;
        }
    }
}