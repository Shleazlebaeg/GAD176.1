using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform playerBody;
    public Transform sceneCamera;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(playerBody.position.x, playerBody.position.y, -50f);
    }
}
