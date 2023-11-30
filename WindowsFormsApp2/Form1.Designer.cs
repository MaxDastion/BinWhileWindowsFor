namespace WindowsFormsApp2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TrashBack = new System.Windows.Forms.PictureBox();
            this.TimerTrashback = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TimerBottles = new System.Windows.Forms.Timer(this.components);
            this.Points = new System.Windows.Forms.Label();
            this.OpenBin = new System.Windows.Forms.PictureBox();
            this.BoxMenu = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TrashBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenBin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // TrashBack
            // 
            this.TrashBack.BackColor = System.Drawing.Color.Transparent;
            this.TrashBack.Image = ((System.Drawing.Image)(resources.GetObject("TrashBack.Image")));
            this.TrashBack.Location = new System.Drawing.Point(1, 349);
            this.TrashBack.Name = "TrashBack";
            this.TrashBack.Size = new System.Drawing.Size(100, 100);
            this.TrashBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TrashBack.TabIndex = 0;
            this.TrashBack.TabStop = false;
            this.TrashBack.WaitOnLoad = true;
            // 
            // TimerTrashback
            // 
            this.TimerTrashback.Interval = 50;
            this.TimerTrashback.Tick += new System.EventHandler(this.MoveTrashbackivent);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // TimerBottles
            // 
            this.TimerBottles.Interval = 1000;
            this.TimerBottles.Tick += new System.EventHandler(this.EventTimerBottle);
            // 
            // Points
            // 
            this.Points.AutoSize = true;
            this.Points.BackColor = System.Drawing.Color.Transparent;
            this.Points.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Points.Location = new System.Drawing.Point(12, 9);
            this.Points.Name = "Points";
            this.Points.Size = new System.Drawing.Size(0, 13);
            this.Points.TabIndex = 2;
            // 
            // OpenBin
            // 
            this.OpenBin.BackColor = System.Drawing.Color.Transparent;
            this.OpenBin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OpenBin.Image = ((System.Drawing.Image)(resources.GetObject("OpenBin.Image")));
            this.OpenBin.Location = new System.Drawing.Point(117, 287);
            this.OpenBin.Name = "OpenBin";
            this.OpenBin.Size = new System.Drawing.Size(100, 100);
            this.OpenBin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OpenBin.TabIndex = 3;
            this.OpenBin.TabStop = false;
            this.OpenBin.Visible = false;
            // 
            // BoxMenu
            // 
            this.BoxMenu.BackColor = System.Drawing.Color.Transparent;
            this.BoxMenu.Location = new System.Drawing.Point(0, 0);
            this.BoxMenu.Name = "BoxMenu";
            this.BoxMenu.Size = new System.Drawing.Size(805, 449);
            this.BoxMenu.TabIndex = 4;
            this.BoxMenu.TabStop = false;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.CausesValidation = false;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.ImageKey = "(отсутствует)";
            this.button1.Location = new System.Drawing.Point(200, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(382, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Start game";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BoxMenu);
            this.Controls.Add(this.OpenBin);
            this.Controls.Add(this.TrashBack);
            this.Controls.Add(this.Points);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyisDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyisUp);
            this.Resize += new System.EventHandler(this.ResizeEvent);
            ((System.ComponentModel.ISupportInitialize)(this.TrashBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenBin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TrashBack;
        private System.Windows.Forms.Timer TimerTrashback;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer TimerBottles;
        private System.Windows.Forms.Label Points;
        private System.Windows.Forms.PictureBox BoxMenu;
        private System.Windows.Forms.PictureBox OpenBin;
        private System.Windows.Forms.Button button1;
    }
}

