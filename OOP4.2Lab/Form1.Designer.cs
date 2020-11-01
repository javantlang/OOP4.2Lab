namespace OOP4._2Lab
{
    partial class View
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
            this.numericNumb1 = new System.Windows.Forms.NumericUpDown();
            this.txtboxNumb1 = new System.Windows.Forms.TextBox();
            this.numericNumb2 = new System.Windows.Forms.NumericUpDown();
            this.txtboxNumb2 = new System.Windows.Forms.TextBox();
            this.richtxtboxNumb1 = new System.Windows.Forms.RichTextBox();
            this.richtxtboxNumb2 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumb2)).BeginInit();
            this.SuspendLayout();
            // 
            // numericNumb1
            // 
            this.numericNumb1.Location = new System.Drawing.Point(13, 13);
            this.numericNumb1.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericNumb1.Name = "numericNumb1";
            this.numericNumb1.Size = new System.Drawing.Size(120, 20);
            this.numericNumb1.TabIndex = 0;
            this.numericNumb1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericNumb1.ValueChanged += new System.EventHandler(this.numericNumb1_ValueChanged);
            // 
            // txtboxNumb1
            // 
            this.txtboxNumb1.Location = new System.Drawing.Point(13, 40);
            this.txtboxNumb1.Name = "txtboxNumb1";
            this.txtboxNumb1.Size = new System.Drawing.Size(120, 20);
            this.txtboxNumb1.TabIndex = 1;
            this.txtboxNumb1.Text = "1";
            this.txtboxNumb1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtboxNumb1_KeyDown);
            // 
            // numericNumb2
            // 
            this.numericNumb2.Location = new System.Drawing.Point(219, 13);
            this.numericNumb2.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericNumb2.Name = "numericNumb2";
            this.numericNumb2.Size = new System.Drawing.Size(120, 20);
            this.numericNumb2.TabIndex = 2;
            this.numericNumb2.ValueChanged += new System.EventHandler(this.numericNumb2_ValueChanged);
            // 
            // txtboxNumb2
            // 
            this.txtboxNumb2.Location = new System.Drawing.Point(219, 39);
            this.txtboxNumb2.Name = "txtboxNumb2";
            this.txtboxNumb2.Size = new System.Drawing.Size(120, 20);
            this.txtboxNumb2.TabIndex = 3;
            this.txtboxNumb2.Text = "0";
            this.txtboxNumb2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtboxNumb2_KeyDown);
            // 
            // richtxtboxNumb1
            // 
            this.richtxtboxNumb1.Location = new System.Drawing.Point(13, 67);
            this.richtxtboxNumb1.Name = "richtxtboxNumb1";
            this.richtxtboxNumb1.Size = new System.Drawing.Size(120, 36);
            this.richtxtboxNumb1.TabIndex = 4;
            this.richtxtboxNumb1.Text = "1";
            this.richtxtboxNumb1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richtxtboxNumb1_KeyDown);
            // 
            // richtxtboxNumb2
            // 
            this.richtxtboxNumb2.Location = new System.Drawing.Point(219, 67);
            this.richtxtboxNumb2.Name = "richtxtboxNumb2";
            this.richtxtboxNumb2.Size = new System.Drawing.Size(120, 36);
            this.richtxtboxNumb2.TabIndex = 5;
            this.richtxtboxNumb2.Text = "0";
            this.richtxtboxNumb2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richtxtboxNumb2_KeyDown);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 582);
            this.Controls.Add(this.richtxtboxNumb2);
            this.Controls.Add(this.richtxtboxNumb1);
            this.Controls.Add(this.txtboxNumb2);
            this.Controls.Add(this.numericNumb2);
            this.Controls.Add(this.txtboxNumb1);
            this.Controls.Add(this.numericNumb1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "View";
            this.Text = "View";
            ((System.ComponentModel.ISupportInitialize)(this.numericNumb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumb2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericNumb1;
        private System.Windows.Forms.TextBox txtboxNumb1;
        private System.Windows.Forms.NumericUpDown numericNumb2;
        private System.Windows.Forms.TextBox txtboxNumb2;
        private System.Windows.Forms.RichTextBox richtxtboxNumb1;
        private System.Windows.Forms.RichTextBox richtxtboxNumb2;
    }
}

