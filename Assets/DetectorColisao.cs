using UnityEngine;
using TMPro;

public class DetectorColisao : MonoBehaviour
{
    public TextMeshProUGUI mensagemTexto;

    private void OnCollisionEnter(Collision col)
    {
        // Se o nome do objeto que você bateu contiver a palavra "Fire"
        if (col.gameObject.name.Contains("Fire"))
        {
            mensagemTexto.text = "YOU LOSE !!";
            Finalizar();
        }

        // Se o nome do objeto contiver a palavra "Vitoria" ou "Cube" (ajuste conforme seu cubo dourado)
        if (col.gameObject.name.Contains("Vitoria"))
        {
            mensagemTexto.text = "YOU WIN !!";
            Finalizar();
        }
    }

    void Finalizar()
    {
        mensagemTexto.gameObject.SetActive(true);
        Time.timeScale = 0; 
        Cursor.lockState = CursorLockMode.None;
    }
}