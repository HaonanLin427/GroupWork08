using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float walkSpeed = 4;
    [SerializeField] private bool isPlayer1;

    public bool IsPlayer1 => isPlayer1;

    private PlayerControls playerControls;


    void Start()
    {
        playerControls = new();
        playerControls.Walk.Enable();
        if(isPlayer1)
        {
            playerControls.Walk.Direction1.Enable();
        }
        else
        {
            playerControls.Walk.Direction2.Enable();
        }
    }

    private void OnDestroy()
    {
        if(isPlayer1)
        {
            playerControls.Walk.Direction1.Disable();
        }
        else
        {
            playerControls.Walk.Direction2.Disable();
        }
        playerControls.Walk.Disable();
    }

    void Update()
    {
        Vector2 direction2d;
        if(isPlayer1)
        {
            direction2d = playerControls.Walk.Direction1.ReadValue<Vector2>();
        }
        else
        {
            direction2d = playerControls.Walk.Direction2.ReadValue<Vector2>();
        }
        Vector3 direction3d = new(direction2d.x, 0, direction2d.y);
        transform.Translate(direction3d * Time.deltaTime * walkSpeed);
    }
}
