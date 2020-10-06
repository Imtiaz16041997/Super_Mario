using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform Player;
    public float DistanceFromPlayer = 6;
    public float StaticCameraY = 4;
    public float DistanceInFrontOfPlayer = 5;

    // Use this for initialization
    void Start()
    {
        Vector3 temp = transform.position;
        temp.y = StaticCameraY;
        Camera.main.transform.position = temp;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 temp = transform.position;
        temp.z = Player.position.z - DistanceFromPlayer;
        temp.x = Player.position.x + DistanceInFrontOfPlayer;
        transform.position = temp;
    }
}