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
            ((System.ComponentModel.ISupportInitialize)(this.TrashBack)).BeginInit();
            this.SuspendLayout();
            // 
            // TrashBack
            // 
            this.TrashBack.Image = ((System.Drawing.Image)(resources.GetObject("TrashBack.Image")));
            this.TrashBack.Location = new System.Drawing.Point(1, 350);
            this.TrashBack.Name = "TrashBack";
            this.TrashBack.Size = new System.Drawing.Size(100, 100);
            this.TrashBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TrashBack.TabIndex = 0;
            this.TrashBack.TabStop = false;
            // 
            // TimerTrashback
            // 
            this.TimerTrashback.Enabled = true;
            this.TimerTrashback.Tick += new System.EventHandler(this.MoveTrashbackivent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TrashBack);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyisDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyisUp);
            this.Resize += new System.EventHandler(this.ResizeEvent);
            ((System.ComponentModel.ISupportInitialize)(this.TrashBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox TrashBack;
        private System.Windows.Forms.Timer TimerTrashback;
    }
}

