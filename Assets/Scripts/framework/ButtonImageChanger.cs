using UnityEngine;
using UnityEngine.UI;

public class ButtonImageChanger : MonoBehaviour
{
    public Button button; // O botão que será clicado
    public Sprite newImage; // A nova imagem para o botão

    private Image buttonImage; // A imagem atual do botão

    void Start()
    {
        // Obtém a componente de imagem do botão
        buttonImage = button.GetComponent<Image>();

        // Adiciona um listener ao botão para chamar a função OnButtonClick quando clicado
        button.onClick.AddListener(OnButtonClick);
    }

    void OnButtonClick()
    {
        // Altera a imagem do botão para a nova imagem
        buttonImage.sprite = newImage;
    }
}