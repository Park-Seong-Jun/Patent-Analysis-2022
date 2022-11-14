using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.Json;
using System.Text.Json.Serialization;
using System.Drawing;
using System.Data;

namespace 박성준_201911529_개인과제
{
   
   
    
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


            //DataSet dataSet = new DataSet("PatentDB");

            //DataTable pAbst = new DataTable("PatentAbstract");

            //DataColumn pAbstId = new DataColumn("id", typeof(string));
            //DataColumn pAbstAbst = new DataColumn("abstract", typeof(string));
            //pAbst.Columns.Add(pAbstId);
            //pAbst.Columns.Add(pAbstAbst);

            //DataRow pAbstRow = pAbst.NewRow();

            

           





            //DataTable pApp = new DataTable("PatentApplicant");

            //DataColumn pAppId = new DataColumn("id", typeof(string));
            //DataColumn pAppName = new DataColumn("name", typeof(string));
            //DataColumn pAppEngname = new DataColumn("engName", typeof(string));
            //DataColumn pAppCode = new DataColumn("code", typeof(string));
            //DataColumn pAppAddress = new DataColumn("address", typeof(string));
            //DataColumn pAppCountry = new DataColumn("country", typeof(string));
            //DataColumn pAppBRNum = new DataColumn("businessRegistrationNumber", typeof(string));
            //DataColumn pAppCNum = new DataColumn("corporationNumber", typeof(string));



        }
        
    }
}
