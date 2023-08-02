using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    [SerializeField]    //시리얼라이즈필드 애트리뷰트를 사용하면 프라이빗 멤버도 인스펙터에 노출
    private float speed = 1;
    // Start is called before the first frame update
    private GameObject catGo;
    private float radius = 0.6f;
    void Start()
    {
        this.catGo = GameObject.Find("cat");
        Debug.Log("catGo: {0}", this.catGo);

        
    }

    // Update is called once per frame
    void Update()
    {

        //프레임 기반 이동
        //this.gameObject.transform.Translate(0, -1, 0);

        //시간 기반 이동
        this.gameObject.transform.Translate(this.speed * Vector3.down * Time.deltaTime);

        if (this.transform.position.y <= -4.4f)
        {
            Destroy(this.gameObject);
        }
        if (this.IsCollide())
        {
            GameObject gameDirectorGo = GameObject.Find("GameDirector");
            GameDirector gameDirector = gameDirectorGo.GetComponent<GameDirector>();
            gameDirector.DecreaseHp();
            Destroy(this.gameObject);
        }
        else
        {
            Debug.LogFormat("충돌하지 않았다.");
        }
    }

    private bool IsCollide()
    {
        //충돌 시 Hp를 감소
        float dis = Vector3.Distance(this.transform.position, this.catGo.transform.position);

        CatController catController = this.catGo.GetComponent<CatController>();
        float sumRadius = this.radius + catController.radius;


        return dis < sumRadius;
    }
}
