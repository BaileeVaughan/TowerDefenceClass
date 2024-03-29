﻿//This script was written by the Bailee gang

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placeable : MonoBehaviour
{
    public bool isAvaliable = true;
    public Transform pivotPoint;

    public Vector3 GetPivotPoint()
    {
        if (pivotPoint == null)
        {
            return transform.position;
        }
        return pivotPoint.position;
    }
}
