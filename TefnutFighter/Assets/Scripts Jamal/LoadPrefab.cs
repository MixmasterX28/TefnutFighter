using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadPrefab : MonoBehaviour
{
    public GameObject p1;//remove me
    public Slider p1CanvasBar;
    public GameObject p2;//remove me
    public Slider p2CanvasBar;
    // Start is called before the first frame update
    void Start()
    {
      //GameObject p1=  Instantiate(CharacterSelection.player1SelectedCharacter, transform);
        SetPlayerHealthSystem(p1, p1CanvasBar);
        //GameObject p2=  Instantiate(CharacterSelection.player2SelectedCharacter, transform);
        SetPlayerHealthSystem(p2, p2CanvasBar);
    }

    void SetPlayerHealthSystem(GameObject player,Slider healthBar)
    {
        Healthbar bar2 = player.AddComponent<Healthbar>();
        bar2.slider = healthBar;


        PlayerHealth p2H = player.AddComponent<PlayerHealth>();
        p2H.healthbar = bar2;
        p2H.InitHealthBar();

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
