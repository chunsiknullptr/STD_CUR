using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelectScene : MonoBehaviour
{
    [SerializeField]
    GameObject Garen;

    [SerializeField]
    GameObject Vein;

    [SerializeField]
    float speed = 1f;

    [SerializeField]
    float height = 1f;

    [SerializeField]
    float bottom = 0.22f;

    Vector3 moveDirection = Vector3.up;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() // ��û ª�� �ð��� ȣ�� ��
    {
        // dt = �ð��� �̺а�, �ſ� ª�� �ð�
        // ������ ��ġ�� y ����, 1���� ũ��, �̵��ϴ� ������ �Ʒ��� �ȴ�.
        // ������ ��ġ �� y ����, 0.22���� �Ʒ���� �̵��ϴ� ������ ���� ����ȴ�.
        if(Garen.transform.position.y >= height)
        {
            moveDirection = Vector3.down;
        }
        if (Garen.transform.position.y <= bottom)
        {
            moveDirection = Vector3.up;
        }


        Garen.transform.position += moveDirection * speed * Time.deltaTime;
        Vein.transform.position += moveDirection * speed * Time.deltaTime;
    }
}
