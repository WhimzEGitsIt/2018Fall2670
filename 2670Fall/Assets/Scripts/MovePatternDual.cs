using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[CreateAssetMenu(fileName = "MovePatternDual")]
public class MovePatternDual : MovePatern
{
    private bool doubleJump;
    
    public override void Invoke(CharacterController controller, Transform transform)
    {
        if (controller.isGrounded)
        {
            Move(transform);
            doubleJump = true;
        }

        if (doubleJump)
        {
            moveDirection.y = MoveY.Value;
            doubleJump = false;
        }
        
        Move(controller);
    }
}
