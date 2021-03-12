
namespace CsLoginRegister.UserControls
{
    partial class UC_comenzi
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_comenzi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.updatePlante = new System.Windows.Forms.Button();
            this.stergeDaunator = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbSearchBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.updatePlante);
            this.panel1.Controls.Add(this.stergeDaunator);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.cmbSearchBy);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1255, 69);
            this.panel1.TabIndex = 0;
            // 
            // updatePlante
            // 
            this.updatePlante.Dock = System.Windows.Forms.DockStyle.Left;
            this.updatePlante.FlatAppearance.BorderSize = 0;
            this.updatePlante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatePlante.ForeColor = System.Drawing.Color.White;
            this.updatePlante.Image = ((System.Drawing.Image)(resources.GetObject("updatePlante.Image")));
            this.updatePlante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updatePlante.Location = new System.Drawing.Point(294, 0);
            this.updatePlante.Name = "updatePlante";
            this.updatePlante.Size = new System.Drawing.Size(147, 69);
            this.updatePlante.TabIndex = 9;
            this.updatePlante.Text = "Update comanda";
            this.updatePlante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.updatePlante.UseVisualStyleBackColor = true;
            this.updatePlante.Click += new System.EventHandler(this.updatePlante_Click);
            // 
            // stergeDaunator
            // 
            this.stergeDaunator.Dock = System.Windows.Forms.DockStyle.Left;
            this.stergeDaunator.FlatAppearance.BorderSize = 0;
            this.stergeDaunator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stergeDaunator.ForeColor = System.Drawing.Color.White;
            this.stergeDaunator.Image = ((System.Drawing.Image)(resources.GetObject("stergeDaunator.Image")));
            this.stergeDaunator.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stergeDaunator.Location = new System.Drawing.Point(147, 0);
            this.stergeDaunator.Name = "stergeDaunator";
            this.stergeDaunator.Size = new System.Drawing.Size(147, 69);
            this.stergeDaunator.TabIndex = 8;
            this.stergeDaunator.Text = "Sterge comanda";
            this.stergeDaunator.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.stergeDaunator.UseVisualStyleBackColor = true;
            this.stergeDaunator.Click += new System.EventHandler(this.stergeDaunator_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 69);
            this.button1.TabIndex = 7;
            this.button1.Text = "Adauga comanda";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(1028, 23);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(163, 27);
            this.txtSearch.TabIndex = 6;
            // 
            // cmbSearchBy
            // 
            this.cmbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchBy.FormattingEnabled = true;
            this.cmbSearchBy.Items.AddRange(new object[] {
            "idUtilizator",
            "idFurnizor",
            "Sosire",
            "Stare"});
            this.cmbSearchBy.Location = new System.Drawing.Point(875, 23);
            this.cmbSearchBy.Name = "cmbSearchBy";
            this.cmbSearchBy.Size = new System.Drawing.Size(147, 29);
            this.cmbSearchBy.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(761, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cauta dupa:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(5, 586);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1255, 69);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(5, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1255, 512);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // UC_comenzi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UC_comenzi";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1265, 660);
            this.Load += new System.EventHandler(this.UC_comenzi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbSearchBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updatePlante;
        private System.Windows.Forms.Button stergeDaunator;
        private System.Windows.Forms.Button button1;
    }
}
