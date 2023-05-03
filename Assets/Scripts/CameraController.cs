using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float xPos = 8f;
    [SerializeField] private float yPos = 3f;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.position.x + xPos, player.position.y + yPos, transform.position.z);
    }
}
