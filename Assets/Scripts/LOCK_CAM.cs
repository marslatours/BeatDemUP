using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LOCK_CAM : MonoBehaviour
{
    [SerializeField] private Transform previousStage;
    [SerializeField] private Transform nextStage;
    [SerializeField] private CameraController cam;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            if (collision.transform.position.x < transform.position.x)
                cam.MovetoNewRoom(nextStage);
            else
                cam.MovetoNewRoom(previousStage);
        }
    }
}
