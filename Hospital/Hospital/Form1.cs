using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using System.IO;


namespace Hospital
{
   

    public partial class Form1 : Form
    { 
        Microsoft.Office.Interop.Word.Application wordApp;
        Microsoft.Office.Interop.Word.Document wordDoc;
        Microsoft.Office.Interop.Excel.Application ExcelApp;
        Microsoft.Office.Interop.Excel.Window ExcelWindow;
        Microsoft.Office.Interop.Excel.Workbook WorkBook;
        Microsoft.Office.Interop.Excel.Sheets ExcelSheets;
        Microsoft.Office.Interop.Excel.Worksheet WorkSheet;
        Microsoft.Office.Interop.Excel.Range range;          


        private int DoctorsID;
        private int PatientsID;
        private int ConsultationsID;

        public Form1()
        {
            InitializeComponent();
        }
                
        private void Form1_Load(object sender, EventArgs e)
        {
            oleDbConnection1.Open();
            UpdateConsultations();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            oleDbConnection1.Close();
        }

        private void UpdateConsultations()
        {   
            oleDbDataAdapter1.Update(dataSet1);
            oleDbDataAdapter2.Update(dataSet1);
            oleDbDataAdapter3.Update(dataSet1);
            

            dataSet1.Clear();

            
            oleDbDataAdapter2.Fill(dataSet1.Doctors);
            oleDbDataAdapter3.Fill(dataSet1.Patients);
            oleDbDataAdapter1.Fill(dataSet1.Consultations);

            DocComboBox.Items.Clear();
            PatComboBox.Items.Clear();

            foreach (DataRow row in dataSet1.Doctors.Rows)
                DocComboBox.Items.Add(row["Doc_Surname"]);
            DocComboBox.Text = "";

            foreach (DataRow row in dataSet1.Patients.Rows)
                PatComboBox.Items.Add(row["Pat_Surname"]);
            PatComboBox.Text = "";
        }
                

