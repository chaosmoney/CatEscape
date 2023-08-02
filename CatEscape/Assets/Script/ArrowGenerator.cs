using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    private float elapsedTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Time.delatTime ��򰡿��ٰ� ���� : �귯�� �ð�
        this.elapsedTime += Time.deltaTime;

        if(this.elapsedTime > 1f)
        {
            //ȭ���� �����
            this.CreateArrow();
            this.elapsedTime = 0;
        }
    }

    private void CreateArrow()
    {
        GameObject arrowGo = Instantiate(this.arrowPrefab);
        arrowGo.transform.position = new Vector3(Random.Range(-8, 9), 6f, 0);
    }
}
