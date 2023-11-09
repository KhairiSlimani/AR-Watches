using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mapbox.Unity.Map;
using Mapbox.Utils;

public class LocationManager : MonoBehaviour
{
    public AbstractMap map; // Reference to the Mapbox map component.
    public Transform playerTarget; // Reference to the player's target GameObject.

    // Start is called before the first frame update
    void Start()
    {
        // Start location service updates
        Input.location.Start();
        
    }

    // Update is called once per frame
    void Update()
    {
        // Check if location services are running
        if (Input.location.status == LocationServiceStatus.Running)
        {
            float latitude = Input.location.lastData.latitude;
            float longitude = Input.location.lastData.longitude;

            // Convert latitude and longitude to Mapbox Vector2d
            Vector2d newLocation = new Vector2d(latitude, longitude);

            // Update the map's position based on latitude and longitude
            map.UpdateMap(newLocation);

            // Update the player's target position based on the new location
            playerTarget.position = map.GeoToWorldPosition(newLocation, true);
        }
        
    }
}