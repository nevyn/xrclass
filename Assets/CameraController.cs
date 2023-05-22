using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject followPlayer;
    private Vector3 offset;

    void Start()
    {
        offset =  transform.position - followPlayer.transform.position;
    }

    void LateUpdate()
    {
        var destination = followPlayer.transform.position + offset;
        var lerped = Vector3.Lerp(transform.position, destination, Time.deltaTime * 5.0f);
        transform.position = lerped;
    }
}
