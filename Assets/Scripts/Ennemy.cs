using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemy : MonoBehaviour
{
    Transform target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(target.position.x > transform.position.x)
        {
            transform.localScale = new Vector2(1f, 1f);

        }
        else
        {
            transform.localScale = new Vector2(-1f, 1f);
        }
    }
}
