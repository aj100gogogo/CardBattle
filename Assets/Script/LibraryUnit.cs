using UnityEngine;
using UnityEngine.UI;

public class LibraryUnit : MonoBehaviour
{
    public void ShowList()
    {
        for (int i = 0; i < LobbyManager.playerCards.Count; i ++)
        {
            GameObject obj = GameObject.Find("/Canvas/library/Scroll View/Viewport/Content/libraryContent(Clone)");
            Destroy(obj);
        }

        GameObject content = GameObject.Find("/Canvas/library/Scroll View/Viewport/Content");
        GameObject go = Resources.Load<GameObject>("Prefab/libraryContent");

        foreach (Card playerCard in LobbyManager.playerCards)
        {
            GameObject listObj = Instantiate(go);
            LibraryContent libraryContent = listObj.GetComponent<LibraryContent>();
            libraryContent.cardName.text = playerCard.charName;
            libraryContent.cardAtk.text = "Atk " + playerCard.charAtk.ToString();
            libraryContent.cardSpeed.text = "Speed " + playerCard.charSpeed.ToString();
            Image cardImage = libraryContent.cardGO.GetComponent<Image>();
            cardImage.sprite = playerCard.textureS;
            listObj.transform.SetParent(content.transform);
        }
    }
}
