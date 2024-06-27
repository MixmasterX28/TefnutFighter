using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player1Controller", menuName = "InputController/Player1Controller")]
public class Player1Controller : InputController
{
    public override bool RetrieveJumpInput()
    {
        return Input.GetButtonDown("JumpP1");
    }

    public override float RetrieveMoveInput()
    {
        return Input.GetAxisRaw("HorizontalP1");
    }
    public override bool RetrieveAttackInput()
    {
        return Input.GetButtonDown("Fire1");
    }
}
