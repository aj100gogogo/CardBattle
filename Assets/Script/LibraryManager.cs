using UnityEngine;
using UnityEngine.UI;

public class LibraryManager : MonoBehaviour
{
    public GameObject listContent;

    public void ShowList()
    {
        Debug.Log(LobbyManager.playerCards);
        listContent = Resources.Load<GameObject>("Prefab/card");

        foreach (Char playerCard in LobbyManager.playerCards)
        {
            Instantiate(listContent);
            LibraryContent libraryContent = listContent.GetComponent<LibraryContent>();
            libraryContent.cardName.text = playerCard.charName;
            libraryContent.cardAtk.text = playerCard.charAtk.ToString();
            libraryContent.cardSpeed.text = playerCard.charSpeed.ToString();
            Image cardImage = libraryContent.GetComponent<Image>();
            cardImage.sprite = playerCard.textureS;
        }
    }
}
