using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : MonoBehaviour
{
    public Transform towerParent;
    public int currentTower = 0;
    public GameObject[] towers;

    private void OnDrawGizmos()
    {
        Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(mouseRay.origin, mouseRay.origin + mouseRay.direction * 1000f);
    }

    void Update()
    {
        Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(mouseRay, out hit))
        {
            Placeable p = hit.collider.GetComponent<Placeable>();
            if (p && p.isAvaliable)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    GameObject towerPrefab = towers[currentTower];
                    GameObject tower = Instantiate(towerPrefab, towerParent);
                    tower.transform.position = p.GetPivotPoint();
                    p.isAvaliable = false;
                }
            }
        }
    }

    public void SelectTower(int tower)
    {
        if (tower >= 0 && tower < towers.Length)
        {
            currentTower = tower;
        }
    }
}
