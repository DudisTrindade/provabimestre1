using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MovimentacaoPersonagem : MonoBehaviour
{
    public float velocidade = 5f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moverHorizontal = Input.GetAxis("Horizontal");
        float moverVertical = Input.GetAxis("Vertical");

        Vector3 direcao = new Vector3(moverHorizontal, 0.0f, moverVertical);
        rb.MovePosition(transform.position + direcao * velocidade * Time.fixedDeltaTime);
    }
}