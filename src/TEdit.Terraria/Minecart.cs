namespace TEdit.Terraria;

public static class Minecart
{
    public static int[] LeftSideConnection = { -1, 1, -1, 1, 2, 1, 1, 0, 0, 2, 2, -1, 0, -1, -1, 1, 2, -1, 0, -1, -1, 1, -1, 1, -1, 1, 2, -1, 0, -1, 1, 1, 0, 2, 0, 2 };
    public static int[] RightSideConnection = { -1, 1, 1, -1, 1, 2, 0, 1, 2, 0, -1, 2, -1, 0, 1, -1, -1, 2, -1, 0, -1, 1, 1, -1, 1, -1, -1, 2, -1, 0, 1, 1, 2, 0, 2, 0 };
    public static int[] TrackType = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 2, 2, 2, 2, 2, 2 };
    public static int[][] TrackSwitchOptions = 
    {
        new int[] {0, 20},
        new int[] {12, 18, 28},
        new int[] {3, 15, 23, 25},
        new int[] {3, 12, 15, 18, 23, 25, 28},
        new int[] {10, 16, 26},
        new int[] {10, 12, 16, 18, 26, 28},
        new int[] {3, 10, 15, 16, 23, 25, 26},
        new int[] {3, 10, 12, 15, 16, 18, 23, 25, 26, 28},
        new int[] {13, 19, 29},
        new int[] {12, 13, 18, 19, 28, 29},
        new int[] {3, 6, 13, 15, 19, 23, 25, 29},
        new int[] {3, 6, 12, 13, 15, 18, 19, 23, 25, 28, 29},
        new int[] {9, 10, 13, 16, 19, 26, 29, 33, 35},
        new int[] {9, 10, 12, 13, 16, 18, 19, 26, 28, 29, 33, 35},
        new int[] {3, 6, 9, 10, 13, 15, 16, 19, 23, 25, 26, 29, 33, 35},
        new int[] {3, 6, 9, 10, 12, 13, 15, 16, 18, 19, 23, 25, 26, 28, 29, 33, 35},
        new int[] {2, 14, 22, 24},
        new int[] {2, 7, 12, 14, 18, 22, 24, 28},
        new int[] {1, 2, 3, 14, 15, 21, 22, 23, 24, 25, 30, 31},
        new int[] {1, 2, 3, 7, 12, 14, 15, 18, 21, 22, 23, 24, 25, 28, 30, 31},
        new int[] {2, 4, 10, 14, 16, 22, 24, 26},
        new int[] {2, 4, 7, 10, 12, 14, 16, 18, 22, 24, 26, 28},
        new int[] {1, 2, 3, 4, 10, 14, 15, 16, 21, 22, 23, 24, 25, 26, 30, 31},
        new int[] {1, 2, 3, 4, 7, 10, 12, 14, 15, 16, 18, 21, 22, 23, 24, 25, 26, 28, 30, 31},
        new int[] {2, 13, 14, 19, 22, 24, 29},
        new int[] {2, 7, 12, 13, 14, 18, 19, 22, 24, 28, 29},
        new int[] {1, 2, 3, 6, 13, 14, 15, 19, 21, 22, 23, 24, 25, 29, 30, 31},
        new int[] {1, 2, 3, 6, 7, 12, 13, 14, 15, 18, 19, 21, 22, 23, 24, 25, 28, 29, 30, 31},
        new int[] {2, 4, 9, 10, 13, 14, 16, 19, 22, 24, 26, 29, 33, 35},
        new int[] {2, 4, 7, 9, 10, 12, 13, 14, 16, 18, 19, 22, 24, 26, 28, 29, 33, 35},
        new int[] {1, 2, 3, 4, 6, 9, 10, 13, 14, 15, 16, 19, 21, 22, 23, 24, 25, 26, 29, 30, 31, 33, 35},
        new int[] {1, 2, 3, 4, 6, 7, 9, 10, 12, 13, 14, 15, 16, 18, 19, 21, 22, 23, 24, 25, 26, 28, 29, 30, 31, 33, 35},
        new int[] {11, 17, 27},
        new int[] {8, 11, 12, 17, 18, 27, 28, 32, 34},
        new int[] {3, 5, 11, 15, 17, 23, 25, 27},
        new int[] {3, 5, 8, 11, 12, 15, 17, 18, 23, 25, 27, 28, 32, 34},
        new int[] {10, 11, 16, 17, 26, 27},
        new int[] {8, 10, 11, 12, 16, 17, 18, 26, 27, 28, 32, 34},
        new int[] {3, 5, 10, 11, 15, 16, 17, 23, 25, 26, 27},
        new int[] {3, 5, 8, 10, 11, 12, 15, 16, 17, 18, 23, 25, 26, 27, 28, 32, 34},
        new int[] {11, 13, 17, 19, 27, 29},
        new int[] {8, 11, 12, 13, 17, 18, 19, 27, 28, 29, 32, 34},
        new int[] {3, 5, 6, 11, 13, 15, 17, 19, 23, 25, 27, 29},
        new int[] {3, 5, 6, 8, 11, 12, 13, 15, 17, 18, 19, 23, 25, 27, 28, 29, 32, 34},
        new int[] {9, 10, 11, 13, 16, 17, 19, 26, 27, 29, 33, 35},
        new int[] {8, 9, 10, 11, 12, 13, 16, 17, 18, 19, 26, 27, 28, 29, 32, 33, 34, 35},
        new int[] {3, 5, 6, 9, 10, 11, 13, 15, 16, 17, 19, 23, 25, 26, 27, 29, 33, 35},
        new int[] {3, 5, 6, 8, 9, 10, 11, 12, 13, 15, 16, 17, 18, 19, 23, 25, 26, 27, 28, 29, 32, 33, 34, 35},
        new int[] {2, 11, 14, 17, 22, 24, 27},
        new int[] {2, 7, 8, 11, 12, 14, 17, 18, 22, 24, 27, 28, 32, 34},
        new int[] {1, 2, 3, 5, 11, 14, 15, 17, 21, 22, 23, 24, 25, 27, 30, 31},
        new int[] {1, 2, 3, 5, 7, 8, 11, 12, 14, 15, 17, 18, 21, 22, 23, 24, 25, 27, 28, 30, 31, 32, 34},
        new int[] {2, 4, 10, 11, 14, 16, 17, 22, 24, 26, 27},
        new int[] {2, 4, 7, 8, 10, 11, 12, 14, 16, 17, 18, 22, 24, 26, 27, 28, 32, 34},
        new int[] {1, 2, 3, 4, 5, 10, 11, 14, 15, 16, 17, 21, 22, 23, 24, 25, 26, 27, 30, 31},
        new int[] {1, 2, 3, 4, 5, 7, 8, 10, 11, 12, 14, 15, 16, 17, 18, 21, 22, 23, 24, 25, 26, 27, 28, 30, 31, 32, 34},
        new int[] {2, 11, 13, 14, 17, 19, 22, 24, 27, 29},
        new int[] {2, 7, 8, 11, 12, 13, 14, 17, 18, 19, 22, 24, 27, 28, 29, 32, 34},
        new int[] {1, 2, 3, 5, 6, 11, 13, 14, 15, 17, 19, 21, 22, 23, 24, 25, 27, 29, 30, 31},
        new int[] {1, 2, 3, 5, 6, 7, 8, 11, 12, 13, 14, 15, 17, 18, 19, 21, 22, 23, 24, 25, 27, 28, 29, 30, 31, 32, 34},
        new int[] {2, 4, 9, 10, 11, 13, 14, 16, 17, 19, 22, 24, 26, 27, 29, 33, 35},
        new int[] {2, 4, 7, 8, 9, 10, 11, 12, 13, 14, 16, 17, 18, 19, 22, 24, 26, 27, 28, 29, 32, 33, 34, 35},
        new int[] {1, 2, 3, 4, 5, 6, 9, 10, 11, 13, 14, 15, 16, 17, 19, 21, 22, 23, 24, 25, 26, 27, 29, 30, 31, 33, 35},
        new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35}
    };    
}