using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : Animation
{
    // Start is called before the first frame update
    void Start()
    {
        controller.OnMoveEvent += Animations;
    }

    // Update is called once per frame
    public void Animations(Vector2 direction)
    {
        animator.SetBool("IsWalking", direction.magnitude > 0f);
    }
}
