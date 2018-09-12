using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "MovePatternNotGrounded")]
public class MovePatternNotGrounded : MovePatern {

    public override void Invoke(CharacterController controller, Transform transform)
    {
        Move(transform);
        Move(controller);
    }
    
   
}
