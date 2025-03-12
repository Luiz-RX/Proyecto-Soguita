using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 3.5f;    // Velocidad de avance/retroceso
    public float rotationSpeed = 150f; // Velocidad de rotaci�n en grados por segundo
    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Movimiento adelante / atr�s
        float moveDirection = Input.GetAxis("Vertical"); // W (1) / S (-1)
        Vector3 move = transform.forward * moveDirection * moveSpeed * Time.deltaTime;
        controller.Move(move);

        // Rotaci�n izquierda / derecha
        float rotation = Input.GetAxis("Horizontal"); // A (-1) / D (1)
        transform.Rotate(Vector3.up * rotation * rotationSpeed * Time.deltaTime);
    }
}
