using UnityEngine;
using UnityEngine.UI;

public class LibraryUnit : MonoBehaviour
{
    public Transform content;

    public void ShowList()
    {
        GameObject listObj = Resources.Load<GameObject>("Prefab/libraryContent");

        foreach (Card playerCard in LobbyManager.playerCards)
        {
            LibraryContent libraryContent = listObj.GetComponent<LibraryContent>();
            libraryContent.cardName.text = playerCard.charName;
            libraryContent.cardAtk.text = "Atk " + playerCard.charAtk.ToString();
            libraryContent.cardSpeed.text = "Speed " + playerCard.charSpeed.ToString();
            Image cardImage = libraryContent.cardGO.GetComponent<Image>();
            cardImage.sprite = playerCard.textureS;
            Instantiate(listObj, content);
        }
    }
}
