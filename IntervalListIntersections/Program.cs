using IntervalListIntersections;

List<int[]> listA1 = new List<int[]>
{
    new int[] { 0, 2 },
    new int[] { 5, 10 },
    new int[] { 13, 23 },
    new int[] { 24, 25 },
};

List<int[]> listA2 = new List<int[]>
{
    new int[] { 1, 5 },
    new int[] { 8, 12 },
    new int[] { 15, 24 },
    new int[] { 25, 26 },
};

List<int[]> listB1 = new List<int[]>
{
    new int[] { 1, 3 },
    new int[] { 5, 9 },
};

List<int[]> listB2 = new List<int[]>();

List<int[]> listC1 = new List<int[]>
{
    new int[] { 1, 7 },
};

List<int[]> listC2 = new List<int[]>
{
    new int[] { 3, 10 },
};

Methods.GetIntersection(listA1, listA2);