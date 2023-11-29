using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.RedikultsevaAA.Sprint5.Review.V11.Lib
{
    public class DataService : ISprint5Task7V11
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V11.txt";

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExist = fileInfo.Exists;

            if (fileExist)
            {
                File.Delete(pathSaveFile);
            }

            string strLine = "";
            string flag = "йцукенгшщзхъэждлорпавыфячсмитьбю";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (!flag.Contains(line[i]))
                        {
                            strLine += line[i];
                        }
                    }
                }
            }
            File.AppendAllText(pathSaveFile, strLine);
            return pathSaveFile;
        }
    }
}
