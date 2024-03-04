using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class StackableController : MonoBehaviour
{
    public static StackableController Instance { get; private set; }


    public List<GameObject> collectObject = new List<GameObject>();

    [SerializeField] private Transform _valuablesParent;
    private float distanceBetweenElements = 1.0f;

    private void Awake()
    {
        Instance = Instance == null ? this : Instance;
        ArrangeElements();
    }

    public void MoveObjectElement()
    {
        for (int i = 1; i < collectObject.Count; i++)
        {
            Vector3 pos = collectObject[i].transform.localPosition;
            pos.x = collectObject[i - 1].transform.localPosition.x;
            collectObject[i].transform.DOLocalMove(pos, 0.15f);
        }
    }
    public void MoveOrigin()
    {
        for (int i = 1; i < collectObject.Count; i++)
        {
            Vector3 pos = collectObject[i].transform.localPosition;
            pos.x = collectObject[0].transform.localPosition.x;
            collectObject[i].transform.DOLocalMove(pos, 0.35f);
        }
    }
    public void ArrangeElements()
    {
        if (collectObject.Count == 0) return;

        Vector3 currentPosition = collectObject[0].transform.position;
        currentPosition.y += 1.0f;
        for (int i = 1; i < collectObject.Count; i++)
        {
            currentPosition.z -= distanceBetweenElements;
            //collectObject[i].transform.position = new Vector3(currentPosition.x,currentPosition.y , currentPosition.z);
            collectObject[i].transform.DOMove(new Vector3(currentPosition.x, currentPosition.y, currentPosition.z), 0.2f)
                .OnComplete(() =>
                {
                    currentPosition = collectObject[i].transform.position;
                });

        }
    }
    public void StackPool()
    {
        collectObject.Add(collectObject[1]);
        collectObject.RemoveAt(1);
        ArrangeElements();
    }
}
