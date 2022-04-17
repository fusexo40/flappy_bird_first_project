namespace flappy_bird
{
    partial class Flappy_bird
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
            this.components = new System.ComponentModel.Container();
            this.Score_Text = new System.Windows.Forms.Label();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.floor = new System.Windows.Forms.PictureBox();
            this.game_timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            this.SuspendLayout();
            // 
            // Score_Text
            // 
            this.Score_Text.AutoSize = true;
            this.Score_Text.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Score_Text.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Score_Text.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Bold);
            this.Score_Text.Location = new System.Drawing.Point(12, 545);
            this.Score_Text.Name = "Score_Text";
            this.Score_Text.Size = new System.Drawing.Size(102, 26);
            this.Score_Text.TabIndex = 4;
            this.Score_Text.Text = "Score: 0";
            // 
            // pipeTop
            // 
            this.pipeTop.Image = global::flappy_bird.Properties.Resources.pipedown;
            this.pipeTop.Location = new System.Drawing.Point(485, -80);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(80, 240);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pipeTop.TabIndex = 3;
            this.pipeTop.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.Image = global::flappy_bird.Properties.Resources.pipe;
            this.pipeBottom.Location = new System.Drawing.Point(485, 358);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(80, 240);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pipeBottom.TabIndex = 2;
            this.pipeBottom.TabStop = false;
            // 
            // bird
            // 
            this.bird.Image = global::flappy_bird.Properties.Resources.bird;
            this.bird.Location = new System.Drawing.Point(39, 216);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(90, 64);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bird.TabIndex = 1;
            this.bird.TabStop = false;
            // 
            // floor
            // 
            this.floor.BackColor = System.Drawing.Color.Transparent;
            this.floor.Image = global::flappy_bird.Properties.Resources.ground;
            this.floor.Location = new System.Drawing.Point(-7, 513);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(698, 150);
            this.floor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.floor.TabIndex = 0;
            this.floor.TabStop = false;
            // 
            // game_timer
            // 
            this.game_timer.Enabled = true;
            this.game_timer.Interval = 20;
            this.game_timer.Tick += new System.EventHandler(this.Game_timer_ivent);
            // 
            // Flappy_bird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(686, 580);
            this.Controls.Add(this.Score_Text);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.floor);
            this.Controls.Add(this.pipeBottom);
            this.Name = "Flappy_bird";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Flappt bird game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Key_up);
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox floor;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.Label Score_Text;
        private System.Windows.Forms.Timer game_timer;
    }
}

