using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Test_star : MonoBehaviour
{
    string star;


    // Start is called before the first frame update
    void Start()
    {
            Phase1();
            Phase2();
            Phase3();
            Phase4();
            Phase5();

       /* star += "��"; // ��
        star += "��"; // ��ĭ
        star += "\n"; // �ٹٲ� */

    }
    public void Phase1()
    {
        star = string.Empty;

        // ������ 1

        for (int i = 1; i <= 5; i++)
        {
            string stars = "";

            for (int a = 0; a < i; a++)
            {
                star += "��";
            }

            star += "\n";

            Debug.Log(star);
        }
    }

    public void Phase2()
    {
        star = string.Empty;

        // ������ 2

        for (int i = 5; i >= 1; i--)
        {
            string stars = "";

            for (int a = 0; a < i; a++)
            {
                star += "��";
            }

            star += "\n";

            Debug.Log(star);
        }
    }

    public void Phase3()
    {
        star = string.Empty;

        // ������ 3

        //��
        for (int i = 1; i <= 5; i++)
        {
            string stars = "";

            for (int a = 0; a < i; a++)
            {
                star += "��";
            }
            star += "\n";

        }
        //�Ʒ�
        for (int i = 4; i >= 1; i--)
        {
            string stars = "";

            for (int a = 0; a < i; a++)
            {
                star += "��";
            }
            star += "\n";

        }

        Debug.Log(star);
    }

    public void Phase4()
    {
        star = string.Empty;

        // ������ 4


        Debug.Log(star);
    }

    public void Phase5()
    {
        star = string.Empty;

        // ������ 5


        Debug.Log(star);
    }
}

    // Update is called once per frame

