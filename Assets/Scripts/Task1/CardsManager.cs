using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardStackManager : MonoBehaviour
{
    public GameObject cardPrefab;
    public Transform stackATransform;
    public Transform stackBTransform;
    public int numberOfCards = 144;
    public float verticalOffset = 0.05f;
    public float timeBetweenMoves = 1f;
    public float moveDuration = 2f;

    private Stack<GameObject> stackA = new Stack<GameObject>();
    private Stack<GameObject> stackB = new Stack<GameObject>();

    void Start()
    {
        // Spawn initial stack A
        for (int i = 0; i < numberOfCards; i++)
        {
            GameObject card = Instantiate(cardPrefab, stackATransform);
            float Offset = verticalOffset * i;
            card.transform.localPosition = new Vector3(Offset, Offset, 0);

            stackA.Push(card);
        }

        // Start the coroutine that moves cards from A to B
        StartCoroutine(MoveCardRoutine());
    }

    IEnumerator MoveCardRoutine()
    {
        int moveCount = 0;

        while (moveCount < numberOfCards && stackA.Count > 0)
        {
            yield return new WaitForSeconds(timeBetweenMoves);

            GameObject cardToMove = stackA.Pop();

            // Reparent to stackB
            cardToMove.transform.SetParent(stackBTransform);

            // Compute target position based on current count in stackB
            int i = stackB.Count;
            float Offset = verticalOffset * i;
            Vector3 startPos = cardToMove.transform.position;
            Vector3 endPos = stackBTransform.position + new Vector3(Offset, Offset, 0);

            // Animate movement
            // We can ofc use animator and make an animation for the card, but this is more scalable specially if we move the stacks holders
            float t = 0f;
            while (t < moveDuration)
            {
                t += Time.deltaTime;
                float progress = Mathf.Clamp01(t / moveDuration);
                cardToMove.transform.position = Vector3.Lerp(startPos, endPos, progress);
                yield return null;
            }

            // Snap to final position
            cardToMove.transform.position = endPos;

            // Add to stackB
            stackB.Push(cardToMove);

            moveCount++;
        }

        Debug.Log("Card move routine completed. Total cards moved: " + moveCount);
    }

}

