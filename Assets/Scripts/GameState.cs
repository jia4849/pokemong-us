using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    private static GameState instance;

    private PlayerControls inputActions;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        inputActions = new PlayerControls();

    }

    public static PlayerControls InputActions
    {
        get => instance.inputActions;
    }
}

