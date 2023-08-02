using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    [SerializeField]    //�ø���������ʵ� ��Ʈ����Ʈ�� ����ϸ� �����̺� ����� �ν����Ϳ� ����
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

        //������ ��� �̵�
        //this.gameObject.transform.Translate(0, -1, 0);

        //�ð� ��� �̵�
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
            Debug.LogFormat("�浹���� �ʾҴ�.");
        }
    }

    private bool IsCollide()
    {
        //�浹 �� Hp�� ����
        float dis = Vector3.Distance(this.transform.position, this.catGo.transform.position);

        CatController catController = this.catGo.GetComponent<CatController>();
        float sumRadius = this.radius + catController.radius;


        return dis < sumRadius;
    }
}
