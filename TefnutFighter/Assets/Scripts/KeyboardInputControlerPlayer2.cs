using UnityEngine;

[CreateAssetMenu(menuName = "Input/KeyboardInputControlerPlayer2")]
public class KeyboardInputControlerPlayer2 : InputControler
{
    public override float RetrieveMoveInput()
    {
        return Input.GetAxis("HorizontalP2"); // Asume que has configurado el eje "HorizontalP2"
    }

    public override bool RetrieveJumpInput()
    {
        return Input.GetButtonDown("JumpP2"); // Asume que has configurado el botón "JumpP2"
    }
}
