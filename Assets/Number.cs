using UnityEngine;
using System.Collections;

[System.Serializable]
public partial class Number : MonoBehaviour
{
    public GameObject Call;
    public UnityEngine.UI.InputField First;
    public UnityEngine.UI.Text Numb;
    public UnityEngine.UI.Text Top;
    public virtual void Start()
    {
        this.Call.SetActive(false);
    }

    public virtual void Update()
    {
    }

    public virtual void Generate()
    {
        int number = Random.Range(0, 10);
        int number2 = Random.Range(0, 10);
        int number3 = Random.Range(0, 10);
        int number4 = Random.Range(0, 10);
        int number5 = Random.Range(0, 10);
        int number6 = Random.Range(0, 10);
        int number7 = Random.Range(0, 10);
        this.Call.SetActive(true);
        this.Numb.text = (((((((("Number: " + "     -") + number) + number2) + number3) + "-") + number4) + number5) + number6) + number7;
        Debug.Log(((((((((("Number: " + this.First.text) + "-") + number) + number2) + number3) + "-") + number4) + number5) + number6) + number7);
        PlayerPrefs.SetString("Saved", ((((((this.First.text + number) + number2) + number3) + number4) + number5) + number6) + number7);
    }

    public virtual void Calling()
    {
        Application.OpenURL("tel://" + PlayerPrefs.GetString("Saved"));
        Debug.Log(PlayerPrefs.GetString("Saved"));
    }

    public virtual void Topic()
    {
        int topic = Random.Range(1, 11);
        if (topic == 1)
        {
            this.Top.text = "Topic: " + "Do you think Trump will win?";
        }
        else
        {
            if (topic == 2)
            {
                this.Top.text = "Topic: " + "How was your day?";
            }
            else
            {
                if (topic == 3)
                {
                    this.Top.text = "Topic: " + "Is your regrigerator running?";
                }
                else
                {
                    if (topic == 4)
                    {
                        this.Top.text = "Topic: " + "Soo the weather";
                    }
                    else
                    {
                        if (topic == 5)
                        {
                            this.Top.text = "Topic: " + "How did you get this number?!?";
                        }
                        else
                        {
                            if (topic == 6)
                            {
                                this.Top.text = "Topic: " + "Dinguses are spreading";
                            }
                            else
                            {
                                if (topic == 7)
                                {
                                    this.Top.text = "Topic: " + "What if we never met?";
                                }
                                else
                                {
                                    if (topic == 8)
                                    {
                                        this.Top.text = "Topic: " + "Where do you live?";
                                    }
                                    else
                                    {
                                        if (topic == 9)
                                        {
                                            this.Top.text = "Topic: " + "What would you do with a million?";
                                        }
                                        else
                                        {
                                            if (topic == 10)
                                            {
                                                this.Top.text = "Topic: " + "Bitcoin";
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }

}