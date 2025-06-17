using UnityEngine;

public class Personagem : MonoBehaviour
{
    [SerializeField] private string nome;
    [SerializeField] private int energia;
    [SerializeField] private int forcaAtaque;
    [SerializeField] private int velocidade;

    public void AtribuirNome(string novoNome)
    {
        nome = novoNome;
    }

    public string LerNome()
    {
        return nome;
    }

    public void AtribuirEnergia(int valor)
    {
        energia = valor;
    }

    public int LerEnergia()
    {
        return energia;
    }

    public void AtribuirForcaAtaque(int valor)
    {
        forcaAtaque = valor;
    }

    public int LerForcaAtaque()
    {
        return forcaAtaque;
    }

    public void AtribuirVelocidade(int valor)
    {
        velocidade = valor;
    }

    public int LerVelocidade()
    {
        return velocidade;
    }

    // Comparar quem tem mais energia
    public void CompararEnergia(Personagem outro)
    {
        if (energia > outro.LerEnergia())
        {
            Debug.Log(nome + " tem mais energia que " + outro.LerNome());
        }
        else if (energia < outro.LerEnergia())
        {
            Debug.Log(outro.LerNome() + " tem mais energia que " + nome);
        }
        else
        {
            Debug.Log(nome + " e " + outro.LerNome() + " têm a mesma energia.");
        }
    }
}
