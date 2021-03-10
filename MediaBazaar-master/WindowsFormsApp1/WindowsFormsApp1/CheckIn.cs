using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazar
{
    public class CheckIn
    {
        public delegate void CheckInEventHandler(int userId);
        public event CheckInEventHandler CheckInEvent;

        public void CheckInEmployee(int userId)
        {
            OnCheckIn(userId);
        }

        protected virtual void OnCheckIn(int userId)
        {
            if (CheckInEvent != null)
            {
                CheckInEvent(userId);
            }
        }
    }
}
