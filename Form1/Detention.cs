using System;

namespace Form1
{
    public struct Detention
    {
        //  Date detention was given
        DateTime date;
        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }

        //  Reason for receiving detention
        string reason;
        public string Reason
        {
            get
            {
                return reason;
            }
            set
            {
                reason = value;
            }
        }

        //  Punishment given
        string punishment;
        public string Punishment
        {
            get
            {
                return punishment;
            }
            set
            {
                punishment = value;
            }
        }

        //  Detention issued by
        string issuedBy;
        public string IssuedBy
        {
            get
            {
                return issuedBy;
            }
            set
            {
                issuedBy = value;
            }
        }

        //  Points taken from house
        int pointsTaken;
        public int PointsTaken
        {
            get
            {
                return pointsTaken;
            }
            set
            {
                pointsTaken = value;
            }
        }
    }
}
