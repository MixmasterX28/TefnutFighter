using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
public class GameSceneController : MonoBehaviour
{
    public Transform player1SpawnPoint;
    public Transform player2SpawnPoint;

    void Start()
    {
        if (CharacterSelection.player1SelectedCharacter != null)
        {
            Debug.Log("p1bugged");
            Instantiate(CharacterSelection.player1SelectedCharacter, player1SpawnPoint.position, player1SpawnPoint.rotation);
        }
        else
        {
            Debug.LogError("No character selected for Player 1!");
        }

        if (CharacterSelection.player2SelectedCharacter != null)
        {
            Debug.Log("p2bugged");
            Instantiate(CharacterSelection.player2SelectedCharacter, player2SpawnPoint.position, player2SpawnPoint.rotation);
        }
        else
        {
            Debug.LogError("No character selected for Player 2!");
        }
    }
}