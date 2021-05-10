using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject main,c1,c2,c3,c4,c5,c6,c7,c8;

    public void Content01(){
        main.SetActive(false);
        c1.SetActive(true);
    }

    public void Content02(){
        main.SetActive(false);
        c2.SetActive(true);
    }

    public void Content03(){
        main.SetActive(false);
        c3.SetActive(true);
    }

    public void Content04(){
        main.SetActive(false);
        c4.SetActive(true);
    }

    public void Content05(){
        main.SetActive(false);
        c5.SetActive(true);
    }

    public void Content06(){
        main.SetActive(false);
        c6.SetActive(true);
    }

    public void Content07(){
        main.SetActive(false);
        c7.SetActive(true);
    }

    public void Content08(){
        main.SetActive(false);
        c8.SetActive(true);
    }

    public void BackToMenu(){
        c1.SetActive(false);
        c2.SetActive(false);
        c3.SetActive(false);
        c4.SetActive(false);
        c5.SetActive(false);
        c6.SetActive(false);
        c7.SetActive(false);
        c8.SetActive(false);

        main.SetActive(true);
    }
}
