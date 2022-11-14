using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Linq.Expressions;

namespace 박성준_201911529_개인과제
{
    public partial class Form1 : Form
    {
        public static Form1 form1;
        public Form1()
        {
            InitializeComponent();
            form1 = this;
        }

        class PatentFileList
        {
            private string abstractFilePath = "patent data/abstract.json";
            private string applicantFilePath = "patent data/applicantt.json";
            private string bibliosummaryFilePath = "patent data/bibliosummary.json";
            private string inventorFilePath = "patent data/inventor.json";
            private string ipcFilePath = "patent data/ipc.json";

            public string AbstractFilePath { get => abstractFilePath; set => abstractFilePath = value; }
            public string ApplicantFilePath { get => applicantFilePath; set => applicantFilePath = value; }
            public string BibliosummaryFilePath { get => bibliosummaryFilePath; set => bibliosummaryFilePath = value; }
            public string InventorFilePath { get => inventorFilePath; set => inventorFilePath = value; }
            public string IpcFilePath { get => ipcFilePath; set => ipcFilePath = value; }

            
        }

        private void btnPatentLoading_Click(object sender, EventArgs e)
        {
            PatentFileList patentFileList = new PatentFileList();
            

            
            if (!File.Exists("patentCSV/abstract.csv"))
            {
                Directory.CreateDirectory("patentCSV");
                string[] inputHeader = new string[2];
                inputHeader[0] = "id";
                inputHeader[1] = "astrtCont";

                JsonFileManager fm = new JsonFileManager(patentFileList.AbstractFilePath);
                fm.JSONToCSVSave(patentFileList.AbstractFilePath, inputHeader);

            }
            else
            {
                MessageBox.Show("CSV 파일이 생성되어 있습니다!");
            }
            

            
            
        }

        private void CSVFileOpenBtn_Click(object sender, EventArgs e)
        {
            if (this.dlgFileOpen.ShowDialog() == DialogResult.OK)
            {
                string filePath = dlgFileOpen.FileName;


                try
                {
                    JsonFileManager patentCSVFile = new JsonFileManager(filePath);
                    DataTable dataTableAbstract = patentCSVFile.GetDataTable();
                    filePathTextBox.Text = filePath;
                    dataGridView.DataSource = dataTableAbstract;
                }
                catch(Exception ex)

                {
                    MessageBox.Show(ex.Message);
                    return;
                    
                }
            }
        }
    }
}
