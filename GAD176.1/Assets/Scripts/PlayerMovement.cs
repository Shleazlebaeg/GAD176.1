using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public PlayerStats playerStats;
    public Camera sceneCamera;
    public Rigidbody2D rb;

    private Vector2 moveDirection;
    private Vector2 mousePosition;

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
    }

    void FixedUpdate()
    {
        Move();
    }

    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY).normalized;
        mousePosition = sceneCamera.ScreenToWorldPoint(Input.mousePosition);

        rb.freezeRotation = true;
    }

   void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * playerStats.playerMoveSpeed, moveDirection.y * playerStats.playerMoveSpeed);

        Vector2 aimDirection = mousePosition - rb.position;
        float aimAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg - 90f;

        rb.rotation = aimAngle;

    }
}
