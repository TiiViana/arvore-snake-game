using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMovement : MonoBehaviour
{
    public enum Player { PlayerA, PlayerB }
    public Player playerNumber;

    public enum Directions { Up, Down, Right, Left }

    Vector2Int gridPosition;
    Directions snakeDirection;

    float movementTimer;
    [HideInInspector] public float movementTimerMax = 1f;

    void Awake()
    {
        gridPosition = new Vector2Int(10, 10);
    }

    void Update()
    {
        movementTimer += Time.deltaTime;
        if(movementTimer >= movementTimerMax)
        {
            Move(snakeDirection);
            movementTimer = 0f;
        }

        #region Input Logic
        if (playerNumber == Player.PlayerA)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                snakeDirection = Directions.Up;
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                snakeDirection = Directions.Down;
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                snakeDirection = Directions.Right;
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                snakeDirection = Directions.Left;
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                snakeDirection = Directions.Up;
            }
            else if (Input.GetKeyDown(KeyCode.K))
            {
                snakeDirection = Directions.Down;
            }
            else if (Input.GetKeyDown(KeyCode.L))
            {
                snakeDirection = Directions.Right;
            }
            if (Input.GetKeyDown(KeyCode.J))
            {
                snakeDirection = Directions.Left;
            }
        }
        #endregion
    }

    void Move(Directions moveDirection)
    {
        switch (moveDirection)
        {
            case Directions.Up:
                gridPosition.y += 1;
                break;
            case Directions.Down:
                gridPosition.y -= 1;
                break;
            case Directions.Right:
                gridPosition.x += 1;
                break;
            case Directions.Left:
                gridPosition.x -= 1;
                break;
        }

        transform.position = new Vector3(gridPosition.x, gridPosition.y);
    }
}