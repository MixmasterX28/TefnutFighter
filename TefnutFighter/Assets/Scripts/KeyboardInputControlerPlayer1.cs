using UnityEngine;

[CreateAssetMenu(menuName = "Input/KeyboardInputControlerPlayer1")]
public class KeyboardInputControlerPlayer1 : InputControler
{
    public override float RetrieveMoveInput()
    {
        return Input.GetAxis("HorizontalP1"); // Asume que has configurado el eje "HorizontalP1"
    }

    public override bool RetrieveJumpInput()
    {
        return Input.GetButtonDown("JumpP1"); // Asume que has configurado el botón "JumpP1"
    }
}
