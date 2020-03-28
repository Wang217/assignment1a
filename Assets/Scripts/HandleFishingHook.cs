using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleFishingHook : MonoBehaviour {
    private LineRenderer lineRenderer;

    public Transform originPoint;//Point where line connects the rod.
    public Transform endPoint;//End of the line(where the hook goes).

    private float currentDist;
    private float dist;
    private float initialEndPointY;

    public float fishingLineSpeed = .2f;
    public float fishineLineWidth = .45f;

    private int pointScore;

    void Start() {
        initialEndPointY = endPoint.position.y;
        InitFishingLine();
    }

    void Update() {
        if (Input.GetKey(KeyCode.Space)) {
            if (endPoint.transform.position.y > -6) { 
                endPoint.position = new Vector2(endPoint.transform.position.x, endPoint.transform.position.y - fishingLineSpeed);
            }
        } else if (endPoint.position.y < initialEndPointY) {
            endPoint.position = new Vector2(endPoint.transform.position.x, endPoint.transform.position.y + fishingLineSpeed);
        }
        DrawFishingLine();
    }

    private void InitFishingLine() {//Line renderer initailaization. 
        lineRenderer = GetComponentInChildren<LineRenderer>();
        lineRenderer.SetPosition(0,originPoint.position);
        lineRenderer.SetWidth(fishineLineWidth, fishineLineWidth);

        dist = Vector3.Distance(originPoint.position,endPoint.position);
    }

    private void DrawFishingLine() {//Handles drawing of the fishing line (redraws every fixed second).
        dist = Vector3.Distance(originPoint.position, endPoint.position);
        currentDist += 1f;
        float x = Mathf.Lerp(0, dist, currentDist);
        Vector3 point = x * Vector3.Normalize(endPoint.position-originPoint.position) + originPoint.position;
        lineRenderer.SetPosition(1, point);
    }

    public void SetPointScore(int score) {
        pointScore += score;
    }

    public int GetPointScore() {
        return pointScore;
    }
}
