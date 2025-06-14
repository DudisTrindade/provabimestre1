using UnityEngine;

public class Personagem : MonoBehaviour
{
    [SerializeField] private string nome;
    [SerializeField] private int energia;
    [SerializeField] private int forca;
    [SerializeField] private int defesa;

    // Getters (Leitura)
    public string GetNome() => nome;
    public int GetEnergia() => energia;
    public int GetForca() => forca;
    public int GetDefesa() => defesa;

    // Setters (Escrita)
    public void SetNome(string novoNome) => nome = novoNome;
    public void SetEnergia(int novaEnergia) => energia = novaEnergia;
    public void SetForca(int novaForca) => forca = novaForca;
    public void SetDefesa(int novaDefesa) => defesa = novaDefesa;

    // Comparação entre dois personagens (por força)
    public bool CompararForca(Personagem outroPersonagem)
    {
        return this.forca > outroPersonagem.GetForca();
    }
}