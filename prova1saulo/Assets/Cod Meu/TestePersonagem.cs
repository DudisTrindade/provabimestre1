using UnityEngine;

public class TestePersonagens : MonoBehaviour
{
    public Elementalista elementalista;
    public Inimigo inimigo;

    void Start()
    {
        // Preencher valores
        elementalista.AtribuirNome("Mestre dos Gelo");
        elementalista.AtribuirEnergia(100);
        elementalista.AtribuirForcaAtaque(50);
        elementalista.AtribuirVelocidade(20);

        inimigo.AtribuirNome("Goblin Guerreiro");
        inimigo.AtribuirEnergia(80);
        inimigo.AtribuirForcaAtaque(40);
        inimigo.AtribuirVelocidade(15);

        // Usar funções
        Debug.Log("Nome do Elementalista: " + elementalista.LerNome());
        Debug.Log("Energia do Inimigo: " + inimigo.LerEnergia());

        elementalista.UsarHabilidadeEspecial();
        inimigo.AtaqueSimples();

        // Comparar energias
        elementalista.CompararEnergia(inimigo);
    }
}