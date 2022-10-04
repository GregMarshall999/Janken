namespace Janken
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
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.CPU_PIC = new System.Windows.Forms.PictureBox();
            this.PLAYER_PIC = new System.Windows.Forms.PictureBox();
            this.lblCPUChoice = new System.Windows.Forms.Label();
            this.lblPlayerChoice = new System.Windows.Forms.Label();
            this.lblPlayerResult = new System.Windows.Forms.Label();
            this.lblCPUResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CPU_PIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PLAYER_PIC)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRock
            // 
            this.btnRock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRock.Location = new System.Drawing.Point(75, 354);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(114, 58);
            this.btnRock.TabIndex = 0;
            this.btnRock.Tag = "R";
            this.btnRock.Text = "Rock";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.MakeChoiceEvent);
            // 
            // btnPaper
            // 
            this.btnPaper.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPaper.Location = new System.Drawing.Point(343, 354);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(114, 58);
            this.btnPaper.TabIndex = 1;
            this.btnPaper.Tag = "P";
            this.btnPaper.Text = "Paper";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.MakeChoiceEvent);
            // 
            // btnScissors
            // 
            this.btnScissors.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnScissors.Location = new System.Drawing.Point(602, 354);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(114, 58);
            this.btnScissors.TabIndex = 2;
            this.btnScissors.Tag = "S";
            this.btnScissors.Text = "Scissors";
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.MakeChoiceEvent);
            // 
            // CPU_PIC
            // 
            this.CPU_PIC.Location = new System.Drawing.Point(357, 57);
            this.CPU_PIC.Name = "CPU_PIC";
            this.CPU_PIC.Size = new System.Drawing.Size(100, 100);
            this.CPU_PIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CPU_PIC.TabIndex = 3;
            this.CPU_PIC.TabStop = false;
            // 
            // PLAYER_PIC
            // 
            this.PLAYER_PIC.Location = new System.Drawing.Point(357, 188);
            this.PLAYER_PIC.Name = "PLAYER_PIC";
            this.PLAYER_PIC.Size = new System.Drawing.Size(100, 100);
            this.PLAYER_PIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PLAYER_PIC.TabIndex = 4;
            this.PLAYER_PIC.TabStop = false;
            // 
            // lblCPUChoice
            // 
            this.lblCPUChoice.AutoSize = true;
            this.lblCPUChoice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCPUChoice.ForeColor = System.Drawing.Color.White;
            this.lblCPUChoice.Location = new System.Drawing.Point(332, 22);
            this.lblCPUChoice.Name = "lblCPUChoice";
            this.lblCPUChoice.Size = new System.Drawing.Size(138, 21);
            this.lblCPUChoice.TabIndex = 5;
            this.lblCPUChoice.Text = "Computer Choice";
            // 
            // lblPlayerChoice
            // 
            this.lblPlayerChoice.AutoSize = true;
            this.lblPlayerChoice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayerChoice.ForeColor = System.Drawing.Color.White;
            this.lblPlayerChoice.Location = new System.Drawing.Point(343, 309);
            this.lblPlayerChoice.Name = "lblPlayerChoice";
            this.lblPlayerChoice.Size = new System.Drawing.Size(108, 21);
            this.lblPlayerChoice.TabIndex = 6;
            this.lblPlayerChoice.Text = "Player Choice";
            // 
            // lblPlayerResult
            // 
            this.lblPlayerResult.AutoSize = true;
            this.lblPlayerResult.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayerResult.ForeColor = System.Drawing.Color.White;
            this.lblPlayerResult.Location = new System.Drawing.Point(81, 172);
            this.lblPlayerResult.Name = "lblPlayerResult";
            this.lblPlayerResult.Size = new System.Drawing.Size(103, 21);
            this.lblPlayerResult.TabIndex = 7;
            this.lblPlayerResult.Text = "Player Result";
            // 
            // lblCPUResult
            // 
            this.lblCPUResult.AutoSize = true;
            this.lblCPUResult.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCPUResult.ForeColor = System.Drawing.Color.White;
            this.lblCPUResult.Location = new System.Drawing.Point(602, 172);
            this.lblCPUResult.Name = "lblCPUResult";
            this.lblCPUResult.Size = new System.Drawing.Size(133, 21);
            this.lblCPUResult.TabIndex = 8;
            this.lblCPUResult.Text = "Computer Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCPUResult);
            this.Controls.Add(this.lblPlayerResult);
            this.Controls.Add(this.lblPlayerChoice);
            this.Controls.Add(this.lblCPUChoice);
            this.Controls.Add(this.PLAYER_PIC);
            this.Controls.Add(this.CPU_PIC);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Name = "Form1";
            this.Text = "Janken";
            ((System.ComponentModel.ISupportInitialize)(this.CPU_PIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PLAYER_PIC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRock;
        private Button btnPaper;
        private Button btnScissors;
        private PictureBox CPU_PIC;
        private PictureBox PLAYER_PIC;
        private Label lblCPUChoice;
        private Label lblPlayerChoice;
        private Label lblPlayerResult;
        private Label lblCPUResult;
    }
}