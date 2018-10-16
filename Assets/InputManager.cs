using System.Collections;
using UnityEngine;

public static class InputManager {
    public static float vertical()
    {
        return Input.GetAxisRaw("Vertical");
    }
}
