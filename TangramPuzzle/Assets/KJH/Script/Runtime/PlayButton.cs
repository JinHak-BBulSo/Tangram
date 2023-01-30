using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 플레이 버튼을 누를 시
    public void OnClickPlay()
    {
        GFunc.LoadScene(GData.SCENE_NAME_PLAY);
    }
}
