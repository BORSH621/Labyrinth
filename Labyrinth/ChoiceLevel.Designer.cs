namespace Labyrinth
{
    partial class ChoiceLevel
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
            this.GoToMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FirstLevel = new System.Windows.Forms.Button();
            this.SecondLevel = new System.Windows.Forms.Button();
            this.ThirdLevel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FourthLevel = new System.Windows.Forms.Button();
            this.FivethLevel = new System.Windows.Forms.Button();
            this.SixthLevel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GoToMenu
            // 
            this.GoToMenu.BackColor = System.Drawing.Color.Lime;
            this.GoToMenu.Location = new System.Drawing.Point(689, 388);
            this.GoToMenu.Name = "GoToMenu";
            this.GoToMenu.Size = new System.Drawing.Size(99, 50);
            this.GoToMenu.TabIndex = 1;
            this.GoToMenu.Text = "В меню";
            this.GoToMenu.UseVisualStyleBackColor = false;
            this.GoToMenu.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(273, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выбор уровня";
            // 
            // FirstLevel
            // 
            this.FirstLevel.BackColor = System.Drawing.Color.DarkGreen;
            this.FirstLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstLevel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FirstLevel.Location = new System.Drawing.Point(122, 79);
            this.FirstLevel.Name = "FirstLevel";
            this.FirstLevel.Size = new System.Drawing.Size(130, 130);
            this.FirstLevel.TabIndex = 3;
            this.FirstLevel.Text = "1";
            this.FirstLevel.UseVisualStyleBackColor = false;
            this.FirstLevel.Click += new System.EventHandler(this.FirstLevel_Click_1);
            // 
            // SecondLevel
            // 
            this.SecondLevel.BackColor = System.Drawing.Color.DarkGreen;
            this.SecondLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondLevel.Location = new System.Drawing.Point(322, 79);
            this.SecondLevel.Name = "SecondLevel";
            this.SecondLevel.Size = new System.Drawing.Size(130, 130);
            this.SecondLevel.TabIndex = 4;
            this.SecondLevel.Text = "2";
            this.SecondLevel.UseVisualStyleBackColor = false;
            this.SecondLevel.Click += new System.EventHandler(this.SecondLevel_Click);
            // 
            // ThirdLevel
            // 
            this.ThirdLevel.BackColor = System.Drawing.SystemColors.Highlight;
            this.ThirdLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThirdLevel.Location = new System.Drawing.Point(521, 79);
            this.ThirdLevel.Name = "ThirdLevel";
            this.ThirdLevel.Size = new System.Drawing.Size(130, 130);
            this.ThirdLevel.TabIndex = 5;
            this.ThirdLevel.Text = "3";
            this.ThirdLevel.UseVisualStyleBackColor = false;
            this.ThirdLevel.Click += new System.EventHandler(this.ThirdLevel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(116, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Лёгкий";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(122, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Средний";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(322, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Сложный";
            // 
            // FourthLevel
            // 
            this.FourthLevel.BackColor = System.Drawing.SystemColors.Highlight;
            this.FourthLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FourthLevel.Location = new System.Drawing.Point(122, 256);
            this.FourthLevel.Name = "FourthLevel";
            this.FourthLevel.Size = new System.Drawing.Size(130, 130);
            this.FourthLevel.TabIndex = 9;
            this.FourthLevel.Text = "4";
            this.FourthLevel.UseVisualStyleBackColor = false;
            this.FourthLevel.Click += new System.EventHandler(this.FourthLevel_Click);
            // 
            // FivethLevel
            // 
            this.FivethLevel.BackColor = System.Drawing.Color.DarkViolet;
            this.FivethLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FivethLevel.Location = new System.Drawing.Point(322, 256);
            this.FivethLevel.Name = "FivethLevel";
            this.FivethLevel.Size = new System.Drawing.Size(130, 130);
            this.FivethLevel.TabIndex = 10;
            this.FivethLevel.Text = "5";
            this.FivethLevel.UseVisualStyleBackColor = false;
            this.FivethLevel.Click += new System.EventHandler(this.FivethLevel_Click);
            // 
            // SixthLevel
            // 
            this.SixthLevel.BackColor = System.Drawing.Color.DarkViolet;
            this.SixthLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SixthLevel.Location = new System.Drawing.Point(521, 256);
            this.SixthLevel.Name = "SixthLevel";
            this.SixthLevel.Size = new System.Drawing.Size(130, 130);
            this.SixthLevel.TabIndex = 11;
            this.SixthLevel.Text = "6";
            this.SixthLevel.UseVisualStyleBackColor = false;
            this.SixthLevel.Click += new System.EventHandler(this.SixthLevel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(322, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 32);
            this.label5.TabIndex = 12;
            this.label5.Text = "Лёгкий";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(521, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 32);
            this.label6.TabIndex = 13;
            this.label6.Text = "Средний";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(521, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 32);
            this.label7.TabIndex = 14;
            this.label7.Text = "Сложный";
            // 
            // ChoiceLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SixthLevel);
            this.Controls.Add(this.FivethLevel);
            this.Controls.Add(this.FourthLevel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ThirdLevel);
            this.Controls.Add(this.SecondLevel);
            this.Controls.Add(this.FirstLevel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GoToMenu);
            this.Name = "ChoiceLevel";
            this.Text = "Выбор уровня";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GoToMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FirstLevel;
        private System.Windows.Forms.Button SecondLevel;
        private System.Windows.Forms.Button ThirdLevel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button FourthLevel;
        private System.Windows.Forms.Button FivethLevel;
        private System.Windows.Forms.Button SixthLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}