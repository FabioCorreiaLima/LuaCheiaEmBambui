using UnityEngine;

public class ExitData : MonoBehaviour {
    public string nextSceneName;
    public int[] requiredItemIDs;
    public Sprite exitNotificationImage;

    [Header("Fala do �nibus")]
    public AudioClip soundText;

    [Header("Som ao sair da cena")]
    public AudioClip exitSound;
}
