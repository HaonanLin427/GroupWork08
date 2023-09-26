using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float walkSpeed = 4;

    private PlayerControls playerControls;


    void Start()
    {
        playerControls = new();
        playerControls.Walk.Enable();
        playerControls.Walk.Direction1.Enable();
    }

    private void OnDestroy()
    {
        playerControls.Walk.Direction1.Disable();
        playerControls.Walk.Disable();
    }

    void Update()
    {
        Vector2 direction2d = playerControls.Walk.Direction1.ReadValue<Vector2>();
        Vector3 direction3d = new(direction2d.x, 0, direction2d.y);
        transform.Translate(direction3d * Time.deltaTime * walkSpeed);
    }
}
