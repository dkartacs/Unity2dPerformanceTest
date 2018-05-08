using UnityEngine;

public static class GameController {

    private static float minFps = 20;
    private static float maxRunTime = 120;

    public static float MinFps {
        get {
            return minFps;
        }
        set {
            minFps = value;
        }
    }

    public static float MaxRunTime {
        get {
            return maxRunTime;
        }
        set {
            maxRunTime = value;
        }
    }
}
