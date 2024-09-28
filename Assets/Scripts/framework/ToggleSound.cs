using UnityEngine;
using UnityEngine.UI;

public class ToggleGameSound : MonoBehaviour
{
    // Referência para o botão
    public Button soundButton;
    // Variável para controlar o estado do som
    private bool isMuted = false;

    void StartGameMute()
    {
        // Verifica se o botão foi atribuído
        if (soundButton != null)
        {
            // Adiciona o listener para o clique do botão
            soundButton.onClick.AddListener(ToggleGameAudio);
        }
    }

    void ToggleGameAudio()
    {
        // Alterna o estado do som
        isMuted = !isMuted;

        // Define o volume do áudio principal (mestre)
        AudioListener.volume = isMuted ? 0 : 1;

        // Opcional: Atualiza o texto do botão conforme o estado do som
        soundButton.GetComponentInChildren<Text>().text = isMuted ? "Som Off" : "Som On";
    }
}

