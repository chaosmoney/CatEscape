using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameDirector : MonoBehaviour
{
    private GameObject catGo;
    private GameObject hpGageGo;
    // Start is called before the first frame update
    void Start()
    {
        this.catGo = GameObject.Find("cat");
        this.hpGageGo = GameObject.Find("hpGage");

        Image hpGage = this.hpGageGo.GetComponent<Image>();
    }

    // Update is called once per frame
    public void DecreaseHp()
    {
        Image hpGage = this.hpGageGo.GetComponent<Image>();
        hpGage.fillAmount -= 0.1f;
    }
}
