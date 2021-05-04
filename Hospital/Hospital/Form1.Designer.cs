namespace Hospital
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter3 = new System.Data.OleDb.OleDbDataAdapter();
            this.consultationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Hospital.DataSet1();
            this.doctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.docIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docPositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.patIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddDoc = new System.Windows.Forms.Button();
            this.AddPat = new System.Windows.Forms.Button();
            this.AddCons = new System.Windows.Forms.Button();
            this.EditDoc = new System.Windows.Forms.Button();
            this.EditPat = new System.Windows.Forms.Button();
            this.EditCons = new System.Windows.Forms.Button();
            this.DeleteDoc = new System.Windows.Forms.Button();
            this.DeletePat = new System.Windows.Forms.Button();
            this.DeleteCons = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DocName = new System.Windows.Forms.TextBox();
            this.DocSurname = new System.Windows.Forms.TextBox();
            this.DocPosition = new System.Windows.Forms.TextBox();
            this.PatName = new System.Windows.Forms.TextBox();
            this.PatSurname = new System.Windows.Forms.TextBox();
            this.ConsDateTime = new System.Windows.Forms.TextBox();
            this.ConsDescription = new System.Windows.Forms.TextBox();
            this.PatComboBox = new System.Windows.Forms.ComboBox();
            this.DocComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.consDoctorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.consPatientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.consDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.consIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consDoctorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.consPatientDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.consDateTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consDescriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Invitation = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.consultationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"D:\\Учёба\\Разработка бизнес-приложен" +
    "ий\\Лабы\\Hospital2000.mdb\"";
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT        Cons_ID, Cons_Doctor, Cons_Patient, Cons_Date_Time, Cons_Descriptio" +
    "n\r\nFROM            Consultations";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO `Consultations` (`Cons_Doctor`, `Cons_Patient`, `Cons_Date_Time`, `Co" +
    "ns_Description`) VALUES (?, ?, ?, ?)";
            this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Cons_Doctor", System.Data.OleDb.OleDbType.Integer, 0, "Cons_Doctor"),
            new System.Data.OleDb.OleDbParameter("Cons_Patient", System.Data.OleDb.OleDbType.Integer, 0, "Cons_Patient"),
            new System.Data.OleDb.OleDbParameter("Cons_Date_Time", System.Data.OleDb.OleDbType.Date, 0, "Cons_Date_Time"),
            new System.Data.OleDb.OleDbParameter("Cons_Description", System.Data.OleDb.OleDbType.VarWChar, 0, "Cons_Description")});
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText");
            this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Cons_Doctor", System.Data.OleDb.OleDbType.Integer, 0, "Cons_Doctor"),
            new System.Data.OleDb.OleDbParameter("Cons_Patient", System.Data.OleDb.OleDbType.Integer, 0, "Cons_Patient"),
            new System.Data.OleDb.OleDbParameter("Cons_Date_Time", System.Data.OleDb.OleDbType.Date, 0, "Cons_Date_Time"),
            new System.Data.OleDb.OleDbParameter("Cons_Description", System.Data.OleDb.OleDbType.VarWChar, 0, "Cons_Description"),
            new System.Data.OleDb.OleDbParameter("Original_Cons_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cons_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Cons_Doctor", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Cons_Doctor", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Cons_Doctor", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cons_Doctor", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Cons_Patient", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Cons_Patient", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Cons_Patient", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cons_Patient", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Cons_Date_Time", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Cons_Date_Time", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Cons_Date_Time", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cons_Date_Time", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Cons_Description", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Cons_Description", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Cons_Description", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cons_Description", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = resources.GetString("oleDbDeleteCommand1.CommandText");
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_Cons_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cons_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Cons_Doctor", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Cons_Doctor", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Cons_Doctor", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cons_Doctor", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Cons_Patient", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Cons_Patient", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Cons_Patient", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cons_Patient", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Cons_Date_Time", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Cons_Date_Time", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Cons_Date_Time", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cons_Date_Time", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Cons_Description", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Cons_Description", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Cons_Description", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cons_Description", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
            this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Consultations", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Cons_ID", "Cons_ID"),
                        new System.Data.Common.DataColumnMapping("Cons_Doctor", "Cons_Doctor"),
                        new System.Data.Common.DataColumnMapping("Cons_Patient", "Cons_Patient"),
                        new System.Data.Common.DataColumnMapping("Cons_Date_Time", "Cons_Date_Time"),
                        new System.Data.Common.DataColumnMapping("Cons_Description", "Cons_Description")})});
            this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // oleDbSelectCommand2
            // 
            this.oleDbSelectCommand2.CommandText = "SELECT        Doc_ID, Doc_Name, Doc_Surname, Doc_Position\r\nFROM            Doctor" +
    "s";
            this.oleDbSelectCommand2.Connection = this.oleDbConnection1;
            // 
            // oleDbInsertCommand2
            // 
            this.oleDbInsertCommand2.CommandText = "INSERT INTO `Doctors` (`Doc_Name`, `Doc_Surname`, `Doc_Position`) VALUES (?, ?, ?" +
    ")";
            this.oleDbInsertCommand2.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Doc_Name", System.Data.OleDb.OleDbType.VarWChar, 0, "Doc_Name"),
            new System.Data.OleDb.OleDbParameter("Doc_Surname", System.Data.OleDb.OleDbType.VarWChar, 0, "Doc_Surname"),
            new System.Data.OleDb.OleDbParameter("Doc_Position", System.Data.OleDb.OleDbType.VarWChar, 0, "Doc_Position")});
            // 
            // oleDbUpdateCommand2
            // 
            this.oleDbUpdateCommand2.CommandText = resources.GetString("oleDbUpdateCommand2.CommandText");
            this.oleDbUpdateCommand2.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Doc_Name", System.Data.OleDb.OleDbType.VarWChar, 0, "Doc_Name"),
            new System.Data.OleDb.OleDbParameter("Doc_Surname", System.Data.OleDb.OleDbType.VarWChar, 0, "Doc_Surname"),
            new System.Data.OleDb.OleDbParameter("Doc_Position", System.Data.OleDb.OleDbType.VarWChar, 0, "Doc_Position"),
            new System.Data.OleDb.OleDbParameter("Original_Doc_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Doc_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Doc_Name", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Doc_Name", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Doc_Name", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Doc_Name", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Doc_Surname", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Doc_Surname", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Doc_Surname", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Doc_Surname", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Doc_Position", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Doc_Position", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Doc_Position", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Doc_Position", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand2
            // 
            this.oleDbDeleteCommand2.CommandText = resources.GetString("oleDbDeleteCommand2.CommandText");
            this.oleDbDeleteCommand2.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_Doc_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Doc_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Doc_Name", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Doc_Name", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Doc_Name", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Doc_Name", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Doc_Surname", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Doc_Surname", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Doc_Surname", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Doc_Surname", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Doc_Position", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Doc_Position", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Doc_Position", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Doc_Position", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDataAdapter2
            // 
            this.oleDbDataAdapter2.DeleteCommand = this.oleDbDeleteCommand2;
            this.oleDbDataAdapter2.InsertCommand = this.oleDbInsertCommand2;
            this.oleDbDataAdapter2.SelectCommand = this.oleDbSelectCommand2;
            this.oleDbDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Doctors", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Doc_ID", "Doc_ID"),
                        new System.Data.Common.DataColumnMapping("Doc_Name", "Doc_Name"),
                        new System.Data.Common.DataColumnMapping("Doc_Surname", "Doc_Surname"),
                        new System.Data.Common.DataColumnMapping("Doc_Position", "Doc_Position")})});
            this.oleDbDataAdapter2.UpdateCommand = this.oleDbUpdateCommand2;
            // 
            // oleDbSelectCommand3
            // 
            this.oleDbSelectCommand3.CommandText = "SELECT        Pat_ID, Pat_Name, Pat_Surname\r\nFROM            Patients";
            this.oleDbSelectCommand3.Connection = this.oleDbConnection1;
            // 
            // oleDbInsertCommand3
            // 
            this.oleDbInsertCommand3.CommandText = "INSERT INTO `Patients` (`Pat_Name`, `Pat_Surname`) VALUES (?, ?)";
            this.oleDbInsertCommand3.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Pat_Name", System.Data.OleDb.OleDbType.VarWChar, 0, "Pat_Name"),
            new System.Data.OleDb.OleDbParameter("Pat_Surname", System.Data.OleDb.OleDbType.VarWChar, 0, "Pat_Surname")});
            // 
            // oleDbUpdateCommand3
            // 
            this.oleDbUpdateCommand3.CommandText = "UPDATE `Patients` SET `Pat_Name` = ?, `Pat_Surname` = ? WHERE ((`Pat_ID` = ?) AND" +
    " ((? = 1 AND `Pat_Name` IS NULL) OR (`Pat_Name` = ?)) AND ((? = 1 AND `Pat_Surna" +
    "me` IS NULL) OR (`Pat_Surname` = ?)))";
            this.oleDbUpdateCommand3.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Pat_Name", System.Data.OleDb.OleDbType.VarWChar, 0, "Pat_Name"),
            new System.Data.OleDb.OleDbParameter("Pat_Surname", System.Data.OleDb.OleDbType.VarWChar, 0, "Pat_Surname"),
            new System.Data.OleDb.OleDbParameter("Original_Pat_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Pat_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Pat_Name", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Pat_Name", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Pat_Name", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Pat_Name", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Pat_Surname", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Pat_Surname", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Pat_Surname", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Pat_Surname", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand3
            // 
            this.oleDbDeleteCommand3.CommandText = "DELETE FROM `Patients` WHERE ((`Pat_ID` = ?) AND ((? = 1 AND `Pat_Name` IS NULL) " +
    "OR (`Pat_Name` = ?)) AND ((? = 1 AND `Pat_Surname` IS NULL) OR (`Pat_Surname` = " +
    "?)))";
            this.oleDbDeleteCommand3.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_Pat_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Pat_ID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Pat_Name", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Pat_Name", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Pat_Name", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Pat_Name", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Pat_Surname", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Pat_Surname", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Pat_Surname", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Pat_Surname", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDataAdapter3
            // 
            this.oleDbDataAdapter3.DeleteCommand = this.oleDbDeleteCommand3;
            this.oleDbDataAdapter3.InsertCommand = this.oleDbInsertCommand3;
            this.oleDbDataAdapter3.SelectCommand = this.oleDbSelectCommand3;
            this.oleDbDataAdapter3.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Patients", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Pat_ID", "Pat_ID"),
                        new System.Data.Common.DataColumnMapping("Pat_Name", "Pat_Name"),
                        new System.Data.Common.DataColumnMapping("Pat_Surname", "Pat_Surname")})});
            this.oleDbDataAdapter3.UpdateCommand = this.oleDbUpdateCommand3;
            // 
            // consultationsBindingSource
            // 
            this.consultationsBindingSource.DataMember = "Consultations";
            this.consultationsBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorsBindingSource
            // 
            this.doctorsBindingSource.DataMember = "Doctors";
            this.doctorsBindingSource.DataSource = this.dataSet1;
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.dataSet1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.docIDDataGridViewTextBoxColumn,
            this.docNameDataGridViewTextBoxColumn,
            this.docSurnameDataGridViewTextBoxColumn,
            this.docPositionDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.doctorsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(36, 31);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(591, 148);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_RowHeaderMouseClick);
            // 
            // docIDDataGridViewTextBoxColumn
            // 
            this.docIDDataGridViewTextBoxColumn.DataPropertyName = "Doc_ID";
            this.docIDDataGridViewTextBoxColumn.HeaderText = "Doc_ID";
            this.docIDDataGridViewTextBoxColumn.Name = "docIDDataGridViewTextBoxColumn";
            // 
            // docNameDataGridViewTextBoxColumn
            // 
            this.docNameDataGridViewTextBoxColumn.DataPropertyName = "Doc_Name";
            this.docNameDataGridViewTextBoxColumn.HeaderText = "Doc_Name";
            this.docNameDataGridViewTextBoxColumn.Name = "docNameDataGridViewTextBoxColumn";
            // 
            // docSurnameDataGridViewTextBoxColumn
            // 
            this.docSurnameDataGridViewTextBoxColumn.DataPropertyName = "Doc_Surname";
            this.docSurnameDataGridViewTextBoxColumn.HeaderText = "Doc_Surname";
            this.docSurnameDataGridViewTextBoxColumn.Name = "docSurnameDataGridViewTextBoxColumn";
            // 
            // docPositionDataGridViewTextBoxColumn
            // 
            this.docPositionDataGridViewTextBoxColumn.DataPropertyName = "Doc_Position";
            this.docPositionDataGridViewTextBoxColumn.HeaderText = "Doc_Position";
            this.docPositionDataGridViewTextBoxColumn.Name = "docPositionDataGridViewTextBoxColumn";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patIDDataGridViewTextBoxColumn,
            this.patNameDataGridViewTextBoxColumn,
            this.patSurnameDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.patientsBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(36, 234);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(480, 148);
            this.dataGridView3.TabIndex = 2;
            this.dataGridView3.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView3_RowHeaderMouseClick);
            // 
            // patIDDataGridViewTextBoxColumn
            // 
            this.patIDDataGridViewTextBoxColumn.DataPropertyName = "Pat_ID";
            this.patIDDataGridViewTextBoxColumn.HeaderText = "Pat_ID";
            this.patIDDataGridViewTextBoxColumn.Name = "patIDDataGridViewTextBoxColumn";
            // 
            // patNameDataGridViewTextBoxColumn
            // 
            this.patNameDataGridViewTextBoxColumn.DataPropertyName = "Pat_Name";
            this.patNameDataGridViewTextBoxColumn.HeaderText = "Pat_Name";
            this.patNameDataGridViewTextBoxColumn.Name = "patNameDataGridViewTextBoxColumn";
            // 
            // patSurnameDataGridViewTextBoxColumn
            // 
            this.patSurnameDataGridViewTextBoxColumn.DataPropertyName = "Pat_Surname";
            this.patSurnameDataGridViewTextBoxColumn.HeaderText = "Pat_Surname";
            this.patSurnameDataGridViewTextBoxColumn.Name = "patSurnameDataGridViewTextBoxColumn";
            // 
            // AddDoc
            // 
            this.AddDoc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddDoc.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDoc.Location = new System.Drawing.Point(1111, 26);
            this.AddDoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddDoc.Name = "AddDoc";
            this.AddDoc.Size = new System.Drawing.Size(109, 34);
            this.AddDoc.TabIndex = 3;
            this.AddDoc.Text = "Добавить";
            this.AddDoc.UseVisualStyleBackColor = false;
            this.AddDoc.Click += new System.EventHandler(this.AddDoc_Click);
            // 
            // AddPat
            // 
            this.AddPat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddPat.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddPat.Location = new System.Drawing.Point(1111, 234);
            this.AddPat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddPat.Name = "AddPat";
            this.AddPat.Size = new System.Drawing.Size(109, 34);
            this.AddPat.TabIndex = 4;
            this.AddPat.Text = "Добавить";
            this.AddPat.UseVisualStyleBackColor = false;
            this.AddPat.Click += new System.EventHandler(this.AddPat_Click);
            // 
            // AddCons
            // 
            this.AddCons.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddCons.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCons.Location = new System.Drawing.Point(1111, 436);
            this.AddCons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddCons.Name = "AddCons";
            this.AddCons.Size = new System.Drawing.Size(109, 34);
            this.AddCons.TabIndex = 5;
            this.AddCons.Text = "Добавить";
            this.AddCons.UseVisualStyleBackColor = false;
            this.AddCons.Click += new System.EventHandler(this.AddCons_Click);
            // 
            // EditDoc
            // 
            this.EditDoc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EditDoc.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditDoc.Location = new System.Drawing.Point(1111, 68);
            this.EditDoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditDoc.Name = "EditDoc";
            this.EditDoc.Size = new System.Drawing.Size(109, 34);
            this.EditDoc.TabIndex = 6;
            this.EditDoc.Text = "Изменить";
            this.EditDoc.UseVisualStyleBackColor = false;
            this.EditDoc.Click += new System.EventHandler(this.EditDoc_Click);
            // 
            // EditPat
            // 
            this.EditPat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EditPat.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditPat.Location = new System.Drawing.Point(1111, 276);
            this.EditPat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditPat.Name = "EditPat";
            this.EditPat.Size = new System.Drawing.Size(109, 34);
            this.EditPat.TabIndex = 7;
            this.EditPat.Text = "Изменить";
            this.EditPat.UseVisualStyleBackColor = false;
            this.EditPat.Click += new System.EventHandler(this.EditPat_Click);
            // 
            // EditCons
            // 
            this.EditCons.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EditCons.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditCons.Location = new System.Drawing.Point(1111, 478);
            this.EditCons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditCons.Name = "EditCons";
            this.EditCons.Size = new System.Drawing.Size(109, 34);
            this.EditCons.TabIndex = 8;
            this.EditCons.Text = "Изменить";
            this.EditCons.UseVisualStyleBackColor = false;
            this.EditCons.Click += new System.EventHandler(this.EditCons_Click);
            // 
            // DeleteDoc
            // 
            this.DeleteDoc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DeleteDoc.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteDoc.Location = new System.Drawing.Point(1111, 110);
            this.DeleteDoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteDoc.Name = "DeleteDoc";
            this.DeleteDoc.Size = new System.Drawing.Size(109, 34);
            this.DeleteDoc.TabIndex = 9;
            this.DeleteDoc.Text = "Удалить";
            this.DeleteDoc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DeleteDoc.UseVisualStyleBackColor = false;
            this.DeleteDoc.Click += new System.EventHandler(this.DeleteDoc_Click);
            // 
            // DeletePat
            // 
            this.DeletePat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DeletePat.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeletePat.Location = new System.Drawing.Point(1111, 318);
            this.DeletePat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeletePat.Name = "DeletePat";
            this.DeletePat.Size = new System.Drawing.Size(109, 34);
            this.DeletePat.TabIndex = 10;
            this.DeletePat.Text = "Удалить";
            this.DeletePat.UseVisualStyleBackColor = false;
            this.DeletePat.Click += new System.EventHandler(this.DeletePat_Click);
            // 
            // DeleteCons
            // 
            this.DeleteCons.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DeleteCons.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteCons.Location = new System.Drawing.Point(1111, 519);
            this.DeleteCons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteCons.Name = "DeleteCons";
            this.DeleteCons.Size = new System.Drawing.Size(109, 34);
            this.DeleteCons.TabIndex = 11;
            this.DeleteCons.Text = "Удалить";
            this.DeleteCons.UseVisualStyleBackColor = false;
            this.DeleteCons.Click += new System.EventHandler(this.DeleteCons_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(787, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Имя";
            // 
            // DocName
            // 
            this.DocName.Location = new System.Drawing.Point(945, 32);
            this.DocName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DocName.Name = "DocName";
            this.DocName.Size = new System.Drawing.Size(132, 22);
            this.DocName.TabIndex = 13;
            // 
            // DocSurname
            // 
            this.DocSurname.Location = new System.Drawing.Point(945, 78);
            this.DocSurname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DocSurname.Name = "DocSurname";
            this.DocSurname.Size = new System.Drawing.Size(132, 22);
            this.DocSurname.TabIndex = 14;
            // 
            // DocPosition
            // 
            this.DocPosition.Location = new System.Drawing.Point(945, 119);
            this.DocPosition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DocPosition.Name = "DocPosition";
            this.DocPosition.Size = new System.Drawing.Size(132, 22);
            this.DocPosition.TabIndex = 15;
            // 
            // PatName
            // 
            this.PatName.Location = new System.Drawing.Point(945, 244);
            this.PatName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PatName.Name = "PatName";
            this.PatName.Size = new System.Drawing.Size(132, 22);
            this.PatName.TabIndex = 16;
            // 
            // PatSurname
            // 
            this.PatSurname.Location = new System.Drawing.Point(945, 286);
            this.PatSurname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PatSurname.Name = "PatSurname";
            this.PatSurname.Size = new System.Drawing.Size(132, 22);
            this.PatSurname.TabIndex = 17;
            // 
            // ConsDateTime
            // 
            this.ConsDateTime.Location = new System.Drawing.Point(948, 529);
            this.ConsDateTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ConsDateTime.Name = "ConsDateTime";
            this.ConsDateTime.Size = new System.Drawing.Size(129, 22);
            this.ConsDateTime.TabIndex = 19;
            // 
            // ConsDescription
            // 
            this.ConsDescription.Location = new System.Drawing.Point(948, 574);
            this.ConsDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ConsDescription.Name = "ConsDescription";
            this.ConsDescription.Size = new System.Drawing.Size(129, 22);
            this.ConsDescription.TabIndex = 20;
            // 
            // PatComboBox
            // 
            this.PatComboBox.FormattingEnabled = true;
            this.PatComboBox.Location = new System.Drawing.Point(948, 486);
            this.PatComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PatComboBox.Name = "PatComboBox";
            this.PatComboBox.Size = new System.Drawing.Size(129, 24);
            this.PatComboBox.TabIndex = 21;
            // 
            // DocComboBox
            // 
            this.DocComboBox.FormattingEnabled = true;
            this.DocComboBox.Location = new System.Drawing.Point(948, 444);
            this.DocComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DocComboBox.Name = "DocComboBox";
            this.DocComboBox.Size = new System.Drawing.Size(129, 24);
            this.DocComboBox.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(787, 246);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(787, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "Фамилия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(787, 288);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "Фамилия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(787, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 23);
            this.label5.TabIndex = 26;
            this.label5.Text = "Специализация";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(787, 448);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "Доктор";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(787, 490);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 23);
            this.label7.TabIndex = 28;
            this.label7.Text = "Пациент";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(787, 532);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 23);
            this.label8.TabIndex = 29;
            this.label8.Text = "Дата и время";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(787, 576);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 23);
            this.label9.TabIndex = 30;
            this.label9.Text = "Описание";
            // 
            // consDoctorDataGridViewTextBoxColumn
            // 
            this.consDoctorDataGridViewTextBoxColumn.DataPropertyName = "Cons_Doctor";
            this.consDoctorDataGridViewTextBoxColumn.DataSource = this.consultationsBindingSource;
            this.consDoctorDataGridViewTextBoxColumn.HeaderText = "Cons_Doctor";
            this.consDoctorDataGridViewTextBoxColumn.Name = "consDoctorDataGridViewTextBoxColumn";
            this.consDoctorDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.consDoctorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // consPatientDataGridViewTextBoxColumn
            // 
            this.consPatientDataGridViewTextBoxColumn.DataPropertyName = "Cons_Patient";
            this.consPatientDataGridViewTextBoxColumn.DataSource = this.consultationsBindingSource;
            this.consPatientDataGridViewTextBoxColumn.HeaderText = "Cons_Patient";
            this.consPatientDataGridViewTextBoxColumn.Name = "consPatientDataGridViewTextBoxColumn";
            this.consPatientDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.consPatientDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // consDateTimeDataGridViewTextBoxColumn
            // 
            this.consDateTimeDataGridViewTextBoxColumn.DataPropertyName = "Cons_Date_Time";
            this.consDateTimeDataGridViewTextBoxColumn.HeaderText = "Cons_Date_Time";
            this.consDateTimeDataGridViewTextBoxColumn.Name = "consDateTimeDataGridViewTextBoxColumn";
            // 
            // consDescriptionDataGridViewTextBoxColumn
            // 
            this.consDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Cons_Description";
            this.consDescriptionDataGridViewTextBoxColumn.HeaderText = "Cons_Description";
            this.consDescriptionDataGridViewTextBoxColumn.Name = "consDescriptionDataGridViewTextBoxColumn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.consIDDataGridViewTextBoxColumn,
            this.consDoctorDataGridViewTextBoxColumn1,
            this.consPatientDataGridViewTextBoxColumn1,
            this.consDateTimeDataGridViewTextBoxColumn1,
            this.consDescriptionDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.consultationsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(36, 438);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(724, 160);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // consIDDataGridViewTextBoxColumn
            // 
            this.consIDDataGridViewTextBoxColumn.DataPropertyName = "Cons_ID";
            this.consIDDataGridViewTextBoxColumn.HeaderText = "Cons_ID";
            this.consIDDataGridViewTextBoxColumn.Name = "consIDDataGridViewTextBoxColumn";
            // 
            // consDoctorDataGridViewTextBoxColumn1
            // 
            this.consDoctorDataGridViewTextBoxColumn1.DataPropertyName = "Cons_Doctor";
            this.consDoctorDataGridViewTextBoxColumn1.DataSource = this.doctorsBindingSource;
            this.consDoctorDataGridViewTextBoxColumn1.DisplayMember = "Doc_Surname";
            this.consDoctorDataGridViewTextBoxColumn1.HeaderText = "Cons_Doctor";
            this.consDoctorDataGridViewTextBoxColumn1.Name = "consDoctorDataGridViewTextBoxColumn1";
            this.consDoctorDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.consDoctorDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.consDoctorDataGridViewTextBoxColumn1.ValueMember = "Doc_ID";
            // 
            // consPatientDataGridViewTextBoxColumn1
            // 
            this.consPatientDataGridViewTextBoxColumn1.DataPropertyName = "Cons_Patient";
            this.consPatientDataGridViewTextBoxColumn1.DataSource = this.patientsBindingSource;
            this.consPatientDataGridViewTextBoxColumn1.DisplayMember = "Pat_Surname";
            this.consPatientDataGridViewTextBoxColumn1.HeaderText = "Cons_Patient";
            this.consPatientDataGridViewTextBoxColumn1.Name = "consPatientDataGridViewTextBoxColumn1";
            this.consPatientDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.consPatientDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.consPatientDataGridViewTextBoxColumn1.ValueMember = "Pat_ID";
            // 
            // consDateTimeDataGridViewTextBoxColumn1
            // 
            this.consDateTimeDataGridViewTextBoxColumn1.DataPropertyName = "Cons_Date_Time";
            this.consDateTimeDataGridViewTextBoxColumn1.HeaderText = "Cons_Date_Time";
            this.consDateTimeDataGridViewTextBoxColumn1.Name = "consDateTimeDataGridViewTextBoxColumn1";
            // 
            // consDescriptionDataGridViewTextBoxColumn1
            // 
            this.consDescriptionDataGridViewTextBoxColumn1.DataPropertyName = "Cons_Description";
            this.consDescriptionDataGridViewTextBoxColumn1.HeaderText = "Cons_Description";
            this.consDescriptionDataGridViewTextBoxColumn1.Name = "consDescriptionDataGridViewTextBoxColumn1";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(948, 410);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(126, 27);
            this.checkBox1.TabIndex = 32;
            this.checkBox1.Text = "Сортировка";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Invitation
            // 
            this.Invitation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Invitation.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Invitation.Location = new System.Drawing.Point(36, 620);
            this.Invitation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Invitation.Name = "Invitation";
            this.Invitation.Size = new System.Drawing.Size(199, 34);
            this.Invitation.TabIndex = 33;
            this.Invitation.Text = "Приглашение";
            this.Invitation.UseVisualStyleBackColor = false;
            this.Invitation.Click += new System.EventHandler(this.Invitatoion_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "HTML-страницы|*.html";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 669);
            this.Controls.Add(this.Invitation);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DocComboBox);
            this.Controls.Add(this.PatComboBox);
            this.Controls.Add(this.ConsDescription);
            this.Controls.Add(this.ConsDateTime);
            this.Controls.Add(this.PatSurname);
            this.Controls.Add(this.PatName);
            this.Controls.Add(this.DocPosition);
            this.Controls.Add(this.DocSurname);
            this.Controls.Add(this.DocName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteCons);
            this.Controls.Add(this.DeletePat);
            this.Controls.Add(this.DeleteDoc);
            this.Controls.Add(this.EditCons);
            this.Controls.Add(this.EditPat);
            this.Controls.Add(this.EditDoc);
            this.Controls.Add(this.AddCons);
            this.Controls.Add(this.AddPat);
            this.Controls.Add(this.AddDoc);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Hospital";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand3;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand3;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand3;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand3;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter3;
        private System.Windows.Forms.BindingSource consultationsBindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn docIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docPositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource doctorsBindingSource;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn patIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private System.Windows.Forms.Button AddDoc;
        private System.Windows.Forms.Button AddPat;
        private System.Windows.Forms.Button AddCons;
        private System.Windows.Forms.Button EditDoc;
        private System.Windows.Forms.Button EditPat;
        private System.Windows.Forms.Button EditCons;
        private System.Windows.Forms.Button DeleteDoc;
        private System.Windows.Forms.Button DeletePat;
        private System.Windows.Forms.Button DeleteCons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DocName;
        private System.Windows.Forms.TextBox DocSurname;
        private System.Windows.Forms.TextBox DocPosition;
        private System.Windows.Forms.TextBox PatName;
        private System.Windows.Forms.TextBox PatSurname;
        private System.Windows.Forms.TextBox ConsDateTime;
        private System.Windows.Forms.TextBox ConsDescription;
        private System.Windows.Forms.ComboBox PatComboBox;
        private System.Windows.Forms.ComboBox DocComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewComboBoxColumn consDoctorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn consPatientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn consIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn consDoctorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn consPatientDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn consDateTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn consDescriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button Invitation;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

