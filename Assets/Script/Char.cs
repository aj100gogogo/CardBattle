using UnityEngine;

public class Char
{
    public string charName;
    public int charAtk;
    public int charSpeed;
    public Sprite textureL;
    public Sprite textureM;
    public Sprite textureS;

    public static Char SpawnChar()
    {
        int randomIndex = Random.Range(0, 19);
        Char spawnChar = new Char
        {
            charName = CharLibrary.charNames[randomIndex],
            charAtk = CharLibrary.charAtks[randomIndex],
            charSpeed = CharLibrary.charSpeeds[randomIndex],
            textureL = CharLibrary.charTextureLs[randomIndex],
            textureM = CharLibrary.charTextureMs[randomIndex],
            textureS = CharLibrary.charTextureSs[randomIndex]
        };
        return spawnChar;
    }
}
