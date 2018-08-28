using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointup : MonoBehaviour {

    //  scoreを表示するテキスト
    private GameObject ScoreBoadText;

    //　得点
    private int score = 0;


    // Use this for initialization
    void Start () {

        //  シーン中のscoreboadTextの取得
        this.ScoreBoadText = GameObject.Find("ScoreBoadText");

        //  scoreboadに得点を表示
        this.ScoreBoadText.GetComponent<Text>().text = "Score" + this.score;

    }

    // Update is called once per frame
    void Update() {

    }

    //  衝突時に呼ばれる関数
    void OnCollisionEnter(Collision collision) {

        if (collision.gameObject.tag == "SmallCloudTag") {

            //  得点をscoreに加算
            this.score += 10;

        }else if( collision.gameObject.tag == "SmallStarTag") { 
                
            this.score += 50;

        }else if( collision.gameObject.tag == "LargeCloudTag") { 

            this.score += 2000;

        }else if( collision.gameObject.tag == "LargeStarTag") { 

            this.score += 500;

        }else{
            this.score += 0;
        }
        
        //  scoreboadに得点を更新表示
        this.ScoreBoadText.GetComponent<Text>().text = "Score" + this.score;

        
    }
    
}
