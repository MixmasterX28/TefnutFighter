using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class CharacterSelectController : MonoBehaviour
{


    public Image[] player1CharacterIcons; // Array to hold Player 1 character icons
    public Image[] player2CharacterIcons; // Array to hold Player 2 character icons
    public GameObject[] characters; // Array to hold character prefabs
    public Transform player1SpawnPoint;
    public Transform player2SpawnPoint;

    private int player1SelectedIndex = 0;
    private int player2SelectedIndex = 0;

    void Start()
    {
        UpdateSelection(player1CharacterIcons, player1SelectedIndex, Color.white, 0);
        UpdateSelection(player2CharacterIcons, player2SelectedIndex, Color.white, 1);
    }

    void Update()
    {
        HandleInput();
    }

    void HandleInput()
    {
        // Player 1 input
        if (Input.GetKeyDown(KeyCode.D))
        {
            player1SelectedIndex = (player1SelectedIndex + 1) % player1CharacterIcons.Length;
            UpdateSelection(player1CharacterIcons, player1SelectedIndex,Color.red, 0);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            player1SelectedIndex = (player1SelectedIndex - 1 + player1CharacterIcons.Length) % player1CharacterIcons.Length;
            UpdateSelection(player1CharacterIcons, player1SelectedIndex,Color.red, 0);
        }

        // Player 2 input
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            player2SelectedIndex = (player2SelectedIndex + 1) % player2CharacterIcons.Length;
            UpdateSelection(player2CharacterIcons, player2SelectedIndex,Color.blue, 1);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            player2SelectedIndex = (player2SelectedIndex - 1 + player2CharacterIcons.Length) % player2CharacterIcons.Length;
            UpdateSelection(player2CharacterIcons, player2SelectedIndex, Color.blue, 1);
        }

        // Confirm selection with Enter
        if (Input.GetKeyDown(KeyCode.Return))
        {
            ConfirmSelection();
        }
    }
    private int[] lastActiveIndexes = new int[2] { 0, 0 };
    void UpdateSelection(Image[] characterIcons, int selectedIndex, Color targetColor, int playerIndex)
    {
        characterIcons[lastActiveIndexes[playerIndex]].color = Color.white;

        characterIcons[selectedIndex].color = targetColor;
        lastActiveIndexes[playerIndex] = selectedIndex;

    }
    /*void UpdateSelectionOriginal(Image[] characterIcons, int selectedIndex, Color targetColor)
    {
        for (int i = 0; i < characterIcons.Length; i++)
        {
            characterIcons[i].color = (i == selectedIndex) ? targetColor : Color.white;
        }
    }*/
    void ConfirmSelection()
    {
        CharacterSelection.player1SelectedCharacter = characters[player1SelectedIndex];
        CharacterSelection.player2SelectedCharacter = characters[player2SelectedIndex];
        SceneManager.LoadSceneAsync(2);
    }
}

public static class CharacterSelection
{
    public static GameObject player1SelectedCharacter;
    public static GameObject player2SelectedCharacter;
}