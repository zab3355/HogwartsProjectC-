using System;
using System.Collections.Generic;
using System.Linq;

namespace Form1
{
    public enum HogwartsHouse
    {
        Gryffindor,
        Hufflepuff,
        Ravenclaw,
        Slytherin
    }

    public enum HogwartsSubject
    {
        Astronomy,
        Charms,
        DefenceAgainstTheDarkArts,
        Flying,
        Herbology,
        HistoryOfMagic,
        MuggleStudies,
        Potions,
        Transfiguration,
        Alchemy,
        Apparition,
        Arithmancy,
        CareOfMagicalCreatures,
        Divination,
        StudyOfAncientRunes,
        AncientStudies,
        Art,
        FrogChoir,
        GhoulStudies,
        MagicalTheory,
        MuggleArt,
        Music,
        MuggleMusic,
        Orchestra,
        Xylomancy
    }

    //  None = no grade has been given yet
    public enum GradeScale
    {
        None,
        Outstanding,
        ExceedsExpectations,
        Acceptable,
        Poor,
        Dreadful,
        Troll
    }

    public struct SubjectGrade
    {
        HogwartsSubject subject;
        public HogwartsSubject Subject
        {
            get
            {
                return subject;
            }
            set
            {
                subject = value;
            }
        }

        GradeScale grade;
        public GradeScale Grade
        {
            get
            {
                return grade;
            }
            set
            {
                grade = value;
            }
        }
    }

    class Student
    {
        //  The student's full name
        string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        //  The Hogwarts house this student belongs to
        HogwartsHouse house;
        public HogwartsHouse House
        {
            get
            {
                return house;
            }
            set
            {
                house = value;
            }
        }

        //  The studnet's date of birth
        DateTime dateOfBirth;
        public DateTime DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }
            set
            {
                dateOfBirth = value;
            }
        }

        //  The current year the stuend is in (0 - 7)
        //      0 = registered to join when of age
        int yearLevel;
        public int YearLevel
        {
            get
            {
                return yearLevel;
            }
            set
            {
                yearLevel = value;
            }
        }

        //  The date the student graduated from Hogwarts
        //      If not set the student has not yet finished school
        DateTime dateOfGraduation;
        public DateTime DateOfGraduation
        {
            get
            {
                return dateOfGraduation;
            }
            set
            {
                dateOfGraduation = value;
            }
        }

        //  Made the assumstion that a student can't skip a grade
        //      and no transfer students
        //  Not covered in the books so it can never happen
        //  A list of all the subjects the student has taken
        //      grouped by year level
        List<List<SubjectGrade>> subjects = new List<List<SubjectGrade>>();
        public List<List<SubjectGrade>> Subjects
        {
            get
            {
                return subjects;
            }
            set
            {
                subjects = value;
            }
        }

        //  Very messy Dictionary that can handle skipping a year or transfer students
        /*Dictionary<HogwartsSubject, Dictionary<int, GradeScale>> subjects;
        public Dictionary<string, Dictionary<string, string>> Subjects
        {
            set
            {
                subjects = value.ToDictionary(item => (HogwartsSubject)Enum.Parse(typeof(HogwartsSubject), item.Key),
                    item => item.Value.ToDictionary(childItem => Int32.Parse(childItem.Key), childItem => (GradeScale)Enum.Parse(typeof(GradeScale), childItem.Value)));
            }
        }*/

        //  Has the student provided a signed Hogsmeaded Permission Form
        bool hasHogsmeadePermissionForm = false;
        public bool HasHogsmeadePermissioniForm
        {
            get
            {
                return hasHogsmeadePermissionForm;
            }
            set
            {
                hasHogsmeadePermissionForm = value;
            }
        }

        //  A list of all the detentions the student has recived while at Hogwarts
        List<Detention> detentions = new List<Detention>();
        public List<Detention> Detentions
        {
            get
            {
                return detentions;
            }
            set
            {
                detentions = value;
            }
        }
    }
}
