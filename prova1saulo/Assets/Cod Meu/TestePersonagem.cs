using UnityEngine;

public class TestePersonagem : MonoBehaviour
{
    public Elementalista elementalista1;
    public Elementalista elementalista2;

    void Start()
    {
        // Inicializando personagens com valores
        elementalista1.SetNome("Aeryn");
        elementalista1.SetEnergia(100);
        elementalista1.SetForca(80);
        elementalista1.SetDefesa(60);

        elementalista2.SetNome("Kael");
        elementalista2.SetEnergia(90);
        elementalista2.SetForca(70);
        elementalista2.SetDefesa(75);

        // Usar habilidade especial
        elementalista1.UsarHabilidadeEspecial();

        // Exibir valores
        Debug.Log($"Personagem 1: {elementalista1.GetNome()}, Força: {elementalista1.GetForca()}");
        Debug.Log($"Personagem 2: {elementalista2.GetNome()}, Força: {elementalista2.GetForca()}");

        // Comparar força
        if (elementalista1.CompararForca(elementalista2))
        {
            Debug.Log($"{elementalista1.GetNome()} é mais forte que {elementalista2.GetNome()}.");
        }
        else
        {
            Debug.Log($"{elementalista2.GetNome()} é mais forte que {elementalista1.GetNome()}.");
        }
    }
}