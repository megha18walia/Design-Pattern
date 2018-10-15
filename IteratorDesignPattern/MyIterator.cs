using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern
{
    public class MyIterator : IIterator
    {
        IAggregate aggregate = null;
        int _currentIndex = 0;

        public MyIterator(IAggregate aggregate)
        {
            this.aggregate = aggregate;
        }

        public string FirstItem
        {
            get
            {
                _currentIndex = 0;
                return aggregate[_currentIndex];

            }
        }
        public string NextItem
        {
            get
            {
                _currentIndex = _currentIndex + 1;
                if (!IsDone)
                {
                    return aggregate[_currentIndex];
                }
                else
                {
                    return string.Empty;
                }
            }
        }
        public string CurrentItem
        {
            get
            {
                return aggregate[_currentIndex];
            }
        }
        public bool IsDone
        {
            get
            {
                return _currentIndex == aggregate.count;
            }
        }
    }
}
