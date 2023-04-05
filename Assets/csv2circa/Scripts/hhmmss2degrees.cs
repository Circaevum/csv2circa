using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hhmmss2degrees : MonoBehaviour
{
    public float time2degrees(string timestamp)
    {
        string[] time = timestamp.Split(':');
        int hour = Convert.ToInt32(time[0]);
        int minute = Convert.ToInt32(time[1]);

        //Add number of minutes together, and divide by 5 to get the count of 5 minute increments
        float degrees = (float)(minute + hour * 60) * 360.0f / 1440.0f;
        return degrees;
    }
}
