using UnityEngine;
using UnityEngine.UI;

public class HealthDrawerScript : MonoBehaviour
{
    public Sprite FullHeart;
    public Sprite EmptyHeart;

    public GameObject[] HeartObjects;
    private Image[] Hearts;

    public void Draw(int lives)
    {
        //there is a index out of range exception ,so check it here 
        for(int i = 0; i < lives; i++)
        {
            if(Hearts != null && Hearts.Length > i)
                Hearts[i].sprite = FullHeart;
        }

        for(int i = lives; i < Hearts.Length; i++)
        {
            if(Hearts != null && Hearts.Length > i)
                Hearts[i].sprite = EmptyHeart;
        }
    }

    // Use this for initialization
    void OnEnable ()
    {
        Hearts = new Image[HeartObjects.Length];

        for(int i = 0; i < 5; i++)
        {
            Hearts[i] = HeartObjects[i].GetComponent<Image>();
        }

        Draw(Hearts.Length);
    }
}
