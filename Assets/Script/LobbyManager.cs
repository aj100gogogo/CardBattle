using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class LobbyManager : MonoBehaviour
{
    public GameObject m_lobby;
    public GameObject m_summon;
    public GameObject m_battle;
    public GameObject m_library;
    public GameObject m_summonResult;
    public GameObject m_summonGet1;
    public GameObject m_summonGet5;
    public GameObject card00;
    public GameObject card01;
    public GameObject card02;
    public GameObject card03;
    public GameObject card04;
    public GameObject card05;
    public GameObject player01;
    public GameObject player02;
    public GameObject player03;
    public GameObject enemy01;
    public GameObject enemy02;
    public GameObject enemy03;
    public Button m_btnSummon;
    public Button m_btnSummon1;
    public Button m_btnSummon5;
    public Button m_btnBattle;
    public Button m_btnLibrary;
    public Button m_btnBackInSummon;
    public Button m_btnBackInLibrary;
    public Button m_btnBackAfterSummon;
    public Button m_btnBackAfterBattle;
    public static List<Card> playerCards = new List<Card>();

    //initiate and set buttons
    void Start()
    {
        m_lobby.SetActive(true);
        m_summon.SetActive(false);
        m_summonResult.SetActive(false);
        m_summonGet1.SetActive(false);
        m_summonGet5.SetActive(false);
        m_battle.SetActive(false);
        m_library.SetActive(false);
        m_btnSummon.onClick.AddListener(GoSummon);
        m_btnSummon1.onClick.AddListener(SummonOnce);
        m_btnSummon5.onClick.AddListener(SummonFiveTimes);
        m_btnBattle.onClick.AddListener(GoBattle);
        m_btnLibrary.onClick.AddListener(GoLibrary);
        m_btnBackInSummon.onClick.AddListener(BackToLobby);
        m_btnBackInLibrary.onClick.AddListener(BackToLobby);
        m_btnBackAfterSummon.onClick.AddListener(BackToLobby);
        m_btnBackAfterBattle.onClick.AddListener(BackToLobby);
    }

    void GoSummon()
    {
        m_lobby.SetActive(false);
        m_summon.SetActive(true);
    }

    void GoBattle()
    {
        m_lobby.SetActive(false);
        m_battle.SetActive(true);

        GameObject[] cards = new GameObject[] { player01, player02, player03, enemy01, enemy02, enemy03 };
        foreach (GameObject card in cards)
        {
            SummonUnit summonUnit = new SummonUnit();
            summonUnit.ShowCardS(card);
        }
    }

    void GoLibrary()
    {
        m_lobby.SetActive(false);
        m_library.SetActive(true);

        LibraryUnit libraryUnit = gameObject.AddComponent(typeof(LibraryUnit)) as LibraryUnit;
        libraryUnit.ShowList();
    }

    void SummonOnce()
    {
        m_summonResult.SetActive(true);
        m_summonGet1.SetActive(true);
        m_summonGet5.SetActive(false);

        SummonUnit summonUnit = gameObject.AddComponent(typeof(SummonUnit)) as SummonUnit;
        summonUnit.ShowCardL(card00);
    }

    void SummonFiveTimes()
    {
        m_summonResult.SetActive(true);
        m_summonGet5.SetActive(true);
        m_summonGet1.SetActive(false);

        GameObject[] cards = new GameObject[] { card01, card02, card03, card04, card05 };
        foreach (GameObject card in cards)
        {
            SummonUnit summonUnit = gameObject.AddComponent(typeof(SummonUnit)) as SummonUnit;
            summonUnit.ShowCardM(card);
        }
    }

    void BackToLobby()
    {
        m_summon.SetActive(false);
        m_battle.SetActive(false);
        m_library.SetActive(false);
        m_summonResult.SetActive(false);
        m_lobby.SetActive(true);
    }
}
