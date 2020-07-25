using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {
    private int hp = 100;
    private int mp = 53;
    private int power = 25;
    const int MAGIC_CONSUMPTION = 5;

    public void Attack() {
        Debug.Log(this.power + " のダメージを与えた");
    }

    public void Magic() {
        if (this.mp >= MAGIC_CONSUMPTION) {
            this.mp -= MAGIC_CONSUMPTION;
            Debug.Log("魔法攻撃をした。残りMPは " + this.mp);
        } else {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }

    public void Defence(int damage) {
        Debug.Log(damage + " のダメージを受けた");
        this.hp -= damage;
    }
}

public class Homework : MonoBehaviour {

    private void ShowSparator(string s) {
        Debug.Log(new string('-', 10) + " " + s + " " + new string('-', 10));
    }

    void Start() {

        // Homework
        ShowSparator("Homework");
        int[] a = {10, 20, 30, 40, 50};
        foreach (var item in a) {
            Debug.Log(item);
        }
        int[] b = {10, 20, 30, 40, 50};
        for (int i = b.Length - 1; i >= 0 ; i--) {
            Debug.Log(b[i]);
        }

        // Advanced homework
        ShowSparator("Advanced Homework");
        Boss lastboss = new Boss();
        lastboss.Attack();
        lastboss.Defence(3);
        for (int i = 0; i < 10; i++) {
            lastboss.Magic();
        }
        Debug.Log("---- 次の魔法攻撃はMP不足で失敗すると思われる。");
        lastboss.Magic();
    }

    void Update() {/*nothing*/}
}
