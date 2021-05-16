using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplayerSetting : MonoBehaviour
{
    // Start is called before the first frame update
    public static MultiplayerSetting multiplayersetting;
    public bool delayStart;
    public int maxPlayers;

    public int menuScene;
    public int multiplayerScene;

    private void Awake()
    {
        if (MultiplayerSetting.multiplayersetting == null)
        {
            MultiplayerSetting.multiplayersetting = this;
        }
        else
        {
            if(MultiplayerSetting.multiplayersetting!=this)
            {
                Destroy(this.gameObject);
            }
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
