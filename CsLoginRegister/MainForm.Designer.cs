
namespace CsLoginRegister
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.informatiiButton = new System.Windows.Forms.Button();
            this.panelSide = new System.Windows.Forms.Panel();
            this.comenziButton = new System.Windows.Forms.Button();
            this.daunatoriButton = new System.Windows.Forms.Button();
            this.planteButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.panelControls = new System.Windows.Forms.Panel();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelLeft.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panelLeft.Controls.Add(this.informatiiButton);
            this.panelLeft.Controls.Add(this.panelSide);
            this.panelLeft.Controls.Add(this.comenziButton);
            this.panelLeft.Controls.Add(this.daunatoriButton);
            this.panelLeft.Controls.Add(this.planteButton);
            this.panelLeft.Controls.Add(this.panel3);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(215, 800);
            this.panelLeft.TabIndex = 1;
            this.panelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLeft_Paint);
            // 
            // informatiiButton
            // 
            this.informatiiButton.FlatAppearance.BorderSize = 0;
            this.informatiiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.informatiiButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informatiiButton.ForeColor = System.Drawing.Color.White;
            this.informatiiButton.Image = ((System.Drawing.Image)(resources.GetObject("informatiiButton.Image")));
            this.informatiiButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.informatiiButton.Location = new System.Drawing.Point(3, 142);
            this.informatiiButton.Name = "informatiiButton";
            this.informatiiButton.Size = new System.Drawing.Size(203, 60);
            this.informatiiButton.TabIndex = 3;
            this.informatiiButton.Text = " Informatii";
            this.informatiiButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.informatiiButton.UseVisualStyleBackColor = true;
            this.informatiiButton.Click += new System.EventHandler(this.informatiiButton_Click);
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.White;
            this.panelSide.Location = new System.Drawing.Point(1, 142);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(7, 60);
            this.panelSide.TabIndex = 1;
            this.panelSide.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSide_Paint);
            // 
            // comenziButton
            // 
            this.comenziButton.FlatAppearance.BorderSize = 0;
            this.comenziButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comenziButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comenziButton.ForeColor = System.Drawing.Color.White;
            this.comenziButton.Image = ((System.Drawing.Image)(resources.GetObject("comenziButton.Image")));
            this.comenziButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.comenziButton.Location = new System.Drawing.Point(3, 336);
            this.comenziButton.Name = "comenziButton";
            this.comenziButton.Size = new System.Drawing.Size(203, 60);
            this.comenziButton.TabIndex = 2;
            this.comenziButton.Text = "     Comenzi";
            this.comenziButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.comenziButton.UseVisualStyleBackColor = true;
            this.comenziButton.Click += new System.EventHandler(this.comenziButton_Click);
            // 
            // daunatoriButton
            // 
            this.daunatoriButton.FlatAppearance.BorderSize = 0;
            this.daunatoriButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.daunatoriButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daunatoriButton.ForeColor = System.Drawing.Color.White;
            this.daunatoriButton.Image = ((System.Drawing.Image)(resources.GetObject("daunatoriButton.Image")));
            this.daunatoriButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.daunatoriButton.Location = new System.Drawing.Point(3, 270);
            this.daunatoriButton.Name = "daunatoriButton";
            this.daunatoriButton.Size = new System.Drawing.Size(203, 60);
            this.daunatoriButton.TabIndex = 2;
            this.daunatoriButton.Text = "     Daunatori";
            this.daunatoriButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.daunatoriButton.UseVisualStyleBackColor = true;
            this.daunatoriButton.Click += new System.EventHandler(this.daunatoriButton_Click);
            // 
            // planteButton
            // 
            this.planteButton.FlatAppearance.BorderSize = 0;
            this.planteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.planteButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planteButton.ForeColor = System.Drawing.Color.White;
            this.planteButton.Image = ((System.Drawing.Image)(resources.GetObject("planteButton.Image")));
            this.planteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.planteButton.Location = new System.Drawing.Point(3, 205);
            this.planteButton.Name = "planteButton";
            this.planteButton.Size = new System.Drawing.Size(203, 60);
            this.planteButton.TabIndex = 2;
            this.planteButton.Text = "    Plante";
            this.planteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.planteButton.UseVisualStyleBackColor = true;
            this.planteButton.Click += new System.EventHandler(this.planteButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 140);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(173, 8);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(38, 29);
            this.button8.TabIndex = 2;
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(67, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "FarmVille";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(79, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Controls.Add(this.labelTime);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(215, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1265, 92);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(1156, 34);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(83, 19);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "HH:MM:SS";
            this.labelTime.Click += new System.EventHandler(this.labelTime_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.exitButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(215, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1265, 48);
            this.panel4.TabIndex = 2;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // exitButton
            // 
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButton.Location = new System.Drawing.Point(1221, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(44, 48);
            this.exitButton.TabIndex = 2;
            this.exitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // panelControls
            // 
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControls.Location = new System.Drawing.Point(215, 140);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(1265, 660);
            this.panelControls.TabIndex = 4;
            this.panelControls.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControls_Paint);
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1480, 800);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelLeft);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelLeft.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Button comenziButton;
        private System.Windows.Forms.Button daunatoriButton;
        private System.Windows.Forms.Button planteButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button informatiiButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Timer timer1;
    }
}

