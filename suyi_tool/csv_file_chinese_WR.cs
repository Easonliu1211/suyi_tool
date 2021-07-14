using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suyi_tool
{
    public class csv_file_chinese_WR
    {
        public string[] read_csv_file_big5(string i_file_name_path)
        {
            string[] all_csv_file_data = File.ReadAllLines(i_file_name_path, System.Text.Encoding.GetEncoding("Big5"));                      
            return all_csv_file_data;
        }

        public void write_csv_file_big5(string i_file_name_path, string[] i_read_csv_file_big5_data)
        {
            int i = 0;
            using (StreamWriter file = new StreamWriter(i_file_name_path, false, System.Text.Encoding.GetEncoding("Big5")))
            {
                for(i=0;i< i_read_csv_file_big5_data.Length;i++)
                {
                    file.Write(i_read_csv_file_big5_data[i] + "\r\n");
                }
                file.Close();
            }
        }

    }
}
