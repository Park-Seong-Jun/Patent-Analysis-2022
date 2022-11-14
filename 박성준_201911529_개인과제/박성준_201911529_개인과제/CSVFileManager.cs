using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Data;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace 박성준_201911529_개인과제
{
    public class JsonFileManager
    {
        //all of these variables are private. not open to the external
        private string fileName;    //file to parse
        private string[] header;    //all column names
        private ArrayList rows = new ArrayList();   //all of the records in a csv file

        //given a file path, this function loads headers and rows
        public JsonFileManager(string filePath)
        {

            this.fileName = Path.GetFileName(filePath);


            string[] record = File.ReadAllLines(filePath, Encoding.UTF8);

            //데이터 sequence는 우리가 이미 알고 있어야 함. 
            //첫번째 row는 header, 즉 column 명을 가지고 있음
            this.header = this.ParseRecord(record, 0);
            //두번째 row부터는 실제 record. 
            //이차원배열 쓸수도 있지만, 더 좋은 객체가 있는데!
            //차곡차곡 ArrayList 객체에 저장함.
            

            for (int i = 0; i < record.Length; i++)
            {
                string[] values = this.ParseRecord(record, i);
                rows.Add(values);
            }


        }


        private string[] ParseRecord(string[] record, int rowNo)
        {
            string row = record[rowNo];

            //comma로 문자열을 separation해서 배열 객체 참조값을 return.
            string[] values = row.Split(",".ToCharArray());

            for (int i = 0; i< values.Length; i++)
            {
                values[i] = values[i].Replace("\"", "");
            }

            return values;
        }


        //when requested, a datatable version of the table is returned.
        public DataTable GetDataTable()
        {
            DataTable dt = new DataTable(this.fileName);

            foreach (string colName in this.header)
            {
                dt.Columns.Add(colName, typeof(string));
            }

            foreach (string[] row in rows)
            {
                DataRow dr = dt.NewRow();

                for (int i = 0; i < row.Length; i++)
                    dr[i] = row[i].Trim();

                dt.Rows.Add(dr);
            }

            return dt;
        }

        //when requested, a xml data string of the table is returned.
        
        public void JSONToCSVSave(string filePath, string[] header)
        {
            //읽기 전용 스트림 리더를 만들어서 JSON 파일 전체를 읽음
            StreamReader reader = new StreamReader(filePath,Encoding.UTF8);
            string jsonString = reader.ReadToEnd();

            //Native Object 형태로 바꾸기
            JsonDocumentOptions jsonDocumentOptions = new JsonDocumentOptions
            {
                AllowTrailingCommas = true  // 데이터 후행의 쉼표 허용 여부
            };
            JsonDocument jsonDocument = JsonDocument.Parse(jsonString, jsonDocumentOptions);

            int fileSize = jsonDocument.RootElement.GetArrayLength() + 1;

            string[] record = new string[fileSize];

            //CSV의 attribute명을 첫번째 row에 저장
            const string quote = "\"";
            record[0] = quote + header[0] + quote + "," + quote + header[1] + quote;

            int i = 1;
            foreach (JsonElement element in jsonDocument.RootElement.EnumerateArray())
            {
                JsonElement col1 = element.GetProperty(header[0]);
                JsonElement col2 = element.GetProperty(header[1]);
                
               
                record[i] = quote + col1 + quote + "," + quote + col2 + quote;


                i++;

            }

            FileStream fs = File.OpenWrite("patentCSV/abstract.csv");
            StreamWriter writer = new StreamWriter(fs,Encoding.UTF8);

            for (int j = 0; j < 10; j++)
            {
                writer.WriteLine(record[j]);
                Form1.form1.patentInfoLoadingList.Text = j + "번쨰 데이터 입력완료";
                
                System.Threading.Thread.Sleep(1000);
            }
            writer.Close();

            MessageBox.Show("파일이 생성되었습니다");


          
        }



    }


    

            
            

            


        
        
       

        




  
}
