
namespace CsLoginRegister
{
    partial class updateDaunator
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.categorieDaunator = new System.Windows.Forms.TextBox();
            this.idDaunator = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.denPopulara = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.denStiintifica = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.marime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.culoare = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.planteAtacate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.marime);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.culoare);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.planteAtacate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.categorieDaunator);
            this.panel1.Controls.Add(this.idDaunator);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.denPopulara);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.denStiintifica);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 591);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Silver;
            this.dataGridView1.Location = new System.Drawing.Point(15, 314);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(928, 175);
            this.dataGridView1.TabIndex = 40;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // categorieDaunator
            // 
            this.categorieDaunator.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.categorieDaunator.Location = new System.Drawing.Point(254, 86);
            this.categorieDaunator.Name = "categorieDaunator";
            this.categorieDaunator.Size = new System.Drawing.Size(471, 27);
            this.categorieDaunator.TabIndex = 39;
            // 
            // idDaunator
            // 
            this.idDaunator.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.idDaunator.AutoSize = true;
            this.idDaunator.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idDaunator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.idDaunator.Location = new System.Drawing.Point(66, 94);
            this.idDaunator.Name = "idDaunator";
            this.idDaunator.Size = new System.Drawing.Size(100, 19);
            this.idDaunator.TabIndex = 38;
            this.idDaunator.Text = "Id Daunator";
            // 
            // closeButton
            // 
            this.closeButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.closeButton.Location = new System.Drawing.Point(663, 525);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(99, 36);
            this.closeButton.TabIndex = 37;
            this.closeButton.Text = "Inchide";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.saveButton.Location = new System.Drawing.Point(793, 525);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(99, 36);
            this.saveButton.TabIndex = 36;
            this.saveButton.Text = "Update";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // denPopulara
            // 
            this.denPopulara.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.denPopulara.Location = new System.Drawing.Point(254, 171);
            this.denPopulara.Name = "denPopulara";
            this.denPopulara.Size = new System.Drawing.Size(471, 27);
            this.denPopulara.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(64, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 19);
            this.label3.TabIndex = 30;
            this.label3.Text = "Denumire populara";
            // 
            // denStiintifica
            // 
            this.denStiintifica.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.denStiintifica.Location = new System.Drawing.Point(254, 131);
            this.denStiintifica.Name = "denStiintifica";
            this.denStiintifica.Size = new System.Drawing.Size(471, 27);
            this.denStiintifica.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(64, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Denumire stiintifica";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(352, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "Modifica un daunator";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // marime
            // 
            this.marime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.marime.Location = new System.Drawing.Point(254, 270);
            this.marime.Name = "marime";
            this.marime.Size = new System.Drawing.Size(471, 27);
            this.marime.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label7.Location = new System.Drawing.Point(64, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 19);
            this.label7.TabIndex = 45;
            this.label7.Text = "Marime";
            // 
            // culoare
            // 
            this.culoare.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.culoare.Location = new System.Drawing.Point(254, 237);
            this.culoare.Name = "culoare";
            this.culoare.Size = new System.Drawing.Size(471, 27);
            this.culoare.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(64, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 43;
            this.label5.Text = "Culoare";
            // 
            // planteAtacate
            // 
            this.planteAtacate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.planteAtacate.Location = new System.Drawing.Point(254, 204);
            this.planteAtacate.Name = "planteAtacate";
            this.planteAtacate.Size = new System.Drawing.Size(471, 27);
            this.planteAtacate.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(64, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 19);
            this.label4.TabIndex = 41;
            this.label4.Text = "Partile plantei atacate";
            // 
            // updateDaunator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(974, 607);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "updateDaunator";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "updateDaunator";
            this.Load += new System.EventHandler(this.updateDaunator_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox categorieDaunator;
        private System.Windows.Forms.Label idDaunator;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox denPopulara;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox denStiintifica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox marime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox culoare;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox planteAtacate;
        private System.Windows.Forms.Label label4;
    }
}