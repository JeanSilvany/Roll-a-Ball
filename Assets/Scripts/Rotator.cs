using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class Rotator : MonoBehaviour
{
    private Vector3 rotator = new(15,30,45);

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotator * Time.deltaTime);
    }
}
