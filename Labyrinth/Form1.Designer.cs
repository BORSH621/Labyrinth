namespace Labyrinth
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Play = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.ChoiceLevel = new System.Windows.Forms.Button();
            this.AboutGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.Color.Lime;
            this.Play.Location = new System.Drawing.Point(301, 63);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(191, 66);
            this.Play.TabIndex = 1;
            this.Play.Text = "Играть";
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Red;
            this.Exit.Location = new System.Drawing.Point(301, 279);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(191, 66);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Выйти";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ChoiceLevel
            // 
            this.ChoiceLevel.BackColor = System.Drawing.Color.Lime;
            this.ChoiceLevel.Location = new System.Drawing.Point(301, 135);
            this.ChoiceLevel.Name = "ChoiceLevel";
            this.ChoiceLevel.Size = new System.Drawing.Size(191, 66);
            this.ChoiceLevel.TabIndex = 2;
            this.ChoiceLevel.Text = "Настройки";
            this.ChoiceLevel.UseVisualStyleBackColor = false;
            this.ChoiceLevel.Click += new System.EventHandler(this.ChoiceLevel_Click);
            // 
            // AboutGame
            // 
            this.AboutGame.BackColor = System.Drawing.Color.Lime;
            this.AboutGame.Location = new System.Drawing.Point(301, 207);
            this.AboutGame.Name = "AboutGame";
            this.AboutGame.Size = new System.Drawing.Size(191, 66);
            this.AboutGame.TabIndex = 3;
            this.AboutGame.Text = "Об игре";
            this.AboutGame.UseVisualStyleBackColor = false;
            this.AboutGame.Click += new System.EventHandler(this.AboutGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AboutGame);
            this.Controls.Add(this.ChoiceLevel);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Play);
            this.Name = "Form1";
            this.Text = "Лабиринт";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button ChoiceLevel;
        private System.Windows.Forms.Button AboutGame;
    }
}

