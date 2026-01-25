// Defense/GridSystem.cs

using UnityEngine;
using System.Collections.Generic;

public class GridSystem : MonoBehaviour
{
    public static GridSystem Instance { get; private set; }
    
    private GameConfig config;
    private Vector3[,] gridPositions;
    private Dictionary<Vector3, Vector3[]> pathCache;
    private List<Vector3> borderPositions;
    
    void Awake()
    {
        Instance = this;
    }
    
    public void Initialize(GameConfig gameConfig)
    {
        config = gameConfig;
        // TODO: gridSize × gridSize 그리드 생성
        gridPositions = new Vector3[10, 10];
        for (int x = 0; x < 10; x++)
        {
            for (int y = 0; y < 10; y++)
            {
                gridPositions[x, y] = new Vector3(x, 0, y);
            }
        }
        // TODO: 외곽 테두리 포지션 리스트 생성
        borderPositions = new List<Vector3>();
        // TODO: 모든 외곽 → 중앙 경로 계산 및 캐싱
        //bottom and top
        for (int x = 0; x < 10; x++)
        {
            borderPositions.Add(gridPositions[x, 0]);   // bottom
            borderPositions.Add(gridPositions[x, 9]);   // top
        }
        //left and right
        for (int y = 0; y < 10; y++)
        {
            borderPositions.Add(gridPositions[0, y]);   // left
            borderPositions.Add(gridPositions[9, y]);   // right
        }

        pathCache = new Dictionary<Vector3, Vector3[]>();
        Vector3 center = new Vector3(5, 0, 5);
        foreach (Vector3 borderPos in borderPositions)
        {
            pathCache[borderPos] = CalculatePath(borderPos, center);
        }
    }
    
    public Vector3 GetRandomBorderPosition()
    {
        // TODO: borderPositions에서 랜덤 선택
        int randomIndex = Random.Range(0, borderPositions.Count);
        return Vector3.zero;
    }
    
    public Vector3[] GetPath(Vector3 startPos)
    {
        // TODO: pathCache에서 경로 반환
        if (pathCache.ContainsKey(startPos))
        {
            return pathCache[startPos];
        }
        return null;
    }
    
    private Vector3[] CalculatePath(Vector3 start, Vector3 center)
    {
        // TODO: 사각형 경로 계산
        //
        // 알고리즘:
        // 1. start가 어느 변(위/오른/아래/왼쪽)에 있는지 판단
        // 2. 해당 변을 따라 코너까지 이동 포인트 생성
        // 3. 다음 변으로 전환하며 중앙 방향으로 한 칸씩 이동
        // 4. 중앙 도달 시까지 반복
        //
        // 예시: start = (0, 5) [왼쪽 변]
        // path = [(0,5) → (0,4) → ... → (0,0) [왼쪽 변]
        //         → (1,0) → ... → (5,0) [아래 변]
        //         → (5,1) → ... → (5,5) [중앙 도착]]
        List<Vector3> path = new List<Vector3>();
        if (start.x == 0)
        {
            for (int y = (int)start.z; y >= 0; y--)
            {
                path.Add(new Vector3(0, 0, y));
            }
            for (int x = 1; x <= 5; x++)
            {
                path.Add(new Vector3(x, 0, 0));
            }
            for (int y = 1; y <= 5; y++)
            {
                path.Add(new Vector3(5, 0, y));
            }
        }
        else if (start.x == 9)
        {
            for (int y = (int)start.z; y >= 0; y--)
            {
                path.Add(new Vector3(9, 0, y));
            }
            for (int x = 8; x >= 5; x--)
            {
                path.Add(new Vector3(x, 0, 0));
            }
            for (int y = 1; y <= 5; y++)
            {
                path.Add(new Vector3(5, 0, y));
            }
        }
        else if (start.z == 0)
        {
            for (int x = (int)start.x; x <= 9; x++)
            {
                path.Add(new Vector3(x, 0, 0));
            }
            for (int y = 1; y <= 5; y++)
            {
                path.Add(new Vector3(9, 0, y));
            }
            for (int x = 8; x >= 5; x--)
            {
                path.Add(new Vector3(x, 0, 5));
            }
        }
        else if (start.z == 9)
        {
            for (int x = (int)start.x; x <= 9; x++)
            {
                path.Add(new Vector3(x, 0, 9));
            }
            for (int y = 8; y >= 5; y--)
            {
                path.Add(new Vector3(9, 0, y));
            }
            for (int x = 8; x >= 5; x--)
            {
                path.Add(new Vector3(x, 0, 5));
            }
        }
        return null;
    }
}