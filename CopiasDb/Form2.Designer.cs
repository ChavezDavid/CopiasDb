namespace CopiasDb
{
    partial class Form2
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
            this.btnSelectCopiaAlumno = new System.Windows.Forms.Button();
            this.lstCopiaAlumno = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSelectCopiaAlumno
            // 
            this.btnSelectCopiaAlumno.Location = new System.Drawing.Point(353, 12);
            this.btnSelectCopiaAlumno.Name = "btnSelectCopiaAlumno";
            this.btnSelectCopiaAlumno.Size = new System.Drawing.Size(75, 23);
            this.btnSelectCopiaAlumno.TabIndex = 5;
            this.btnSelectCopiaAlumno.Text = "Buscar";
            this.btnSelectCopiaAlumno.UseVisualStyleBackColor = true;
            this.btnSelectCopiaAlumno.Click += new System.EventHandler(this.btnSelectCopiaAlumno_Click);
            // 
            // lstCopiaAlumno
            // 
            this.lstCopiaAlumno.FormattingEnabled = true;
            this.lstCopiaAlumno.Location = new System.Drawing.Point(12, 12);
            this.lstCopiaAlumno.Name = "lstCopiaAlumno";
            this.lstCopiaAlumno.Size = new System.Drawing.Size(335, 212);
            this.lstCopiaAlumno.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstCopiaAlumno);
            this.Controls.Add(this.btnSelectCopiaAlumno);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSelectCopiaAlumno;
        private System.Windows.Forms.ListBox lstCopiaAlumno;
    }
}