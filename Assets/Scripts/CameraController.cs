using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float xPos = 0f;
    [SerializeField] private float yPos = 3f;
    [SerializeField] private Vector3 minVal, maxVal;
    private Vector3 _currentPos;
    
    // Update is called once per frame
    void Update()
    {
        var position = player.position;
        var transform1 = transform;
        
        // Vector3 boundPosition = new Vector3(Mathf.Clamp(transform1.position.x, minVal.x, maxVal.x));
        // transform1.position = new Vector3(position.x + xPos, position.y + yPos, transform1.position.z);
        transform1.position = new Vector3(Mathf.Clamp(position.x + xPos, minVal.x, maxVal.x), 
            Mathf.Clamp(position.y + yPos, minVal.y, maxVal.y),
            transform1.position.z);

    }
}