        /////dataGridView2////////////////////////////////////////////////////////////////////////////////////////

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DoctorsID = e.RowIndex;
                DocName.Text = dataSet1.Doctors.Rows[DoctorsID]["Doc_Name"].ToString();
                DocSurname.Text = dataSet1.Doctors.Rows[DoctorsID]["Doc_Surname"].ToString();
                DocPosition.Text = dataSet1.Doctors.Rows[DoctorsID]["Doc_Position"].ToString();
            }
            catch (Exception)
            { 
            }
        }
        
        private void AddDoc_Click(object sender, EventArgs e)
        {
            if (DocName.Text != "" && DocSurname.Text != "" && DocPosition.Text != "")
            {
                DataRow row = dataSet1.Doctors.NewRow();
                row["Doc_Name"] = DocName.Text;
                row["Doc_Surname"] = DocSurname.Text;
                row["Doc_Position"] = DocPosition.Text;
                dataSet1.Doctors.Rows.Add(row);
                UpdateConsultations();
            }
        }
        
        private void EditDoc_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count != 0)
            {
                DataRow row = dataSet1.Doctors.Rows[DoctorsID];
                row["Doc_Name"] = DocName.Text;
                row["Doc_Surname"] = DocSurname.Text;
                row["Doc_Position"] = DocPosition.Text;
                UpdateConsultations();
            }
            else
                MessageBox.Show("Выберите строку для редактирования", "Ошибка");
        }

        private void DeleteDoc_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        dataSet1.Doctors.Rows[DoctorsID].Delete();
                    }
                    catch (Exception)
                    {
                    }
                    UpdateConsultations();
                }
            }
            else
                MessageBox.Show("Выберите строку для удаления", "Ошибка");
        }
        

        /////dataGridView3////////////////////////////////////////////////////////////////////////////////////////

        private void dataGridView3_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                PatientsID = e.RowIndex;
                PatName.Text = dataSet1.Patients.Rows[PatientsID]["Pat_Name"].ToString();
                PatSurname.Text = dataSet1.Patients.Rows[PatientsID]["Pat_Surname"].ToString();
            }
            catch (Exception)
            {
            }
        }

        private void AddPat_Click(object sender, EventArgs e)
        {
            if (PatName.Text != "" && PatSurname.Text != "")
            {
                DataRow row = dataSet1.Patients.NewRow();
                row["Pat_Name"] = PatName.Text;
                row["Pat_Surname"] = PatSurname.Text;
                dataSet1.Patients.Rows.Add(row);
                UpdateConsultations();
            }
        }

        private void EditPat_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count != 0)
            {
                DataRow row = dataSet1.Patients.Rows[PatientsID];
                row["Pat_Name"] = PatName.Text;
                row["Pat_Surname"] = PatSurname.Text;
                UpdateConsultations();
            }
            else
                MessageBox.Show("Выберите строку для редактирования", "Ошибка");
        }
        
        private void DeletePat_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        dataSet1.Patients.Rows[PatientsID].Delete();
                    }
                    catch (Exception)
                    {
                    }
                    UpdateConsultations();
                }
            }
            else
                MessageBox.Show("Выберите строку для удаления", "Ошибка");
        }

        
        /////dataGridView1////////////////////////////////////////////////////////////////////////////////////////

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                ConsultationsID = e.RowIndex;
                DataRow f = dataSet1.Consultations.Rows[ConsultationsID];

                ConsDateTime.Text = f["Cons_Date_Time"].ToString();
                ConsDescription.Text = f["Cons_Description"].ToString();

                DataRow[] p = f.GetParentRows(dataSet1.Relations["Doctors_Consultations"]);
                DocComboBox.Text = p[0]["Doc_Surname"].ToString();

                DataRow[] d = f.GetParentRows(dataSet1.Relations["FK_Patients_Consultations"]);
                PatComboBox.Text = d[0]["Pat_Surname"].ToString();
            }
            catch (Exception)
            {
            }
        }
        
        private void AddCons_Click(object sender, EventArgs e)
        {
            if (DocComboBox.Text != "" && PatComboBox.Text != "" && ConsDateTime.Text != "" && ConsDescription.Text != "")
            {
                DataRow row = dataSet1.Consultations.NewRow();
                
                
                string famdoc = DocComboBox.SelectedItem.ToString();
                string strdoc = "Doc_Surname='" + famdoc + "'";   
                DataRow[] doc = dataSet1.Doctors.Select(strdoc);
                row["Cons_Doctor"] = doc[0]["Doc_ID"];

                string fampat = PatComboBox.SelectedItem.ToString();
                string strpat = "Pat_Surname='" + fampat + "'";
                DataRow[] pat = dataSet1.Patients.Select(strpat);
                row["Cons_Patient"] = pat[0]["Pat_ID"];


                row["Cons_Date_Time"] = ConsDateTime.Text;
                row["Cons_Description"] = ConsDescription.Text;

                dataSet1.Consultations.Rows.Add(row);
                UpdateConsultations();

            }
        }
            
        private void EditCons_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                DataRow row = dataSet1.Consultations.Rows[ConsultationsID];

                string famdoc = DocComboBox.SelectedItem.ToString();
                string strdoc = "Doc_Surname='" + famdoc + "'";
                DataRow[] doc = dataSet1.Doctors.Select(strdoc);
                row["Cons_Doctor"] = doc[0]["Doc_ID"];

                string fampat = PatComboBox.SelectedItem.ToString();
                string strpat = "Pat_Surname='" + fampat + "'";
                DataRow[] pat = dataSet1.Patients.Select(strpat);
                row["Cons_Patient"] = pat[0]["Pat_ID"];


                row["Cons_Date_Time"] = ConsDateTime.Text;
                row["Cons_Description"] = ConsDescription.Text;

                UpdateConsultations();
            }
        }

        private void DeleteCons_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        dataSet1.Consultations.Rows[ConsultationsID].Delete();
                    }
                    catch (Exception)
                    {
                    }
                    UpdateConsultations();
                }
            }
            else
                MessageBox.Show("Выберите строку для удаления", "Ошибка");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked && (((DocComboBox.Text != "") || (PatComboBox.Text != "")) || (DocComboBox.Text != "" && PatComboBox.Text != "")))
            {
                if (DocComboBox.Text != "" && PatComboBox.Text == "")
                {
                    string doc = DocComboBox.SelectedItem.ToString();
                    string str1 = "Doc_Surname='" + doc + "'";
                    DataRow[] iddoc = dataSet1.Doctors.Select(str1);
                    str1 = "Cons_Doctor=" + iddoc[0]["Doc_ID"];
                    consultationsBindingSource.Filter = str1;
                }

                if (DocComboBox.Text == "" && PatComboBox.Text != "")
                {
                    string pat = PatComboBox.SelectedItem.ToString();
                    string str2 = "Pat_Surname='" + pat + "'";
                    DataRow[] idpat = dataSet1.Patients.Select(str2);
                    str2 = "Cons_Patient=" + idpat[0]["Pat_ID"];
                    consultationsBindingSource.Filter = str2;
                }

                if ((DocComboBox.Text != "") && (PatComboBox.Text != ""))
                {
                    string doctwo = DocComboBox.SelectedItem.ToString();
                    string str1 = "Doc_Surname='" + doctwo + "'";
                    DataRow[] idoc = dataSet1.Doctors.Select(str1);

                    string pattwo = PatComboBox.SelectedItem.ToString();
                    string str2 = "Pat_Surname='" + pattwo + "'";
                    DataRow[] ipat = dataSet1.Patients.Select(str2);

                    str1 = "Cons_Doctor='" + idoc[0]["Doc_ID"] + "' and Cons_Patient='" + ipat[0]["Pat_ID"] + "'";
                    consultationsBindingSource.Filter = str1;
                }
            }
            else
                consultationsBindingSource.Filter = "";
        }


        /////Invitation///////////////////////////////////////////////////////////////////////////////////////////


        private void OpenDocument(string FileName)
        {
            wordApp = new Microsoft.Office.Interop.Word.Application();
            Object template = System.Windows.Forms.Application.StartupPath + @"\docs\" + FileName;
            Object newTemplate = false;
            Object documentType = Microsoft.Office.Interop.Word.WdNewDocumentType.wdNewBlankDocument;
            Object visible = true;
            wordDoc = wordApp.Documents.Add(ref template, ref newTemplate, ref documentType, ref visible);
        }

        public void ReplaceText(string word, string repl)
        {
            Object unit = Microsoft.Office.Interop.Word.WdUnits.wdStory;
            Object extend = Microsoft.Office.Interop.Word.WdMovementType.wdMove;
            wordApp.Selection.HomeKey(ref unit, ref extend);
            Microsoft.Office.Interop.Word.Find fnd = wordApp.Selection.Find;
            fnd.ClearFormatting();
            fnd.Text = word;
            fnd.Replacement.ClearFormatting();
            fnd.Replacement.Text = repl;
            ExecuteReplace(fnd);
        }

        private Boolean ExecuteReplace(Microsoft.Office.Interop.Word.Find find)
        {
            return ExecuteReplace(find, Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll);
        }

        private Boolean ExecuteReplace(Microsoft.Office.Interop.Word.Find find, Object replaceOption)
        {
            Object findText = Type.Missing;
            Object matchCase = Type.Missing;
            Object matchWholeWord = Type.Missing;
            Object matchWildcards = Type.Missing;
            Object matchSoundsLike = Type.Missing;
            Object matchAllWordForms = Type.Missing;
            Object forward = Type.Missing;
            Object wrap = Type.Missing;
            Object format = Type.Missing;
            Object replaceWith = Type.Missing;
            Object replace = replaceOption;
            Object matchKashida = Type.Missing;
            Object matchDiacritics = Type.Missing;
            Object matchAlefHamza = Type.Missing;
            Object matchControl = Type.Missing;

            return find.Execute(ref findText, ref matchCase,
            ref matchWholeWord, ref matchWildcards, ref matchSoundsLike,
            ref matchAllWordForms, ref forward, ref wrap, ref format,
            ref replaceWith, ref replace, ref matchKashida,
            ref matchDiacritics, ref matchAlefHamza, ref matchControl);
        }

        private void Invitatoion_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count != 0)
            {
                Form2 form = new Form2();
                string[] Positions = { "терапевта", "хирурга", "педиатра", "стоматолога", "травматолога", "кардиолога"};
                form.comboBox1.Items.AddRange(Positions);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    OpenDocument("Приглашение.docx");
                    DataRow row = dataSet1.Patients.Rows[PatientsID];
                    string FIO = row["Pat_Name"].ToString() + " " + row["Pat_Surname"].ToString();
                    ReplaceText("<FIO>", FIO);
                    ReplaceText("<Position>", form.comboBox1.Text);
                    ReplaceText("<Doctor>", form.textBox1.Text);
                    ReplaceText("<Date>", form.dateTimePicker1.Value.ToLongDateString());
                    wordApp.Visible = true;
                }
            }
            else
                MessageBox.Show("Выберите человека", "Ошибка");

        }

    }
}
