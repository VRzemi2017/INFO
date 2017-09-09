using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ResultManager : MonoBehaviour {

    private ScoreType score = ScoreType.SCORE_A;
    public ScoreType Score { get { return score; } }

    private List<string> comment = new List<string>();
    public string[] Comment { get { return comment.ToArray(); } }

    public int GemCount { get { return 4; } }
    public int DamageCount { get { return 6; } }
    public int TeleportCount { get { return 42; } }

    [SerializeField ]private List<SpotControl> spots = new List<SpotControl>();
    public SpotControl[] Spots { get { return spots.ToArray(); } }

    public enum ScoreType
    {
        SCORE_D,
        SCORE_C,
        SCORE_B,
        SCORE_A,
        SCORE_S,
        SCORE_SS,
    }

    void Start()
    {
        comment.Add("yeah1");
        comment.Add("yeah2");
    }
}
