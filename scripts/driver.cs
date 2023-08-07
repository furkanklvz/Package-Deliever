using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class driver : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] float rotatingSpeed = 150f;
    public GameObject speedBoost, package, customer;
    GameObject clonePackage, cloneCustomer;
    public GameObject spawner1, spawner2, spawner3, spawner4, spawner5, spawner6, spawner7, spawner8, spawner9, spawner10, spawner11, spawner12, spawner13,
    spawner14, spawner15, spawner16, spawner17, spawner18, spawner19, spawner20, spawner21, spawner22, spawner23;
    float rotate, xPosition, yPosition, forward;
    public AudioSource carSound, boostSound, pickupPackage, customerAudio;
    public TextMeshProUGUI boostTime, packageDelivered, hint;
    int except = 25;
    int numOfPackage;


    void Start()
    {
        objectCreater(package);
    }

    void Update()
    {
        xPosition = Mathf.Clamp(transform.position.x, -82, 148);
        yPosition = Mathf.Clamp(transform.position.y, -58, 33);
        transform.position = new Vector2(xPosition, yPosition);

        forward = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        if (forward > 0)
        {
            carSound.Pause();
            carSound.Play();
            rotate = Input.GetAxis("Horizontal") * -rotatingSpeed * Time.deltaTime;
        }
        else if (forward < 0)
        {
            carSound.Pause();
            carSound.Play();
            rotate = Input.GetAxis("Horizontal") * rotatingSpeed * Time.deltaTime;
        }
        else
        {
            carSound.Pause();
            rotate = 0;
        }
        transform.Rotate(0, 0, rotate);
        transform.Translate(0, forward, 0);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == boosterSpawn.boosterClone)
        {
            speedBoost.SetActive(false);
            speed *= 2;
            StartCoroutine(waitTenSeconds());
        }
        else if (collision.gameObject == clonePackage)
        {
            pickupPackage.Play();
            hint.text ="FIND THE CUSTOMER";
            Destroy(clonePackage);
            objectCreater(customer);
        }
        else if (collision.gameObject == cloneCustomer)
        {
            customerAudio.Play();
            hint.text ="FIND THE PACKAGE";
            numOfPackage++;
            packageDelivered.text = "Package Delivered: "+numOfPackage;
            Destroy(cloneCustomer);
            objectCreater(package);
        }
    }
    IEnumerator waitTenSeconds()
    {
        boostSound.Play();
        for (int i = 10; i > 0; i--)
        {
            boostTime.text = "Speed Boosted   " + i;
            yield return new WaitForSeconds(1);
        }
        boostTime.text = "";
        speed /= 2;
    }
    void objectCreater(GameObject gObject)    //package =0, customer=1
    {
        int n;
        do
        {
            n = Random.Range(1, 24);
        } while (n == except);
        if (gObject == package)
        {
            switch (n)
            {
                case 1:
                    clonePackage = Instantiate(gObject, spawner1.transform.position, Quaternion.identity);
                    except = 1;
                    break;
                case 2:
                    clonePackage = Instantiate(gObject, spawner2.transform.position, Quaternion.identity);
                    except = 2;
                    break;
                case 3:
                    clonePackage = Instantiate(gObject, spawner3.transform.position, Quaternion.identity);
                    except = 3;
                    break;
                case 4:
                    clonePackage = Instantiate(gObject, spawner4.transform.position, Quaternion.identity);
                    except = 4;
                    break;
                case 5:
                    except = 5;
                    clonePackage = Instantiate(gObject, spawner5.transform.position, Quaternion.identity);
                    break;
                case 6:
                    except = 6;
                    clonePackage = Instantiate(gObject, spawner6.transform.position, Quaternion.identity);
                    break;
                case 7:
                    except = 7;
                    clonePackage = Instantiate(gObject, spawner7.transform.position, Quaternion.identity);
                    break;
                case 8:
                    except = 8;
                    clonePackage = Instantiate(gObject, spawner8.transform.position, Quaternion.identity);
                    break;
                case 9:
                    except = 9;
                    clonePackage = Instantiate(gObject, spawner9.transform.position, Quaternion.identity);
                    break;
                case 10:
                    except = 10;
                    clonePackage = Instantiate(gObject, spawner10.transform.position, Quaternion.identity);
                    break;
                case 11:
                    except = 11;
                    clonePackage = Instantiate(gObject, spawner11.transform.position, Quaternion.identity);
                    break;
                case 12:
                    except = 12;
                    clonePackage = Instantiate(gObject, spawner12.transform.position, Quaternion.identity);
                    break;
                case 13:
                    clonePackage = Instantiate(gObject, spawner13.transform.position, Quaternion.identity);
                    except = 13;
                    break;
                case 14:
                    except = 14;
                    clonePackage = Instantiate(gObject, spawner14.transform.position, Quaternion.identity);
                    break;

                case 15:
                    except = 15;
                    clonePackage = Instantiate(gObject, spawner15.transform.position, Quaternion.identity);
                    break;
                case 16:
                    except = 16;
                    clonePackage = Instantiate(gObject, spawner16.transform.position, Quaternion.identity);
                    break;
                case 17:
                    except = 17;
                    clonePackage = Instantiate(gObject, spawner17.transform.position, Quaternion.identity);
                    break;
                case 18:
                    except = 18;
                    clonePackage = Instantiate(gObject, spawner18.transform.position, Quaternion.identity);
                    break;
                case 19:
                    except = 19;
                    clonePackage = Instantiate(gObject, spawner19.transform.position, Quaternion.identity);
                    break;
                case 20:
                    except = 20;
                    clonePackage = Instantiate(gObject, spawner20.transform.position, Quaternion.identity);
                    break;
                case 21:
                    except = 21;
                    clonePackage = Instantiate(gObject, spawner21.transform.position, Quaternion.identity);
                    break;
                case 22:
                    except = 22;
                    clonePackage = Instantiate(gObject, spawner22.transform.position, Quaternion.identity);
                    break;
                case 23:
                    except = 23;
                    clonePackage = Instantiate(gObject, spawner23.transform.position, Quaternion.identity);
                    break;
            }
        }
        else
        {
            switch (n)
            {
                case 1:
                    except = 1;
                    cloneCustomer = Instantiate(gObject, spawner1.transform.position, Quaternion.identity);
                    break;
                case 2:
                    except = 2;
                    cloneCustomer = Instantiate(gObject, spawner2.transform.position, Quaternion.identity);
                    break;
                case 3:
                    except = 3;
                    cloneCustomer = Instantiate(gObject, spawner3.transform.position, Quaternion.identity);
                    break;
                case 4:
                    except = 4;
                    cloneCustomer = Instantiate(gObject, spawner4.transform.position, Quaternion.identity);
                    break;
                case 5:
                    except = 5;
                    cloneCustomer = Instantiate(gObject, spawner5.transform.position, Quaternion.identity);
                    break;
                case 6:
                    except = 6;
                    cloneCustomer = Instantiate(gObject, spawner6.transform.position, Quaternion.identity);
                    break;
                case 7:
                    except = 7;
                    cloneCustomer = Instantiate(gObject, spawner7.transform.position, Quaternion.identity);
                    break;
                case 8:
                    except = 8;
                    cloneCustomer = Instantiate(gObject, spawner8.transform.position, Quaternion.identity);
                    break;
                case 9:
                    except = 9;
                    cloneCustomer = Instantiate(gObject, spawner9.transform.position, Quaternion.identity);
                    break;
                case 10:
                    except = 10;
                    cloneCustomer = Instantiate(gObject, spawner10.transform.position, Quaternion.identity);
                    break;
                case 11:
                    except = 11;
                    cloneCustomer = Instantiate(gObject, spawner11.transform.position, Quaternion.identity);
                    break;
                case 12:
                    except = 12;
                    cloneCustomer = Instantiate(gObject, spawner12.transform.position, Quaternion.identity);
                    break;
                case 13:
                    except = 13;
                    cloneCustomer = Instantiate(gObject, spawner13.transform.position, Quaternion.identity);
                    break;
                case 14:
                    except = 14;
                    cloneCustomer = Instantiate(gObject, spawner14.transform.position, Quaternion.identity);
                    break;
                case 15:
                    except = 15;
                    cloneCustomer = Instantiate(gObject, spawner15.transform.position, Quaternion.identity);
                    break;
                case 16:
                    except = 16;
                    cloneCustomer = Instantiate(gObject, spawner16.transform.position, Quaternion.identity);
                    break;
                case 17:
                    except = 17;
                    cloneCustomer = Instantiate(gObject, spawner17.transform.position, Quaternion.identity);
                    break;
                case 18:
                    except = 18;
                    cloneCustomer = Instantiate(gObject, spawner18.transform.position, Quaternion.identity);
                    break;
                case 19:
                    except = 19;
                    cloneCustomer = Instantiate(gObject, spawner19.transform.position, Quaternion.identity);
                    break;
                case 20:
                    except = 20;
                    cloneCustomer = Instantiate(gObject, spawner20.transform.position, Quaternion.identity);
                    break;
                case 21:
                    except = 21;
                    cloneCustomer = Instantiate(gObject, spawner21.transform.position, Quaternion.identity);
                    break;
                case 22:
                    except = 22;
                    cloneCustomer = Instantiate(gObject, spawner22.transform.position, Quaternion.identity);
                    break;
                case 23:
                    except = 23;
                    cloneCustomer = Instantiate(gObject, spawner23.transform.position, Quaternion.identity);
                    break;
            }
        }

        Debug.Log(gObject.transform.position);
    }

}
