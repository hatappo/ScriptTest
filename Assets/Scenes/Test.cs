using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    void Hello() {
        Debug.Log("Hello, UnityChan👏");
    }

    int Add(int a, int b) {
        int c = a + b;
        return c;
    }

    // Start is called before the first frame update
    void Start() {

        // Function
        Hello();
        int num = Add(3, 6);
        Debug.Log(num);
    }

    void Start2() {

        // Hello World
        Debug.Log("Hello, World!!");

        // Valiables
        int score;
        score = 150;
        Debug.Log(score);

        // Calculation
        int a = 3;
        int b = 4;
        int c = a + b;
        Debug.Log(c);

        // Condition
        int money = 100;
        if (money <= 50) {
            Debug.Log("武器を売る");
        } else if (money >= 200) {
            Debug.Log("武器を買う");
        } else {
            Debug.Log("ポーションを買う");
        }

        // Ternary operator
        int num = 1;
        // int val = (num == 1) ? -100 : 100; // 下と等価。
        int val = num == 1 ? -100 : 100;
        Debug.Log(val);

        // Scope
        int aa = 3;
        if (aa == 3) {
            int bb = 5;
            Debug.Log(bb); // OK
        }
        // Debug.Log(b); // error

        // Loop
        int sum = 0;
        for (int i = 1; i <= 10; i++) {
            sum += i;
        }
        Debug.Log("合計は " + sum);

        // Array
        int[] points = new int[5];
        points[0] = 30;
        points[1] = 20;
        points[2] = 50;
        points[3] = 10;
        points[4] = 80;
        for (int i = 0; i < 5; i++) {
            Debug.Log(points[i]);
        }
        int[] points2 = {30, 20, 50, 10, 80, 15, 60, 100};
        for (int i = 0; i < points2.Length; i++) {
            if (points2[i] >= 50) {
                Debug.Log(points2[i]);
            }
        }
        


    }

    // Update is called once per frame
    void Update() {
        
    }
}
