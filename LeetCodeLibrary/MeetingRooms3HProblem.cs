// Meeting Rooms III (Hard) Url: https://leetcode.com/problems/meeting-rooms-iii/
//Based on this solution: https://leetcode.com/problems/meeting-rooms-iii/solutions/4745979/c-solution-for-meeting-rooms-iii-problem
/*
 Intuition
The intuition behind this solution is to efficiently allocate meetings to rooms by considering the availability time of each room. It sorts the meetings based on their start times and iterates through them, checking the availability of rooms. If a room is available, the meeting is assigned to that room; otherwise, the meeting is scheduled in the room with the earliest availability time.

Approach
Sort the meetings based on their start times.
Iterate through the sorted meetings.
For each meeting, check the availability of rooms. If an available room is found, assign the meeting to that room and update its availability time.
If no available room is found, schedule the meeting in the room with the earliest availability time and update the availability time.
Track the count of meetings for each room.
Find the room with the maximum meeting count and return its index.
Complexity
Time complexity:
The time complexity is O(n log n) due to the sorting of meetings, where n is the number of meetings. The subsequent iterations involve constant time operations.

Space complexity:
The space complexity is O(n) as we use arrays to store room availability times and meeting counts, both proportional to the number of rooms (n). Additionally, the priority queue used in the previous Java solution is replaced by arrays, leading to similar space complexity.
 */
public class MeetingRooms3HProblem
{
    public int MostBooked(int n, int[][] meetings)
    {
        long[] roomAvailabilityTime = new long[n];
        int[] meetingCount = new int[n];

        Array.Sort(meetings, (a, b) => a[0] - b[0]);

        for (int i = 0; i < meetings.Length; i++)
        {
            int start = meetings[i][0], end = meetings[i][1];
            long minRoomAvailabilityTime = long.MaxValue;
            int minAvailableTimeRoom = 0;
            bool foundUnusedRoom = false;

            for (int j = 0; j < n; j++)
            {
                if (roomAvailabilityTime[j] <= start)
                {
                    foundUnusedRoom = true;
                    meetingCount[j]++;
                    roomAvailabilityTime[j] = end;
                    break;
                }

                if (minRoomAvailabilityTime > roomAvailabilityTime[j])
                {
                    minRoomAvailabilityTime = roomAvailabilityTime[j];
                    minAvailableTimeRoom = j;
                }
            }

            if (!foundUnusedRoom)
            {
                roomAvailabilityTime[minAvailableTimeRoom] += end - start;
                meetingCount[minAvailableTimeRoom]++;
            }
        }

        int maxMeetingCount = 0, maxMeetingCountRoom = 0;
        for (int i = 0; i < n; i++)
        {
            if (meetingCount[i] > maxMeetingCount)
            {
                maxMeetingCount = meetingCount[i];
                maxMeetingCountRoom = i;
            }
        }

        return maxMeetingCountRoom;
    }


    // Based on the solution from https://www.youtube.com/watch?v=2VLwjvODQbA 
    // But Not working for all test cases
    //////////////////////////////////////////
    //public int MostBooked(int n, int[][] meetings)
    //{
    //    Array.Sort(meetings, (a, b) => a[0] - b[0]);

    //    var available = new PriorityQueue<long, long>();
    //    for (int i = 0; i < n; i++)
    //        available.Enqueue(i, i);
    //    var used = new PriorityQueue<Tuple<long, long>, long>();
    //    var count = new int[n];

    //    foreach (var item in meetings)
    //    {
    //        var start = item[0];
    //        long end = item[1];
    //        while (used.Count > 0 && start >= used.Peek().Item1)
    //        {
    //            var (endTime, room) = used.Dequeue();
    //            available.Enqueue(room, room);
    //        }

    //        if (available.Count <= 0)
    //        {
    //            var (endTime, room) = used.Dequeue();
    //            end = endTime + (end - start);
    //            available.Enqueue(room, room);
    //        }

    //        long usingRoom = available.Dequeue();
    //        used.Enqueue(new Tuple<long, long>(end, usingRoom), end);
    //        count[usingRoom]++;
    //    }

    //    return Array.IndexOf(count, count.Max());
    //}
}

