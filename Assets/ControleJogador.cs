using UnityEngine;

public class ControleJogador : MonoBehaviour
{
    public float velocidade = 10f;
    public float sensibilidadeMouse = 2.0f;
    private float rotacaoX = 0f;

    void Start()
    {
        // Isso faz o mouse sumir e ficar preso no meio da tela
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) { Cursor.lockState = CursorLockMode.Locked; }
        // Movimento WASD
        float moverHorizontal = Input.GetAxis("Horizontal");
        float moverVertical = Input.GetAxis("Vertical");
        Vector3 movimento = transform.right * moverHorizontal + transform.forward * moverVertical;
        transform.position += movimento * velocidade * Time.deltaTime;

        // Rotação com o Mouse
        float mouseX = Input.GetAxis("Mouse X") * sensibilidadeMouse;
        float mouseY = Input.GetAxis("Mouse Y") * sensibilidadeMouse;

        rotacaoX -= mouseY;
        rotacaoX = Mathf.Clamp(rotacaoX, -90f, 90f); // Impede de dar pirueta com a cabeça

        Camera.main.transform.localRotation = Quaternion.Euler(rotacaoX, 0f, 0f);
        transform.Rotate(Vector3.up * mouseX);
    }
}