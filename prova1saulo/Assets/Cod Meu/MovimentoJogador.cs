using UnityEngine;

public class MovimentoJogador : MonoBehaviour
{
    public float velocidade = 5f;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direcao = new Vector3(horizontal, 0, vertical);
        transform.Translate(direcao * velocidade * Time.deltaTime, Space.World);
    }
}