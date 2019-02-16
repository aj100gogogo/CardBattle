using UnityEngine;
using UnityEngine.UI;

public class SummonUnit : MonoBehaviour
{
    public void ShowCardL(GameObject gameObject)
    {
        Card newChar = Card.SpawnCard();
        Image image00 = gameObject.GetComponent<Image>();
        image00.sprite = newChar.textureL;
        LobbyManager.playerCards.Add(newChar);
    }

    public void ShowCardM(GameObject gameObject)
    {
        Card newChar = Card.SpawnCard();
        Image image00 = gameObject.GetComponent<Image>();
        image00.sprite = newChar.textureM;
        LobbyManager.playerCards.Add(newChar);
    }

    public void ShowCardS(GameObject gameObject)
    {
        Card newChar = Card.SpawnCard();
        Image image00 = gameObject.GetComponent<Image>();
        image00.sprite = newChar.textureS;
        LobbyManager.playerCards.Add(newChar);
    }
}
