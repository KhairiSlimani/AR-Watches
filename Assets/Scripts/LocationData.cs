using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mapbox.Unity.Utilities;


[System.Serializable]
public class LocationData
{
    public string locationName;
    [Geocode]
    public string locationString;
}

