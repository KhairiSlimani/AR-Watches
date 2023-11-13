namespace Mapbox.Examples
{
    using UnityEngine;
    using Mapbox.Utils;
    using Mapbox.Unity.Map;
    using Mapbox.Unity.MeshGeneration.Factories;
    using Mapbox.Unity.Utilities;
    using System.Collections.Generic;

    public class SpawnOnMap : MonoBehaviour
    {
        [System.Serializable]
        public class LocationData
        {
            public string locationName;
            [Geocode]
            public string locationString;
        }

        [SerializeField]
        AbstractMap _map;

        [SerializeField]
        LocationData[] _locationData;

        [SerializeField]
        float _spawnScale = 100f;

        [SerializeField]
        GameObject _markerPrefab;

        List<GameObject> _spawnedObjects;

        void Start()
    {
        _spawnedObjects = new List<GameObject>();

        for (int i = 0; i < _locationData.Length; i++)
        {
            var locationData = _locationData[i];
            var location = Conversions.StringToLatLon(locationData.locationString);
            var instance = Instantiate(_markerPrefab);
            instance.GetComponent<EventPointer>().eventPos = location;

            // Set the locationName directly
            instance.GetComponent<EventPointer>().locationName = locationData.locationName;

            instance.transform.localPosition = _map.GeoToWorldPosition(location, true);
            instance.transform.localScale = new Vector3(_spawnScale, _spawnScale, _spawnScale);

            _spawnedObjects.Add(instance);
        }
    }

        private void Update()
        {
            int count = _spawnedObjects.Count;
            for (int i = 0; i < count; i++)
            {
                var spawnedObject = _spawnedObjects[i];
                var location = Conversions.StringToLatLon(_locationData[i].locationString);
                spawnedObject.transform.localPosition = _map.GeoToWorldPosition(location, true);
                spawnedObject.transform.localScale = new Vector3(_spawnScale, _spawnScale, _spawnScale);
            }
        }
    }
}
