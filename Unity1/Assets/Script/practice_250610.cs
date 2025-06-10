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
                        if (randomgachago <= 10) // 10% 확률
                        {
                            Debug.Log($"{i + 1}번째: '카프카'를 뽑았다!");
                        }
                        else if (randomgachago <= 30) // 11~30까지 20% 확률
                        {
                            Debug.Log($"{i + 1}번째:'은랑'을 뽑았다!");
                        }
                        else if (randomgachago <= 60) // 31~60까지 30% 확률
                        {
                            Debug.Log($"{i + 1}번째:'반디'를 뽑았다!");
                        }
                        else
                        {
                            Debug.Log($"{i + 1}번째:'브로냐'를 뽑았다!");
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
