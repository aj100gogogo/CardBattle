using UnityEngine;

public class Card
{
    public string charName;
    public int charAtk;
    public int charSpeed;
    public Sprite textureL;
    public Sprite textureM;
    public Sprite textureS;

    public static Card SpawnCard()
    {
        int randomIndex = Random.Range(0, 19);
        Card spawnChar = new Card
        {
            charName = CardLibrary.charNames[randomIndex],
            charAtk = CardLibrary.charAtks[randomIndex],
            charSpeed = CardLibrary.charSpeeds[randomIndex],
            textureL = CardLibrary.charTextureLs[randomIndex],
            textureM = CardLibrary.charTextureMs[randomIndex],
            textureS = CardLibrary.charTextureSs[randomIndex]
        };
        return spawnChar;
    }
}
