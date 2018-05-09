using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;
using System.Data;
using FirebirdSql.Data.FirebirdClient;
using System.Collections.Generic;

namespace CSharpEx
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class frmMain : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnProps;
        private SplitContainer splitContainer1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private IContainer components;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private BindingSource checksBindingSource;
        private BindingSource backsBindingSource;
        private TabPage tabPage3;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private Button button2;
        private Button button1;
        private Label label5;
        private TextBox textBox5;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn qntDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn prodavecDataGridViewTextBoxColumn1;
        private DataGridViewCheckBoxColumn selected;
        private Button button3;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn prodavecDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pokupatDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn inn;
        private TextBox textBox6;
        private Button button4;
        private Label label7;
        private Label label6;
        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        public frmMain()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            this.checksBindingSource.DataSource = new checks();
            this.backsBindingSource.DataSource = new backs();
            /* bs = new backs();
             BindingSource bindingb = new BindingSource();
             bindingb.SuspendBinding();
             bindingb.DataSource = bs.values;
             bindingb.ResumeBinding();

             dataGridView2.DataSource = bindingb;*/




            myTimer.Tick += new EventHandler(TimerEventProcessor);

            // Sets the timer interval to 5 seconds.
            myTimer.Interval = 1000;
            myTimer.Start();


        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnProps = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodavecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pokupatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qntDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodavecDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.backsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checksBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backsBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(7, 11);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(112, 32);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Возврат";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnProps
            // 
            this.btnProps.Location = new System.Drawing.Point(121, 11);
            this.btnProps.Name = "btnProps";
            this.btnProps.Size = new System.Drawing.Size(112, 32);
            this.btnProps.TabIndex = 1;
            this.btnProps.Text = "Настройка свойств";
            this.btnProps.Click += new System.EventHandler(this.btnProps_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.button4);
            this.splitContainer1.Panel1.Controls.Add(this.textBox6);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.btnStart);
            this.splitContainer1.Panel1.Controls.Add(this.btnProps);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2.Enter += new System.EventHandler(this.splitContainer1_Panel2_Enter);
            this.splitContainer1.Panel2.Leave += new System.EventHandler(this.splitContainer1_Panel2_Leave);
            this.splitContainer1.Size = new System.Drawing.Size(918, 376);
            this.splitContainer1.SplitterDistance = 45;
            this.splitContainer1.TabIndex = 3;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(320, 17);
            this.textBox6.Name = "textBox6";
            this.textBox6.PasswordChar = '*';
            this.textBox6.Size = new System.Drawing.Size(79, 20);
            this.textBox6.TabIndex = 3;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button3.Location = new System.Drawing.Point(239, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 31);
            this.button3.TabIndex = 2;
            this.button3.Text = "Сброс";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(915, 324);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Enter += new System.EventHandler(this.tabControl1_Enter);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(907, 298);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Продажи";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.prodavecDataGridViewTextBoxColumn,
            this.pokupatDataGridViewTextBoxColumn,
            this.sumDataGridViewTextBoxColumn,
            this.inn});
            this.dataGridView1.DataSource = this.checksBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(901, 292);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodavecDataGridViewTextBoxColumn
            // 
            this.prodavecDataGridViewTextBoxColumn.DataPropertyName = "prodavec";
            this.prodavecDataGridViewTextBoxColumn.HeaderText = "Продавец";
            this.prodavecDataGridViewTextBoxColumn.Name = "prodavecDataGridViewTextBoxColumn";
            this.prodavecDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pokupatDataGridViewTextBoxColumn
            // 
            this.pokupatDataGridViewTextBoxColumn.DataPropertyName = "pokupat";
            this.pokupatDataGridViewTextBoxColumn.HeaderText = "Покупатель";
            this.pokupatDataGridViewTextBoxColumn.Name = "pokupatDataGridViewTextBoxColumn";
            this.pokupatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sumDataGridViewTextBoxColumn
            // 
            this.sumDataGridViewTextBoxColumn.DataPropertyName = "sum";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.sumDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.sumDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.sumDataGridViewTextBoxColumn.Name = "sumDataGridViewTextBoxColumn";
            this.sumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inn
            // 
            this.inn.DataPropertyName = "inn";
            this.inn.HeaderText = "ИНН";
            this.inn.Name = "inn";
            this.inn.ReadOnly = true;
            // 
            // checksBindingSource
            // 
            this.checksBindingSource.DataSource = typeof(CSharpEx.checks);
            this.checksBindingSource.CurrentChanged += new System.EventHandler(this.checksBindingSource_CurrentChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(907, 298);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Возвраты";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.qntDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.prodavecDataGridViewTextBoxColumn1,
            this.selected});
            this.dataGridView2.DataSource = this.backsBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(901, 292);
            this.dataGridView2.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // qntDataGridViewTextBoxColumn
            // 
            this.qntDataGridViewTextBoxColumn.DataPropertyName = "qnt";
            this.qntDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.qntDataGridViewTextBoxColumn.Name = "qntDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // prodavecDataGridViewTextBoxColumn1
            // 
            this.prodavecDataGridViewTextBoxColumn1.DataPropertyName = "prodavec";
            this.prodavecDataGridViewTextBoxColumn1.HeaderText = "Продавец";
            this.prodavecDataGridViewTextBoxColumn1.Name = "prodavecDataGridViewTextBoxColumn1";
            // 
            // selected
            // 
            this.selected.DataPropertyName = "selected";
            this.selected.HeaderText = "Выбрать";
            this.selected.Name = "selected";
            // 
            // backsBindingSource
            // 
            this.backsBindingSource.DataSource = typeof(CSharpEx.backs);
            this.backsBindingSource.CurrentChanged += new System.EventHandler(this.backsBindingSource_CurrentChanged_1);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox5);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.textBox4);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(907, 298);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Предоплата";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            this.tabPage3.Enter += new System.EventHandler(this.tabPage3_Enter);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(77, 112);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(149, 20);
            this.textBox5.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Кассир: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Вернуть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Приянть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Сумма";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(393, 21);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 6;
            this.textBox4.Text = "300";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(287, 21);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "300";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Цена";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(204, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(77, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "1";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Наименование";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Микросхема";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(406, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Пользователь";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(502, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(805, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 6;
            // 
            // frmMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(918, 376);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmMain";
            this.Text = "Касса";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checksBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backsBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            Application.Run(new frmMain());
        }

        private FprnM1C.IFprnM45 ECR;
        private void frmMain_Load(object sender, System.EventArgs e)
        {
            try
            {
                ECR = new FprnM1C.FprnM45();
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось создать объект общего драйвера ККМ!", Application.ProductName,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Close();
            }
        }

        private void Demo()
        {
            // занимаем порт
            ECR.DeviceEnabled = true;
            if (ECR.ResultCode != 0)
                return;

            // получаем состояние ККМ
            if (ECR.GetStatus() != 0)
                return;

            // проверяем на всякий случай ККМ на фискализированность
            if (ECR.Fiscal)
                if (MessageBox.Show("ККМ фискализирована! Вы действительно хотите продолжить?",
                        Application.ProductName,
                        System.Windows.Forms.MessageBoxButtons.YesNo,
                        System.Windows.Forms.MessageBoxIcon.Question) == DialogResult.No)
                    return;

            // если есть открытый чек, то отменяем его
            if (ECR.CheckState != 0)
                if (ECR.CancelCheck() != 0)
                    return;

            // если смена открыта снимаем Z-отчет
            if (ECR.SessionOpened)
            {
                // устанавливаем пароль системного администратора ККМ
                ECR.Password = "30";
                // входим в режим отчетов с гашением
                ECR.Mode = 3;
                if (ECR.SetMode() != 0)
                    return;
                // снимаем отчет
                ECR.ReportType = 1;
                if (ECR.Report() != 0)
                    return;
            }

            // входим в режим регистрации
            // устанавливаем пароль кассира
            ECR.Password = "1";
            // входим в режим регистрации
            ECR.Mode = 1;
            if (ECR.SetMode() != 0)
                return;

            // продажа без сдачи
            // регистрация продажи
            ECR.Name = "Молоко";
            ECR.Price = 10.45;
            ECR.Quantity = 1;
            ECR.Department = 2;
            if (ECR.Registration() != 0)
                return;
            // скидка суммой на предыдущую позицию
            ECR.Percents = 10;
            ECR.Destination = 1;
            if (ECR.PercentsDiscount() != 0)
                return;
            // регистрация продажи
            ECR.Name = "Фанта";
            ECR.Price = 25;
            ECR.Quantity = 5;
            ECR.Department = 1;
            if (ECR.Registration() != 0)
                return;
            // скидка суммой на весь чек
            ECR.Summ = 10.40;
            ECR.Destination = 0;
            if (ECR.SummDiscount() != 0)
                return;
            // закрытие чека наличными без ввода полученной от клиента суммы
            ECR.TypeClose = 0;
            if (ECR.CloseCheck() != 0)
                return;

            // продажа со сдачей
            // регистрация продажи
            ECR.Name = "Молоко";
            ECR.Price = 10.45;
            ECR.Quantity = 1;
            ECR.Department = 2;
            if (ECR.Registration() != 0)
                return;
            // регистрация продажи
            ECR.Name = "Пепси-кола";
            ECR.Price = 25.00;
            ECR.Quantity = 5;
            ECR.Department = 1;
            if (ECR.Registration() != 0)
                return;
            // сторно предыдущей регистрации
            if (ECR.Storno() != 0)
                return;
            // регистрация продажи
            ECR.Name = "Фанта";
            ECR.Price = 25;
            ECR.Quantity = 5;
            ECR.Department = 1;
            if (ECR.Registration() != 0)
                return;
            // скидка суммой на весь чек
            ECR.Summ = 50;
            ECR.Destination = 0;
            if (ECR.SummDiscount() != 0)
                return;
            // закрытие чека наличными с вводом полученной от клиента суммы
            ECR.Summ = 100;
            ECR.TypeClose = 0;
            if (ECR.Delivery() != 0)
                return;

            // аннулирование
            // регистрация аннулирования
            ECR.Name = "Dirol";
            ECR.Price = 7;
            ECR.Quantity = 1;
            if (ECR.Annulate() != 0)
                return;
            // регистрация аннулирования
            ECR.Name = "Orbit";
            ECR.Price = 8;
            ECR.Quantity = 2;
            if (ECR.Annulate() != 0)
                return;
            // закрытие чека
            ECR.TypeClose = 0;
            if (ECR.CloseCheck() != 0)
                return;

            // возврат
            // регистрация возврата
            ECR.Name = "Молоко";
            ECR.Price = 10.45;
            ECR.Quantity = 1;
            if (ECR.Return() != 0)
                return;
            // регистрация возврата
            ECR.Name = "Колбаса";
            ECR.Price = 99.99;
            ECR.Quantity = 1.235;
            if (ECR.Return() != 0)
                return;
            // скидка суммой на весь чек
            ECR.Summ = 50;
            ECR.Destination = 0;
            if (ECR.SummDiscount() != 0)
                return;
            // закрытие чека
            ECR.TypeClose = 0;
            if (ECR.CloseCheck() != 0)
                return;

            // внесение наличности
            ECR.Summ = 400.50;
            if (ECR.CashIncome() != 0)
                return;

            // выплата наличности
            ECR.Summ = 121.34;
            if (ECR.CashOutcome() != 0)
                return;

            // X - отчет
            // устанавливаем пароль администратора ККМ
            ECR.Password = "29";
            // входим в режим отчетов без гашения
            ECR.Mode = 2;
            if (ECR.SetMode() != 0)
                return;
            // снимаем отчет
            ECR.ReportType = 2;
            if (ECR.Report() != 0)
                return;

            // Z - отчет
            // устанавливаем пароль системного администратора ККМ
            ECR.Password = "30";
            // входим в режим отчетов с гашением
            ECR.Mode = 3;
            if (ECR.SetMode() != 0)
                return;
            // снимаем отчет
            ECR.ReportType = 1;
            if (ECR.Report() != 0)
                return;

            // выходим в режим выбора, чтобы кто-то под введенными паролями не сделал что нибуть нехорошее
            if (ECR.ResetMode() != 0)
                return;

            // освобождаем порт
            ECR.DeviceEnabled = false;
            if (ECR.ResultCode != 0)
                return;

            MessageBox.Show("Все операции успешно выполнены.",
                Application.ProductName,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnStart_Click(object sender, System.EventArgs e)
        {
            if (label7.Text.Length == 0) return;
            Boolean flag = false;
            var list = (backs)this.backsBindingSource.DataSource;
            foreach (var l in list) flag = flag || l.selected;
            if (!flag) return;
            var result = MessageBox.Show("НАЛИЧНЫЕ - ДА!!!\r\nКАРТА - НЕТ!!!\r\nОплата наличными?", "Выберите способ оплаты", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result != DialogResult.Cancel)
            {
                var payment = result == DialogResult.Yes ? 0 : 1;

                foreach (strokavozvrata row in list)
                {
                    if (row.selected)
                    {
                        if (flag)
                        {
                            flag = false;

                            ECR.DeviceEnabled = true;
                            if (ECR.ResultCode != 0)
                                return;

                            // получаем состояние ККМ
                            if (ECR.GetStatus() != 0)
                                return;

                            // если есть открытый чек, то отменяем его
                            if (ECR.CheckState != 0)
                                if (ECR.CancelCheck() != 0)
                                    return;
                            //входим в режим

                            ECR.Mode = 1;
                            if (ECR.SetMode() != 0)
                                return;
                            ECR.CheckMode = 1;
                            ECR.CheckType = 2;
                            ECR.OpenCheck();
                            ECR.AttrNumber = 1021;
                            ECR.AttrValue = "Кассир " + label6.Text;
                            ECR.WriteAttribute();
                            ECR.AttrNumber = 1203;
                            ECR.AttrValue = label7.Text;
                            ECR.WriteAttribute();

                        }
                        ECR.Name = row.name;
                        ECR.Price = Math.Round(row.price, 2);
                        ECR.Quantity = row.qnt;
                        ECR.DiscountValue = 0;
                        ECR.Department = 1;
                        if (ECR.Registration() != 0)
                            return;
                        row.selected = false;
                    }

                }
                if (!flag)
                {
                    ECR.TypeClose = payment;

                    if (ECR.CloseCheck() != 0)
                        return;
                    ECR.DeviceEnabled = false;
                }
            }
        }

        private void btnProps_Click(object sender, System.EventArgs e)
        {
            ECR.ShowProperties();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }
        private void hide(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            myTimer.Stop();
            ((checks)this.checksBindingSource.DataSource).get();
            //Action action = () =>
            //{

            /*foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                Boolean f = (Boolean)row.Cells[4].Value;
                if (f)
                {
                    if (checkBox1.Checked) row.Visible = true;
                    else
                    {
                        if (dataGridView1.CurrentRow != row) row.Visible = false;
                        if (!row.Cells[4].ReadOnly)
                        {
                            row.Cells[4].ReadOnly = true;
                            //включаем
                            ECR.DeviceEnabled = true;
                            if (ECR.ResultCode != 0)
                                return;

                            // получаем состояние ККМ
                            if (ECR.GetStatus() != 0)
                                return;

                            // если есть открытый чек, то отменяем его
                            if (ECR.CheckState != 0)
                                if (ECR.CancelCheck() != 0)
                                    return;
                            //входим в режим
                            
                            //if ((String)row.Cells[1].Value == "Козлов П. В.")
                            //    ECR.Password = "2";
                            //else
                            //    ECR.Password = "1";
                            ECR.Mode = 1;
                            if (ECR.SetMode() != 0)
                                return;
                            ECR.CheckMode = 1;
                            ECR.CheckType = 1;
                            ECR.OpenCheck();
                            ECR.AttrNumber = 1021;
                            ECR.AttrValue = "Кассир " + (String)row.Cells[1].Value;
                            ECR.WriteAttribute();
                            ECR.AttrNumber = 1203;
                            ECR.AttrValue = "701701633740";
                            ECR.WriteAttribute();
                            var ls = sale((String)row.Cells[1].Value, (DateTime)row.Cells[0].Value);
                            foreach (var l in ls)
                            {
                                ECR.Name = l.name;
                                ECR.Price = l.price;
                                ECR.Quantity = l.qnt;
                                ECR.Department = 1;
                                if (ECR.Registration() != 0)
                                    return;
                            }
                            if ((String)row.Cells[3].Value == "Наличные")
                                ECR.TypeClose = 0;
                            else
                                ECR.TypeClose = 1;
                            if (ECR.CloseCheck() != 0)
                                return;
                        }
                    }
                }
                else
                {
                    if (checkBox2.Checked)
                    {
                        row.Cells[4].Value = true;
                        
                    }
                }
            }
            //};
            // this.Invoke(action);

           */
            myTimer.Enabled = true;
        }


        public List<stroka> sale(string staff, DateTime date1)
        {
            List<stroka> ret = new List<stroka>();
            try
            {
                FbConnection fb = new FbConnection(connection.connectionString());
                fb.Open();
                FbTransaction fbt = fb.BeginTransaction(); //стартуем транзакцию; стартовать транзакцию можно только для открытой базы (т.е. мутод Open() уже был вызван ранее, иначе ошибка)

                FbCommand SelectSQL = new FbCommand();
                SelectSQL.CommandText = "select d.name,a.price,a.quanshop, coalesce(a.priceshop,a.price) from shoplog a, staff b, goods c, name d where b.id = a.staff_id and b.fullname=@staff and a.goodscode = c.goodscode and c.namecode = d.namecode and datatime=@datatime"; //задаем запрос на выборку
                SelectSQL.Parameters.Add("@datatime", date1);
                SelectSQL.Parameters.Add("@staff", staff);
                SelectSQL.Connection = fb;
                SelectSQL.Transaction = fbt; //необходимо проинициализить транзакцию для объекта SelectSQL
                FbDataReader reader = SelectSQL.ExecuteReader(); //для запросов, которые возвращают результат в виде набора данных надо использоваться метод ExecuteReader()
                try
                {
                    while (reader.Read()) //пока не прочли все данные выполняем...
                    {
                        var nch = new stroka(reader.GetString(0), reader.GetInt16(2), reader.GetDouble(1), reader.GetDouble(3));
                        ret.Add(nch);
                    }

                }

                finally
                {
                    //всегда необходимо вызывать метод Close(), когда чтение данных завершено
                    reader.Close();
                    fbt.Commit();
                    fb.Close(); //закрываем соединение, т.к. оно нам больше не нужно
                }
                SelectSQL.Dispose();
                return ret;
            }
            catch
            {
                return null;
            }
        }



        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Enter(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Leave(object sender, EventArgs e)
        {

        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            ((backs)this.backsBindingSource.DataSource).get();
            //Action action = () =>
            btnStart.Enabled = true;

        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            btnStart.Enabled = false;

        }

        private void backsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void checkBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            myTimer.Stop();
            if (label7.Text.Length > 0)
            { 
            var result = MessageBox.Show("НАЛИЧНЫЕ - ДА!!!\r\nКАРТА - НЕТ!!!\r\nОплата наличными?", "Выберите способ оплаты", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result != DialogResult.Cancel)
                {
                    var row = dataGridView1.Rows[e.RowIndex];
                    var payment = result == DialogResult.Yes ? 0 : 1;
                    ECR.DeviceEnabled = true;
                    var error = ECR.ResultCode;
                    if (ECR.ResultCode != 0)
                    {
                        MessageBox.Show(error.ToString(), "Ошибка кассы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    // получаем состояние ККМ
                    error = ECR.GetStatus();
                    if (error != 0)
                    {
                        MessageBox.Show(error.ToString(), "Ошибка кассы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // если есть открытый чек, то отменяем его
                    if (ECR.CheckState != 0)
                    {
                        error = ECR.CancelCheck();
                        if (error != 0)
                        {
                            MessageBox.Show(error.ToString(), "Ошибка кассы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    //входим в режим
                    ECR.Mode = 1;
                    error = ECR.SetMode();
                    if (error != 0)
                    {
                        var textErorr = error == -3822 ? "Текущая смена превысила 24 часа" : error.ToString();
                        MessageBox.Show(textErorr, "Ошибка кассы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    ECR.CheckMode = 1;
                    ECR.CheckType = 1;
                    ECR.OpenCheck();
                    ECR.AttrNumber = 1021;
                    ECR.AttrValue = "Кассир " + label6.Text;
                    ECR.WriteAttribute();
                    ECR.AttrNumber = 1203;
                    ECR.AttrValue = label7.Text;
                    ECR.WriteAttribute();
                    List<stroka> ls = null;
                    double disc = 0;
                    while (ls == null)
                        ls = sale((String)row.Cells[1].Value, (DateTime)row.Cells[0].Value);
                    foreach (var l in ls)
                    {
                        ECR.Name = l.name;
                        ECR.Price = Math.Round(l.roznprice, 2);
                        ECR.Quantity = l.qnt;
                        ECR.ItemType = 1;//товар
                        ECR.Department = 1;
                        disc += Math.Round((l.roznprice - l.price) * l.qnt, 2);
                        ECR.DiscountValue = Math.Round((l.roznprice - l.price) * l.qnt, 2);
                        ECR.DiscountType = 0;//суммовая скидка
                        if (ECR.Registration() != 0)
                            return;
                    }
                    if (disc > 0)
                    {
                        ECR.Caption = "Ваша скидка:";
                        ECR.PrintString();
                        ECR.Caption = disc.ToString() + " руб.";
                        ECR.PrintString();
                    }
                    ECR.TypeClose = payment;
                    error = ECR.CloseCheck();
                    ECR.DeviceEnabled = false;
                    if (error != 0)
                    {
                        MessageBox.Show(error.ToString(), "Ошибка кассы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (!((checks)this.checksBindingSource.DataSource).delete((DateTime)row.Cells[0].Value, (String)row.Cells[1].Value))
                        MessageBox.Show("Ошибка базы", "Информация не сохранена!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                myTimer.Start();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            if (int.TryParse(this.textBox2.Text, out i))
                this.textBox4.Text = Math.Round((i * double.Parse(this.textBox3.Text)), 2).ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            double d = 0;
            this.textBox3.Text = this.textBox3.Text.Replace(".", ",");
            if (double.TryParse(this.textBox3.Text, out d))
            {
                //d = Math.Round(d, 2);
               // this.textBox3.Text = d.ToString();
                this.textBox4.Text = Math.Round((int.Parse(this.textBox2.Text) * d), 2).ToString();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            double d = 0;
            this.textBox4.Text = this.textBox4.Text.Replace(".", ",");
            if (double.TryParse(this.textBox4.Text, out d))
            {
               // d = Math.Round(d, 2);
               // this.textBox4.Text = d.ToString();
                this.textBox3.Text = Math.Round((d / int.Parse(this.textBox2.Text)), 2).ToString();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show("НАЛИЧНЫЕ - ДА!!!\r\nКАРТА - НЕТ!!!\r\nОплата наличными?", "Выберите способ оплаты", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result != DialogResult.Cancel)
            {
                predoplata(1, result==DialogResult.Yes ? 0 : 1);
            }
        }
        public void predoplata(int type,int payment)
        {
            if (label7.Text.Length == 0) return;
            ECR.DeviceEnabled = true;
            var error = ECR.ResultCode;
            if (ECR.ResultCode != 0)
            {
                MessageBox.Show(error.ToString(), "Ошибка кассы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // получаем состояние ККМ
            error = ECR.GetStatus();
            if (error != 0)
            {
                MessageBox.Show(error.ToString(), "Ошибка кассы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // если есть открытый чек, то отменяем его
            if (ECR.CheckState != 0)
            {
                error = ECR.CancelCheck();
                if (error != 0)
                {
                    MessageBox.Show(error.ToString(), "Ошибка кассы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            //входим в режим
            ECR.Mode = 1;
            error = ECR.SetMode();
            if (error != 0)
            {
                var textErorr = error == -3822 ? "Текущая смена превысила 24 часа" : error.ToString();
                MessageBox.Show(textErorr, "Ошибка кассы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ECR.CheckMode = 1;
            ECR.CheckType = type;
            ECR.OpenCheck();
            ECR.AttrNumber = 1021;
            ECR.AttrValue = "Кассир " + label6.Text;
            ECR.WriteAttribute();
            ECR.AttrNumber = 1203;
            ECR.AttrValue = label7.Text;
            ECR.WriteAttribute();
            ECR.Name = this.textBox1.Text;
            double price = 0;
            double.TryParse(this.textBox3.Text,out price);
            ECR.Price = price;
            ECR.DiscountValue = 0;
            ECR.Quantity = int.Parse(this.textBox2.Text);
            ECR.ItemType = 1;//товар
            ECR.PaymentMode = 3;
            ECR.Department = 1;
            if (ECR.Registration() != 0)
                    return;            
            ECR.TypeClose = payment;
            error = ECR.CloseCheck();
            ECR.DeviceEnabled = false;
            if (error != 0)
            {
                MessageBox.Show(error.ToString(), "Ошибка кассы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("НАЛИЧНЫЕ - ДА!!!\r\nКАРТА - НЕТ!!!\r\nОплата наличными?", "Выберите способ оплаты", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result != DialogResult.Cancel)
            {
                predoplata(2, result == DialogResult.Yes ? 0 : 1);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ECR.DeviceEnabled = true;
            var error = ECR.ResultCode;
            if (ECR.ResultCode != 0)
            {
                MessageBox.Show(error.ToString(), "Ошибка кассы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // получаем состояние ККМ
            error = ECR.GetStatus();
            if (error != 0)
            {
                MessageBox.Show(error.ToString(), "Ошибка кассы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // если есть открытый чек, то отменяем его
            if (ECR.CheckState != 0)
            {
                error = ECR.CancelCheck();
                if (error != 0)
                {
                    MessageBox.Show(error.ToString(), "Ошибка кассы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            ECR.DeviceEnabled = false;
        }

        private void backsBindingSource_CurrentChanged_1(object sender, EventArgs e)
        {

        }

        private void checksBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var user = new user(textBox6.Text);
            label6.Text = user.fullname;
            label7.Text = user.inn;
        }
    }
}

