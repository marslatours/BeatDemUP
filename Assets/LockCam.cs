using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockCam : MonoBehaviour
{
    [SerializeField] private Transform previousStage;
    [SerializeField] private Transform nextStage;
    [SerializeField] private CameraController cam;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            if (collider.transform.position.x < transform.position.x)
                cam.MovetoNewRoom(nextStage);
            else
                cam.MovetoNewRoom(previousStage);
        }
    }
}
