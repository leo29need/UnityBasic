using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class practice_250610 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void Gachago()
    {
        int Numbegachago = 0;

        for (int i = 0; i < 10; i++)
        {
            int randomgachago = Random.Range(1, 101);

            switch (Numbegachago)
            {
                case 0:
                    {
                        if (randomgachago <= 10) // 10% Ȯ��
                        {
                            Debug.Log($"{i + 1}��°: 'ī��ī'�� �̾Ҵ�!");
                        }
                        else if (randomgachago <= 30) // 11~30���� 20% Ȯ��
                        {
                            Debug.Log($"{i + 1}��°:'����'�� �̾Ҵ�!");
                        }
                        else if (randomgachago <= 60) // 31~60���� 30% Ȯ��
                        {
                            Debug.Log($"{i + 1}��°:'�ݵ�'�� �̾Ҵ�!");
                        }
                        else
                        {
                            Debug.Log($"{i + 1}��°:'��γ�'�� �̾Ҵ�!");
                        }
                    }
                    break;
            }




        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
