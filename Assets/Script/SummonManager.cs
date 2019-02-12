using UnityEngine;
using UnityEngine.UI;

public class SummonManager : MonoBehaviour
{
    private void Start()
    {
        int randomIndex = Random.Range(0, 19);
    }

    public void ShowCardL(GameObject gameObject)
    {
        Char newChar = Char.SpawnChar();
        Image image00 = gameObject.GetComponent<Image>();
        image00.sprite = newChar.textureL;
        LobbyManager.playerCards.Add(newChar);
        //Debug.Log(LobbyManager.playerCards);
    }

    public void ShowCardM(GameObject gameObject)
    {
        Char newChar = Char.SpawnChar();
        Image image00 = gameObject.GetComponent<Image>();
        image00.sprite = newChar.textureM;
        LobbyManager.playerCards.Add(newChar);
    }

    public void ShowCardS(GameObject gameObject)
    {
        Char newChar = Char.SpawnChar();
        Image image00 = gameObject.GetComponent<Image>();
        image00.sprite = newChar.textureS;
        LobbyManager.playerCards.Add(newChar);
    }
}
