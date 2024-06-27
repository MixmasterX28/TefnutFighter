using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player2Controller", menuName = "InputController/Player2Controller")]
public class Player2Controller : InputController
{
    public override bool RetrieveAttackInput()
    {
        throw new System.NotImplementedException();
    }

    public override bool RetrieveJumpInput()
    {
        return Input.GetButtonDown("JumpP2");
    }

    public override float RetrieveMoveInput()
    {
        return Input.GetAxisRaw("HorizontalP2");
    }
}
