using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ResultManager : MonoBehaviour {

    private ScoreType score = ScoreType.SCORE_D;
    public ScoreType Score { get { return score; } }

    private List<string> comment = new List<string>();
    public string[] Comment { get { return comment.ToArray(); } }

    public int GemCount { get { return 0; } }
    public int DamageCount { get { return 0; } }
    public int TeleportCount { get { return 0; } }

    private List<SpotControl> spots = new List<SpotControl>();
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
        comment.Add("yeah");

        spots.Add(new SpotControl());
    }
}
