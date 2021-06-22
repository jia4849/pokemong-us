using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static PlayerControls;

public class Player : MonoBehaviour, IPlayerActions
{

    [SerializeField]
    private float movementSpeed = 1f;
    private Vector2 movementVector = new Vector2(0,0);
    private Rigidbody2D rbody;

    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        GameState.InputActions.Player.Enable();
        GameState.InputActions.Player.SetCallbacks(this);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 currentPos = rbody.position;
        Vector2 movement = movementVector * movementSpeed;
        Vector2 newPos = currentPos + movement * Time.fixedDeltaTime;
        rbody.MovePosition(newPos);
    }


    public void OnMove(InputAction.CallbackContext context)
    {
        movementVector = context.ReadValue<Vector2>();
        Debug.Log("Move!");
    }

    public void OnPickUp(InputAction.CallbackContext context)
    {

    }

    public void OnUse(InputAction.CallbackContext context)
    {

    } 
}
