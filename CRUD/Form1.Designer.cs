namespace CRUD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textPO = new System.Windows.Forms.TextBox();
            this.textSN = new System.Windows.Forms.TextBox();
            this.textTU = new System.Windows.Forms.TextBox();
            this.textPN = new System.Windows.Forms.TextBox();
            this.textTN = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(13, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Box info";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 44);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 2;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Product Order";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tray Unit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tray Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Serial Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Part Number";
            // 
            // textPO
            // 
            this.textPO.Location = new System.Drawing.Point(200, 50);
            this.textPO.Name = "textPO";
            this.textPO.Size = new System.Drawing.Size(310, 23);
            this.textPO.TabIndex = 8;
            this.textPO.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textSN
            // 
            this.textSN.Location = new System.Drawing.Point(200, 112);
            this.textSN.Name = "textSN";
            this.textSN.Size = new System.Drawing.Size(310, 23);
            this.textSN.TabIndex = 9;
            this.textSN.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textTU
            // 
            this.textTU.Location = new System.Drawing.Point(200, 181);
            this.textTU.Name = "textTU";
            this.textTU.Size = new System.Drawing.Size(310, 23);
            this.textTU.TabIndex = 10;
            this.textTU.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textPN
            // 
            this.textPN.Location = new System.Drawing.Point(200, 79);
            this.textPN.Name = "textPN";
            this.textPN.Size = new System.Drawing.Size(310, 23);
            this.textPN.TabIndex = 11;
            // 
            // textTN
            // 
            this.textTN.Location = new System.Drawing.Point(200, 146);
            this.textTN.Name = "textTN";
            this.textTN.Size = new System.Drawing.Size(310, 23);
            this.textTN.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(540, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Refrech";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.PO,
            this.PN,
            this.SN,
            this.TN,
            this.TU});
            this.dataGridView1.Location = new System.Drawing.Point(31, 258);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(647, 130);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // PO
            // 
            this.PO.HeaderText = "Product Order";
            this.PO.Name = "PO";
            // 
            // PN
            // 
            this.PN.HeaderText = "Part Number";
            this.PN.Name = "PN";
            // 
            // SN
            // 
            this.SN.HeaderText = "Serial Number";
            this.SN.Name = "SN";
            // 
            // TN
            // 
            this.TN.HeaderText = "Tray Number";
            this.TN.Name = "TN";
            // 
            // TU
            // 
            this.TU.HeaderText = "Tray Unit";
            this.TU.Name = "TU";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(382, 229);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(224, 229);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Edit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 400);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textTN);
            this.Controls.Add(this.textPN);
            this.Controls.Add(this.textTU);
            this.Controls.Add(this.textSN);
            this.Controls.Add(this.textPO);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "FormAdd";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textPO;
        private TextBox textSN;
        private TextBox textTU;
        private TextBox textPN;
        private TextBox textTN;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn PO;
        private DataGridViewTextBoxColumn PN;
        private DataGridViewTextBoxColumn SN;
        private DataGridViewTextBoxColumn TN;
        private DataGridViewTextBoxColumn TU;
        private Button button3;
        private Button button4;
    }
}