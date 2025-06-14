using UnityEngine;

public class Elementalista : Personagem
{
    [SerializeField] private string habilidadeEspecial = "Tempestade de Gelo";

    public string GetHabilidadeEspecial() => habilidadeEspecial;
    public void UsarHabilidadeEspecial()
    {
        Debug.Log($"{GetNome()} usou {habilidadeEspecial}!");
    }
}

