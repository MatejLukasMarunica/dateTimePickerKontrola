namespace dateTimePickerkontrola
{
    partial class Form1
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
            this.dateTimePickerDatum = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerVrijeme = new System.Windows.Forms.DateTimePicker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonrezervacija = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePickerDatum
            // 
            this.dateTimePickerDatum.Location = new System.Drawing.Point(164, 37);
            this.dateTimePickerDatum.Name = "dateTimePickerDatum";
            this.dateTimePickerDatum.Size = new System.Drawing.Size(207, 20);
            this.dateTimePickerDatum.TabIndex = 0;
            this.dateTimePickerDatum.ValueChanged += new System.EventHandler(this.dateTimePickerDatum_ValueChanged);
            // 
            // dateTimePickerVrijeme
            // 
            this.dateTimePickerVrijeme.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerVrijeme.Location = new System.Drawing.Point(164, 115);
            this.dateTimePickerVrijeme.Name = "dateTimePickerVrijeme";
            this.dateTimePickerVrijeme.ShowUpDown = true;
            this.dateTimePickerVrijeme.Size = new System.Drawing.Size(207, 20);
            this.dateTimePickerVrijeme.TabIndex = 1;
            this.dateTimePickerVrijeme.ValueChanged += new System.EventHandler(this.dateTimePickerVrijeme_ValueChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(116, 191);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(255, 96);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // buttonrezervacija
            // 
            this.buttonrezervacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonrezervacija.Location = new System.Drawing.Point(116, 321);
            this.buttonrezervacija.Name = "buttonrezervacija";
            this.buttonrezervacija.Size = new System.Drawing.Size(109, 43);
            this.buttonrezervacija.TabIndex = 3;
            this.buttonrezervacija.Text = "Rezerviraj";
            this.buttonrezervacija.UseVisualStyleBackColor = true;
            this.buttonrezervacija.Click += new System.EventHandler(this.buttonrezervacija_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(40, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Upišite datum leta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(21, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Upišite vrijeme polaska:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 419);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonrezervacija);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dateTimePickerVrijeme);
            this.Controls.Add(this.dateTimePickerDatum);
            this.Name = "Form1";
            this.Text = "Upotreba DateTimePicker Kontrola";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerDatum;
        private System.Windows.Forms.DateTimePicker dateTimePickerVrijeme;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonrezervacija;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

