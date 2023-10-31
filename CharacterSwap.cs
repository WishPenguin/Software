using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//New
using UnityEngine.InputSystem;

public class gunSwitcher : MonoBehaviour
{      /*
    public List<GameObject> PlayableCharacter; // This will hold all your gun objects, you will need to drag them all into here in Unity
    private CharacterInput controls;
    private int current = 0; // Holds what gun is selected, defaults to 0, or the first gun in the list
    public object obj;

    // swap activation 
    void Awake()
    {
        controls = new CharacterInput();

        // Turns off all our PlayableCharacter to start with
        for (int i = 0; i < PlayableCharacter.Count; i++)
        {
            PlayableCharacter[i].SetActive(false);
        }
        // Turns on our first gun
        PlayableCharacter[current].SetActive(true);
    }
    void OnEnable()
    {
        controls.Enable();
    }
    void OnDisable()
    {
        controls.Disable();
    }

    void Update()
    {
        // Read which way the mouse wheel is scrolling
        float direction = 0f;//controls.Player.WeaponChange.ReadValue<float>();

        // If it is not 0, it means we have scrolled
        if (direction != 0)
        {
            changeWeapon(direction);
        }
    }

    void changeWeapon(float direction)
    {
        // Turn off the current gun
        PlayableCharacter[current].SetActive(false);

        // If we scrolled up
        if (direction > 0)
        {
            // If our current gun is not 0, we can go down the list
            if (current > 0)
            {
                current -= 1;
            }
            else // Otherwise we need to wrap around to the other end of the list
            {
                current = PlayableCharacter.Count - 1;
            }
        }
        // This is the same above, but the other direction
        else if (direction < 0)
        {
            if (current < PlayableCharacter.Count - 1)
            {
                current += 1;
            }
            else
            {
                current = 0;
            }
        }
        // Once we update our current value, set it to be true!
        PlayableCharacter[current].SetActive(true);
    }*/
}