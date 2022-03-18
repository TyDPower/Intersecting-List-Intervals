namespace IntervalListIntersections
{
    public class Methods
    {
        public static List<int[]> GetIntersection(List<int[]> listA, List<int[]> listB)
        {
            //Set index to keep track of place in list
            int indexA = 0;
            int indexB = 0;

            //Create solution list
            List<int[]> intersectingIntervals = new List<int[]>();

            //Check if indexes are still in range
            while (indexA < listA.Count() && indexB < listB.Count())
            {
                //Check if there is an intercection
                if (listB[indexB][0] <= listA[indexA][1] && listB[indexB][1] >= listA[indexA][0])
                {
                    //Create intersecting range array
                    int[] intersectInterval = new int[2];

                    //Get intersecting range
                    intersectInterval[0] = Math.Max(listA[indexA][0], listB[indexB][0]);
                    intersectInterval[1] = Math.Min(listA[indexA][1], listB[indexB][1]);

                    //Push to solution list
                    intersectingIntervals.Add(intersectInterval);
                }

                //Check which value is lower to move index +1
                if (listA[indexA][1] < listB[indexB][1])
                    indexA++;
                else if (listB[indexB][1] < listA[indexA][1])
                    indexB++;
                else
                {
                    indexA++;
                    indexB++;
                }
            }
            
            //Return solution
            return intersectingIntervals;
        }
    }
}
