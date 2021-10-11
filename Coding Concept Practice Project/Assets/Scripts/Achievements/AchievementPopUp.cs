using System.Collections;
using TMPro;
using UnityEngine;

public class AchievementPopUp : MonoBehaviour
{
    private static AchievementPopUp _achievementPopUp;
    
    public TMP_Text popUpTitle, popUpDescription;
    public Vector3 startPosition, offscreenPosition;
    public float offscreenYAdj;
    public float moveSpeed = 10f;
    public float movePauseTime = 2f;

    [Header("Set Dynamically")] public bool bIsAlreadyPopping = false;

    // Use this for initialization
    void Start()
    {
        Achievement_PopUp = this;

        startPosition = transform.position;
        offscreenPosition = startPosition;
        offscreenPosition.y += offscreenYAdj;
        transform.position = offscreenPosition;
    }


    public void PopUp(string achievementName, string achievementDescription)
    {
        if (!bIsAlreadyPopping)
        {
            bIsAlreadyPopping = true;

            popUpTitle.text = achievementName;
            popUpDescription.text = achievementDescription;
            transform.position = offscreenPosition;

            StartCoroutine(MoveToPosition());
        }
        else
        {
            Debug.Log("Playing two achievements at a time");
            StartCoroutine(WaitYourTurn());
        }
    }


    IEnumerator WaitYourTurn()
    {
        while (bIsAlreadyPopping)
        {
            yield return new WaitForSeconds(0.5f);
        }
    }


    IEnumerator MoveToPosition()
    {
        float step = (moveSpeed / (offscreenPosition - startPosition).magnitude * Time.fixedDeltaTime);
        float t = 0;
        float u;
        while (t <= 1.0f)
        {
            t += step;
            u = 1 - (1 - t) * (1 - t); // This does some fancy easing on the Lerp
            transform.position = Vector3.LerpUnclamped(offscreenPosition, startPosition, u);
            yield return new WaitForFixedUpdate();
        }

        transform.position = startPosition;

        yield return new WaitForSeconds(movePauseTime);

        t = 0;
        while (t <= 1.0f)
        {
            t += step;
            u = t * t; // This does some fancy easing on the Lerp
            transform.position = Vector3.Lerp(startPosition, offscreenPosition, u);
            yield return new WaitForFixedUpdate();
        }

        transform.position = offscreenPosition;

        bIsAlreadyPopping = false;
    }

    static private AchievementPopUp Achievement_PopUp
    {
        get
        {
            if (_achievementPopUp == null)
            {
                Debug.LogError("AchievementPopUp:S getter - Attempt to get value of S before it has been set.");
                return null;
            }

            return _achievementPopUp;
        }
        set
        {
            if (_achievementPopUp != null)
            {
                Debug.LogError("AchievementPopUp:S setter - Attempt to set S when it has already been set.");
            }

            _achievementPopUp = value;
        }
    }


    static public void ShowPopUp(string achievementName, string achievementDescription = "")
    {
        Achievement_PopUp.PopUp(achievementName, achievementDescription);
    }

}