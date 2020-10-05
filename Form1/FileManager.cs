/************
 * author: Zach Brown
 * date: 2/11/2018
 * assignment: Phase 3 : Project 1
 * professor: Eric Baker
 * course: IGME 201
 * filename: FileManager.cs
 * description: A program which has the ability to save, load, and clear data. This is programmed specifically for reading the 
 * students and detention programs, however, this program can read any type of JSON file. The data from the students and detention C# files are
 * places into a table on form1.
 ***********/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Form1
{
    class FileManager
    {
        public FileStream getFile { get; set; }
        public JavaScriptSerializer serializer { get; set; }


        public bool LoadJsonFile(string jsonLoad, out List<Student> studentLoad)
        {
            getFile = File.OpenRead(jsonLoad);

            //
            if (getFile == null)
            {
                studentLoad = null;
                getFile.Close();
                return false;
            }
            

            StreamReader reader = new StreamReader(getFile);
            string loadString = reader.ReadToEnd();

            serializer = new JavaScriptSerializer();

            studentLoad = serializer.Deserialize < List < Student >> (loadString);

            getFile.Close();
            
            return true;

        }

        public bool SaveJsonFile(string jsonSave, List<Student> studentSave)
        {
            getFile = File.OpenWrite(jsonSave);

            //
            if (getFile == null)
            {
                getFile.Close();
                return false;
            }

            StreamWriter writer = new StreamWriter(getFile);

            serializer = new JavaScriptSerializer();

            string saveString = serializer.Serialize(studentSave);

            writer.Write(saveString);
            writer.Flush();
            writer.Close();
            getFile.Close();

            return true;
        }

    }
}
