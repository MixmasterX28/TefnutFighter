using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    public Slider slider;

    public void SetHealth(float health)
    {
        slider.value = health;
    }

}
