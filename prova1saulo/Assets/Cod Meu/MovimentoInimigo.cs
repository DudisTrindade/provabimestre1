using UnityEngine;

public class MovimentoInimigo : MonoBehaviour
{
    public Transform alvo; // Referência ao jogador
    public float velocidade = 2f;
    public float raioDeVisao = 5f; // Distância máxima para começar a seguir

    void Update()
    {
        if (alvo != null)
        {
            float distancia = Vector3.Distance(transform.position, alvo.position);

            if (distancia <= raioDeVisao)
            {
                // Olha para o jogador
                transform.LookAt(alvo);

                // Anda até ele
                transform.Translate(Vector3.forward * velocidade * Time.deltaTime);
            }
        }
    }
}