using UnityEngine;
using System.Collections;

public class destroy: MonoBehaviour
{
    //Unityちゃんのオブジェクト
    private GameObject unitychan;
    //Unityちゃんとカメラの距離
    private float difference;

    // Use this for initialization
    void Start()
    {
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
        //Unityちゃんとカメラの位置（z座標）の差を求める
        this.difference = unitychan.transform.position.z - this.transform.position.z;

    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("ここまできた１");

        if (other.gameObject.tag == "CoinTag")
        {
            Debug.Log("ここまできた2");
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "CarTag")
        {
            Debug.Log("ここまできた3");
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "TrafficConeTag")
        {
            Debug.Log("ここまできた4");
            Destroy(other.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        //Unityちゃんの位置に合わせてカメラの位置を移動
        this.transform.position = new Vector3(0, this.transform.position.y, this.unitychan.transform.position.z - difference);
    }
}