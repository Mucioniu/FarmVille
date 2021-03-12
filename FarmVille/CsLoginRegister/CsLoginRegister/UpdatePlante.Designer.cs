
namespace CsLoginRegister
{
    partial class UpdatePlante
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
            this.categoriePlantetext = new System.Windows.Forms.TextBox();
            this.idCategoriePlante = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.perRecoltare = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.perPlantare = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.denPopulara = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.denStiintifica = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.categoriePlantetext);
            this.panel1.Controls.Add(this.idCategoriePlante);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.perRecoltare);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.perPlantare);
            this.panel1.Controls.Add(this.label4);
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
            this.dataGridView1.Location = new System.Drawing.Point(13, 317);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(928, 175);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // categoriePlantetext
            // 
            this.categoriePlantetext.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.categoriePlantetext.Location = new System.Drawing.Point(252, 89);
            this.categoriePlantetext.Name = "categoriePlantetext";
            this.categoriePlantetext.Size = new System.Drawing.Size(471, 27);
            this.categoriePlantetext.TabIndex = 25;
            // 
            // idCategoriePlante
            // 
            this.idCategoriePlante.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.idCategoriePlante.AutoSize = true;
            this.idCategoriePlante.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idCategoriePlante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.idCategoriePlante.Location = new System.Drawing.Point(79, 97);
            this.idCategoriePlante.Name = "idCategoriePlante";
            this.idCategoriePlante.Size = new System.Drawing.Size(157, 19);
            this.idCategoriePlante.TabIndex = 24;
            this.idCategoriePlante.Text = "Id Categorie Plante";
            // 
            // closeButton
            // 
            this.closeButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.closeButton.Location = new System.Drawing.Point(661, 528);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(99, 36);
            this.closeButton.TabIndex = 22;
            this.closeButton.Text = "Inchide";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.saveButton.Location = new System.Drawing.Point(791, 528);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(99, 36);
            this.saveButton.TabIndex = 21;
            this.saveButton.Text = "Update";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // perRecoltare
            // 
            this.perRecoltare.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.perRecoltare.Location = new System.Drawing.Point(252, 253);
            this.perRecoltare.Name = "perRecoltare";
            this.perRecoltare.Size = new System.Drawing.Size(471, 27);
            this.perRecoltare.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(79, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Perioada recoltare";
            // 
            // perPlantare
            // 
            this.perPlantare.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.perPlantare.Location = new System.Drawing.Point(252, 216);
            this.perPlantare.Name = "perPlantare";
            this.perPlantare.Size = new System.Drawing.Size(471, 27);
            this.perPlantare.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(79, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Perioada plantare";
            // 
            // denPopulara
            // 
            this.denPopulara.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.denPopulara.Location = new System.Drawing.Point(252, 174);
            this.denPopulara.Name = "denPopulara";
            this.denPopulara.Size = new System.Drawing.Size(471, 27);
            this.denPopulara.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(79, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Denumire populara";
            // 
            // denStiintifica
            // 
            this.denStiintifica.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.denStiintifica.Location = new System.Drawing.Point(252, 134);
            this.denStiintifica.Name = "denStiintifica";
            this.denStiintifica.Size = new System.Drawing.Size(471, 27);
            this.denStiintifica.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(79, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Denumire stiintifica";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(350, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Modifica o planta";
            // 
            // UpdatePlante
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(974, 607);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UpdatePlante";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdatePlante";
            this.Load += new System.EventHandler(this.UpdatePlante_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox perRecoltare;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox perPlantare;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox denPopulara;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox denStiintifica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox categoriePlantetext;
        private System.Windows.Forms.Label idCategoriePlante;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}