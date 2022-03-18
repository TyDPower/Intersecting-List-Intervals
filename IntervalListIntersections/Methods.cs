namespace IntervalListIntersections
{
    public class Methods
    {
        public static List<int[]> GetIntersection(List<int[]> listA, List<int[]> listB)
        {
            //Set indexes to keep track of place in list
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
            
            //Return solution as a list of int[]
            return intersectingIntervals;
        }

        public static bool TestGetIntersection(List<int[]> getIntersection, List<int[]> solutionList)
        {

            if (getIntersection.Count() == solutionList.Count())
            {
                for (var i=0; i<solutionList.Count(); i++)
                {
                    for (var j=0; j<solutionList[i].Count(); j++)
                    {
                        if (getIntersection[i][j] != solutionList[i][j])
                        {
                            Console.WriteLine("Compare Failed!");
                            return false;
                        }
                    }
                }

                Console.WriteLine("Test Passed!");
                return true;
            }

            Console.WriteLine("Count Failed!");
            return false;
        }
    }
}
