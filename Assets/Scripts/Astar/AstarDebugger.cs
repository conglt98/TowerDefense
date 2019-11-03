using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstarDebugger : MonoBehaviour
{
   
    private TileScript start, goal;

    [SerializeField]
    private Sprite blankTile;

    [SerializeField]
    private GameObject arrowPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ClickTile();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Astar.GetPath(start.GridPosition);
        }
    }

    private void ClickTile()
    {
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
           
            if (hit.collider != null)
            {
              
                TileScript tmp = hit.collider.GetComponent<TileScript>();

                if (tmp != null)
                {
                    if (start == null)
                    {
                        start = tmp;
                        start.SpriteRenderer.sprite = blankTile;
                        start.Debugging = true;
                        start.SpriteRenderer.color = Color.green;
                    }
                    else if (goal == null)
                    {
                        goal = tmp;
                        goal.SpriteRenderer.sprite = blankTile;
                        goal.Debugging = true;
                        goal.SpriteRenderer.color = new Color32(255, 0, 0, 255);

                    }
                }
            }

        }
    }

    public void DebugPath(HashSet<Node> openList)
    {
        foreach (Node node in openList)
        {
            if (node.TileRef!=start)
            {
                node.TileRef.SpriteRenderer.color = Color.cyan;
                node.TileRef.SpriteRenderer.sprite = blankTile;
            }

            PointToParent(node, node.TileRef.WorldPosition);
        }
    }

    private void PointToParent(Node node, Vector2 position)
    {
        if (node.Parent != null )
        {
            GameObject arrow = (GameObject)Instantiate(arrowPrefab, position, Quaternion.identity);


            //Right
            if (node.GridPosition.X < node.Parent.GridPosition.X &&
                node.GridPosition.Y == node.Parent.GridPosition.Y)
            {
                arrow.transform.eulerAngles = new Vector3(0, 0, 0);
            }//Top right
            else if (node.GridPosition.X < node.Parent.GridPosition.X &&
                node.GridPosition.Y > node.Parent.GridPosition.Y)
            {
                arrow.transform.eulerAngles = new Vector3(0, 0, 45);
            }else if (node.GridPosition.X < node.Parent.GridPosition.X &&
                node.GridPosition.Y < node.Parent.GridPosition.Y)
            {
                arrow.transform.eulerAngles = new Vector3(0, 0, -45);
            }
            else if (node.GridPosition.X == node.Parent.GridPosition.X &&
               node.GridPosition.Y > node.Parent.GridPosition.Y)
            {
                arrow.transform.eulerAngles = new Vector3(0, 0, 90);
            }
            else if (node.GridPosition.X == node.Parent.GridPosition.X &&
              node.GridPosition.Y < node.Parent.GridPosition.Y)
            {
                arrow.transform.eulerAngles = new Vector3(0, 0, -90);
            }
            else if (node.GridPosition.X > node.Parent.GridPosition.X &&
              node.GridPosition.Y > node.Parent.GridPosition.Y)
            {
                arrow.transform.eulerAngles = new Vector3(0, 0, 135);
            }
            else if (node.GridPosition.X > node.Parent.GridPosition.X &&
              node.GridPosition.Y == node.Parent.GridPosition.Y)
            {
                arrow.transform.eulerAngles = new Vector3(0, 0, 180);
            }
            else if (node.GridPosition.X > node.Parent.GridPosition.X &&
              node.GridPosition.Y < node.Parent.GridPosition.Y)
            {
                arrow.transform.eulerAngles = new Vector3(0, 0, 225);
            }
        }

        
    }
}
