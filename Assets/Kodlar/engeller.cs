using TMPro;
using UnityEngine;


public class engeller : MonoBehaviour
{

    private static int skorSayac;
    public TextMeshProUGUI skor;

    public TextMeshProUGUI bitisYazisi;

    private void Start()
    {
        skorSayac = 0;
    }



    void OnCollisionEnter2D(Collision2D temas)
    {
        float xPozisyonu = Random.Range(-4.1f, 4.1f);
        float yPozisyonu = Random.Range(6.5f, 14f);

        if (temas.gameObject.tag == "zemin")
        {
            skorSayac = skorSayac + 1;

            transform.position = new Vector2(xPozisyonu, yPozisyonu);
        }

        else if (temas.gameObject.tag == "karakter")
        {
            hak.kalanCan--;
            transform.position = new Vector2(xPozisyonu, yPozisyonu);

        }
    }

    public GameObject Panel;


    void Update()
    {
        skor.text = skorSayac.ToString();
        bitisYazisi.text = "Oyun Bitti \n Skor : " + skorSayac.ToString();

    }


}
