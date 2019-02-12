using UnityEngine;

public class CharLibrary : MonoBehaviour
{
    static readonly int numOfChar = 20;
    public static string[] charNames = new string[numOfChar];
    public static int[] charAtks = new int[numOfChar];
    public static int[] charSpeeds = new int[numOfChar];
    public static Sprite[] charTextureLs = new Sprite[numOfChar];
    public static Sprite[] charTextureMs = new Sprite[numOfChar];
    public static Sprite[] charTextureSs = new Sprite[numOfChar];

    //set char info
    void Start()
    {
        charNames[0] = "角色一";
        charNames[1] = "角色二";
        charNames[2] = "角色三";
        charNames[3] = "角色四";
        charNames[4] = "角色五";
        charNames[5] = "角色六";
        charNames[6] = "角色七";
        charNames[7] = "角色八";
        charNames[8] = "角色九";
        charNames[9] = "角色十";
        charNames[10] = "角色十一";
        charNames[11] = "角色十二";
        charNames[12] = "角色十三";
        charNames[13] = "角色十四";
        charNames[14] = "角色十五";
        charNames[15] = "角色十六";
        charNames[16] = "角色十七";
        charNames[17] = "角色十八";
        charNames[18] = "角色十九";
        charNames[19] = "角色二十";

        for (int index = 0; index < numOfChar; index++)
        {
            charAtks[index] = Random.Range(100, 1000);
            charSpeeds[index] = Random.Range(1, 6);
            int num = index + 1;
            string pathwayL = "Texture/CharL/char" + num + "_L";
            string pathwayM = "Texture/CharM/char" + num + "_M";
            string pathwayS = "Texture/CharS/char" + num + "_S";
            charTextureLs[index] = Resources.Load<Sprite>(pathwayL);
            charTextureMs[index] = Resources.Load<Sprite>(pathwayM);
            charTextureSs[index] = Resources.Load<Sprite>(pathwayS);
        }
    }
}
