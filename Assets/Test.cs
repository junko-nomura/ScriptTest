
using UnityEngine;
using System.Collections;

//発展課題Bossクラス
public class Boss{
	private int mp = 53;
	public void Magic(){
		if(this.mp >= 5){
			this.mp -= 5;
			Debug.Log("魔法攻撃をした。残りMPは"+ this.mp);
		}else {
			Debug.Log("MPが足りないた魔法が使えない。");
		}
	}
}

public class Test : MonoBehaviour {
	

	// Use this for initialization
	void Start () {

		//配列の宣言
		int[] array = {10,11,12,13,14};

		//配列を順番通り表示する
		for (int i = 0; i < array.Length; i++) {
			Debug.Log (array [i]);
		}

		//配列を逆から表示する
		for(int i = array.Length -1 ; i >= 0; i --){
			Debug.Log(array[i]);
		}

		//発展課題　Bossクラスを呼び出す
		Boss lastboss = new Boss ();
		for (int i = 0; i <= 10; i++) {
			lastboss.Magic ();

		}

	}
	// Update is called once per frame
	void Update () {
		
	}
}
//using System.Collections.Generic; 2

