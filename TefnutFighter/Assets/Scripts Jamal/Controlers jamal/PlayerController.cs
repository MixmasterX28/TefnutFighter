using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerController", menuName = "InputControler/PlayerController")]
public class PlayerController : InputControler
{
    public override bool RetrieveJumpInput()
    {
        return Input.GetButtonDown("Jump");
    }

    public override float RetrieveMoveInput()
    {
        return Input.GetAxisRaw("Horizontal");
    }
}
