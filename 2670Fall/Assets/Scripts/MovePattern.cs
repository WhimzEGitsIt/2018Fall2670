﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class MovePatern : ScriptableObject {

    public FloatData gravity;

    public FloatData MoveX, MoveY, MoveZ;
    public FloatData RotX, RotY, RotZ;

    private Vector3 rotDirection;
    protected Vector3 moveDirection;

    public virtual void Invoke(CharacterController controller, Transform transform)
    {
        if (controller.isGrounded)
        {
            Move(transform);
        }

        Move(controller);
    }

    protected void Move(CharacterController controller)
    {
        moveDirection.y = gravity.Value;
        controller.Move(moveDirection * Time.deltaTime);
    }

    protected void Move(Transform transform)
    {
        moveDirection.Set(MoveX.Value, MoveY.Value, MoveZ.Value);

        rotDirection.Set(RotX.Value, RotY.Value, RotZ.Value);
        transform.Rotate(rotDirection);

        moveDirection = transform.TransformDirection(moveDirection);
    }
}

