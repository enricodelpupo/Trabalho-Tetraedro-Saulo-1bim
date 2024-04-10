using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class manager : MonoBehaviour
{

    public GameObject tetrahedron; // prefab da camrera
    public GameObject[] vetGameObj = new GameObject[24];
    public List<GameObject> tetrahedrons = new List<GameObject>();
    public float rotationSpeed = 30f;
    GameObject pai;
    Vector3 m_Center;
    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < 24; i++)
        {
            if (i == 0)
            {
                vetGameObj[i] = Instantiate(tetrahedron, new Vector3(0, 0, 0), Quaternion.identity); // tetraedro base
            }
            else
                vetGameObj[i] = Instantiate(tetrahedron, new Vector3(vetGameObj[i - 1].transform.position.x + 1, 0, 0), vetGameObj[i - 1].transform.rotation);
            //i-1 posicao anterior
        }

        //Face Rosa
        vetGameObj[3].transform.position = new Vector3(1.5f, 0.86f, 0.28868f);
        vetGameObj[3].transform.Rotate(37, 0, 180); // 90f
        //vetGameObj[3].transform.RotateAround(transform.position, Vector3.forward, 5f);
        pai = new GameObject();
        //pai.transform.position = new Vector3(0,1,0); //pivo
        pai.transform.position = new Vector3(1, 0, 0); //pivo
        //vetGameObj[3].transform.parent = pai.transform;
        //vetGameObj[3].transform.bounds

        vetGameObj[4].transform.position = new Vector3(2.5f, 0.86f, 0.28868f);
        vetGameObj[4].transform.Rotate(37, 0, 180);

        vetGameObj[5].transform.position = new Vector3(0.5f, 0.86f, 0.28868f);
        vetGameObj[5].transform.Rotate(0, 0, 0);

        vetGameObj[6].transform.position = new Vector3(2, 1.725f, 0.57f);
        vetGameObj[6].transform.Rotate(37, 0, 180);

        vetGameObj[7].transform.position = new Vector3(1.5f, 0.86f, 0.28868f);
        vetGameObj[7].transform.Rotate(0, 0, 0);

        vetGameObj[8].transform.position = new Vector3(1, 1.728f, 0.57f);
        vetGameObj[8].transform.Rotate(0, 0, 0);

        //Face Vermelha 
        vetGameObj[9].transform.position = new Vector3(1, 0, 1.72f);
        vetGameObj[9].transform.Rotate(0, 0, 0);

        vetGameObj[10].transform.position = new Vector3(0.5f, 0, 0.86f);
        vetGameObj[10].transform.Rotate(0, 0, 0);

        vetGameObj[11].transform.position = new Vector3(1, 0.86f, 1.143f);
        vetGameObj[11].transform.Rotate(0, 0, 0);

        GameObject rotacao19 = new GameObject();
        rotacao19.transform.position = new Vector3(20, 0, 0);

        vetGameObj[19].transform.parent = rotacao19.transform;

        rotacao19.transform.Rotate(0, 240, 0);
        rotacao19.transform.position = new Vector3(7.51f, 1.21f, 1.275f);

        GameObject giro19 = new GameObject();
        giro19.transform.position = new Vector3(7.51f, 1.21f, 1.275f);

        vetGameObj[19].transform.parent = giro19.transform;

        giro19.transform.Rotate(37, 0, 180);

        GameObject rotacao20 = new GameObject();
        rotacao20.transform.position = new Vector3(21, 0, 0);

        vetGameObj[20].transform.parent = rotacao20.transform;

        rotacao20.transform.Rotate(0, 240, 0);
        rotacao20.transform.position = new Vector3(7.01f, 0.35f, 0.98f);

        GameObject giro20 = new GameObject();
        giro20.transform.position = new Vector3(7.01f, 0.35f, 0.98f);

        vetGameObj[20].transform.parent = giro20.transform;

        giro20.transform.Rotate(37, 0, 180);

        GameObject rotacao21 = new GameObject();
        rotacao21.transform.position = new Vector3(22, 0, 0);

        vetGameObj[21].transform.parent = rotacao21.transform;

        rotacao21.transform.Rotate(0, 240, 0);
        rotacao21.transform.position = new Vector3(8, 0.35f, 0.98f);

        GameObject giro21 = new GameObject();
        giro21.transform.position = new Vector3(8, 0.35f, 0.98f);

        vetGameObj[21].transform.parent = giro21.transform;

        giro21.transform.Rotate(37, 0, 180);

        //Face Azul

        vetGameObj[12].transform.position = new Vector3(1.5f, 0, 0.86f);
        vetGameObj[12].transform.Rotate(0, 0, 0);

        vetGameObj[13].transform.position = new Vector3(2, 0, 1.72f);
        vetGameObj[13].transform.Rotate(0, -180, 0);

        vetGameObj[14].transform.position = new Vector3(2.5f, 0, 0.86f);
        vetGameObj[14].transform.Rotate(0, -180, 0);

        vetGameObj[15].transform.position = new Vector3(1.5f, 0, 0.86f);
        vetGameObj[15].transform.Rotate(0, -180, 0);

        //Face Amarela

        GameObject rotacao16 = new GameObject();
        rotacao16.transform.position = new Vector3(17, 0, 0);


        vetGameObj[16].transform.parent = rotacao16.transform;

        rotacao16.transform.Rotate(0, 120, 0);
        rotacao16.transform.position = new Vector3(4.5f, 0.86f, 0.28668f);

        GameObject giro16 = new GameObject();
        giro16.transform.position = new Vector3(4.5f, 0.86f, 0.28668f);

        vetGameObj[16].transform.parent = giro16.transform;

        giro16.transform.Rotate(37, 0, 180);


        GameObject rotacao17 = new GameObject();
        rotacao17.transform.position = new Vector3(18, 0, 0);


        vetGameObj[17].transform.parent = rotacao17.transform;

        rotacao17.transform.Rotate(0, 120, 0);
        rotacao17.transform.position = new Vector3(5.5f, 0.86f, 0.28668f);

        GameObject giro17 = new GameObject();
        giro17.transform.position = new Vector3(5.5f, 0.86f, 0.28668f);

        vetGameObj[17].transform.parent = giro17.transform;

        giro17.transform.Rotate(37, 0, 180);


        GameObject rotacao18 = new GameObject();
        rotacao18.transform.position = new Vector3(19, 0, 0);


        vetGameObj[18].transform.parent = rotacao18.transform;

        rotacao18.transform.Rotate(0, 120, 0);
        rotacao18.transform.position = new Vector3(5, 1.728f, 0.575f);

        GameObject giro18 = new GameObject();
        giro18.transform.position = new Vector3(5, 1.728f, 0.575f);

        vetGameObj[18].transform.parent = giro18.transform;

        giro18.transform.Rotate(37, 0, 180);

        // Rotaciona o tetraedro colocando a face Amarela para frente.
        GameObject rotacao = new GameObject();
        rotacao.transform.position = new Vector3(3, 0, 0);


        for (int i = 0; i <= 15; i++)
        {
            vetGameObj[i].transform.parent = rotacao.transform;
        }

        rotacao.transform.Rotate(0, 120, 0);

        //Rotaciona o tetraedro colocando a face Vermelha para frente
        GameObject vermelho = new GameObject();
        vermelho.transform.position = new Vector3(6, 0, 0);

        for (int i = 0; i <= 18; i++)
        {
            vetGameObj[i].transform.parent = vermelho.transform;
        }

        vermelho.transform.Rotate(0, 120, 0);


        //Rotaciona colocando novamente a face rosa para frente e retorna o Tetraedro para o ponto (0,0,0).
        GameObject pontoZero = new GameObject();
        pontoZero.transform.position = new Vector3(9, 0, 0);

        for (int i = 0; i <= 21; i++)
        {
            vetGameObj[i].transform.parent = pontoZero.transform;
        }

        pontoZero.transform.Rotate(0, 120, 0);
        pontoZero.transform.position = new Vector3(1, 0, 0);

    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.F1))
        {
            GameObject paiRotate = new GameObject();
            paiRotate.transform.position = new Vector3(2.54f, 0, 0.9f);
            for (int i = 0; i < 24; i++)
            {

                if (vetGameObj[i].transform.position.y >= -0.100f && vetGameObj[i].transform.position.y <= 0.3000f)
                    vetGameObj[i].transform.parent = paiRotate.transform;
            }
            paiRotate.transform.Rotate(0, 120f, 0.0f);;
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            GameObject paiRotate2 = new GameObject();
            paiRotate2.transform.position = new Vector3(2.54f, 0, 0.9f);
            for (int i = 0; i < 24; i++)
            {
                if (vetGameObj[i].transform.position.y >= 0.86f && vetGameObj[i].transform.position.y <=1.725f)
                    vetGameObj[i].transform.parent = paiRotate2.transform;
            }
            paiRotate2.transform.Rotate(0, 120f, 0.0f);
        }
          if (Input.GetKeyDown(KeyCode.F3))
        {
            GameObject paiRotate3 = new GameObject();
            paiRotate3.transform.position = new Vector3(2.54f, 0, 0.9f);
           for (int i = 0; i < 24; i++)
           {
               if (vetGameObj[i].transform.position.y == 1.728f)
                   vetGameObj[i].transform.parent = paiRotate3.transform;
           }
           paiRotate3.transform.Rotate(0.0f, 120f, 0.0f);
        }

    }
}
