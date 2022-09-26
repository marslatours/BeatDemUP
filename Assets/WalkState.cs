using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkState : StateMachineBehaviour
{
    Transform target;
    public float speed = 3;
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        target = GameObject.FindWithTag("Player").transform;
    }

    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Vector2 newPos = new Vector2(target.position.x, target.position.y);
        animator.transform.position = Vector2.MoveTowards(animator.transform.position, newPos, speed * Time.deltaTime);

       float distance = Vector2.Distance(target.position, animator.transform.position);
        if (distance < 1)
            animator.SetBool("isAttacking", true);
    }

    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateExit(animator, stateInfo, layerIndex);
    }
}

