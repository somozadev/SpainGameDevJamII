using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHolder : MonoBehaviour
{
    public Vector2 movementInput = Vector2.zero;
    public Vector2 lookInput = Vector2.zero;


    public void SetMoveInputVector(Vector2 move) => movementInput = move;
    public void SetLookInputVector(Vector2 look) => lookInput = look;

}
