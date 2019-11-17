using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public Sprite[] HeartSprite;

    public Image HealthUI;
    private CharacterController2D player;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterController2D>();
    }

    // Update is called once per frame
    void Update()
    {
        HealthUI.sprite = HeartSprite[player.carHealth];
    }
}
