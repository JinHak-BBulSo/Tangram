using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // Exit 버튼을 누를 시
    public void OnClickExit()
    {
        GFunc.QuitThisGame();
    }
}
