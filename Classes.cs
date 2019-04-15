using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoProject_SoundsPacking_
{
    class Audio
    {
        string _name; //filename.mp3
        int _secDuration; // file duration by seconds

        public string name //setter and getter for filename
        {
            get { return _name; }
            set { _name = value; }
        }

        public int secDuration //setter and getter for duration
        {
            get { return _secDuration; }
            set { _secDuration = value; }
        }
    }

    class Folder : IComparable<Folder>
    {
        string _name; //Folder name
        int _secDuration; // Folder duration by seconds
        public List<Audio> audiosList = new List<Audio>();

        public string name //setter and getter for Folder name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int secDuration //setter and getter for duration of folder
        {
            get { return _secDuration; }
            set { _secDuration = value; }
        }

        public int CompareTo(Folder obj)
        {
            if (this.secDuration > obj.secDuration) return 1;
            else if (this.secDuration < obj.secDuration) return -1;
            else return 0;
        }
    }

    public class PriorityQueue<T> where T : IComparable<T>
    {
        private List<T> data;

        public PriorityQueue()
        {
            this.data = new List<T>();
        }

        public void Enqueue(T item)
        {
            data.Add(item);
            int ci = data.Count - 1; // child index; start at end
            while (ci > 0)
            {
                int pi = (ci - 1) / 2; // parent index
                if (data[ci].CompareTo(data[pi]) >= 0) break; // child item is larger than (or equal) parent so we're done
                T tmp = data[ci]; data[ci] = data[pi]; data[pi] = tmp;
                ci = pi;
            }
        }

        public T Dequeue()
        {
            // assumes pq is not empty; up to calling code
            int li = data.Count - 1; // last index (before removal)
            T frontItem = data[0];   // fetch the front
            data[0] = data[li];
            data.RemoveAt(li);

            --li; // last index (after removal)
            int pi = 0; // parent index. start at front of pq
            while (true)
            {
                int ci = pi * 2 + 1; // left child index of parent
                if (ci > li) break;  // no children so done
                int rc = ci + 1;     // right child
                if (rc <= li && data[rc].CompareTo(data[ci]) < 0) // if there is a rc (ci + 1), and it is smaller than left child, use the rc instead
                    ci = rc;
                if (data[pi].CompareTo(data[ci]) <= 0) break; // parent is smaller than (or equal to) smallest child so done
                T tmp = data[pi]; data[pi] = data[ci]; data[ci] = tmp; // swap parent and child
                pi = ci;
            }
            return frontItem;
        }

        public T Peek()
        {
            T frontItem = data[0];
            return frontItem;
        }

        public int Count()
        {
            return data.Count;
        }

        public List<T> ToList()
        {
            return data;
        }
    } // PriorityQueue
}
