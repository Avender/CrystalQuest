using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;
    [SerializeField] private float speed = 2f;
    private int _waypointIndex = 0;

    // Update is called once per frame
    private void Update()
    {
        if (Vector2.Distance(waypoints[_waypointIndex].transform.position, transform.position) < .1f)
        {
            _waypointIndex++;
            if (_waypointIndex >= waypoints.Length)
            {
                _waypointIndex = 0;
            }
        }

        transform.position = Vector2.MoveTowards(transform.position, waypoints[_waypointIndex].transform.position,
            Time.deltaTime * speed);
    }
}
