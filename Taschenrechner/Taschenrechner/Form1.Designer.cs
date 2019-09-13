namespace Taschenrechner
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxZahl1 = new System.Windows.Forms.TextBox();
            this.lblZahl1 = new System.Windows.Forms.Label();
            this.lblZahl2 = new System.Windows.Forms.Label();
            this.tbxZahl2 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.tbxErgebniss = new System.Windows.Forms.TextBox();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxZahl1
            // 
            this.tbxZahl1.Location = new System.Drawing.Point(15, 29);
            this.tbxZahl1.Name = "tbxZahl1";
            this.tbxZahl1.Size = new System.Drawing.Size(100, 22);
            this.tbxZahl1.TabIndex = 0;
            this.tbxZahl1.TextChanged += new System.EventHandler(this.tbxZahl1_TextChanged);
            // 
            // lblZahl1
            // 
            this.lblZahl1.AutoSize = true;
            this.lblZahl1.Location = new System.Drawing.Point(12, 9);
            this.lblZahl1.Name = "lblZahl1";
            this.lblZahl1.Size = new System.Drawing.Size(44, 17);
            this.lblZahl1.TabIndex = 1;
            this.lblZahl1.Text = "Zahl1";
            // 
            // lblZahl2
            // 
            this.lblZahl2.AutoSize = true;
            this.lblZahl2.Location = new System.Drawing.Point(12, 64);
            this.lblZahl2.Name = "lblZahl2";
            this.lblZahl2.Size = new System.Drawing.Size(44, 17);
            this.lblZahl2.TabIndex = 2;
            this.lblZahl2.Text = "Zahl2";
            // 
            // tbxZahl2
            // 
            this.tbxZahl2.Location = new System.Drawing.Point(15, 84);
            this.tbxZahl2.Name = "tbxZahl2";
            this.tbxZahl2.Size = new System.Drawing.Size(100, 22);
            this.tbxZahl2.TabIndex = 3;
            this.tbxZahl2.TextChanged += new System.EventHandler(this.TbxZahl2_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 141);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(96, 141);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(75, 23);
            this.btnSub.TabIndex = 5;
            this.btnSub.Text = "Sub";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.BtnSub_Click);
            // 
            // tbxErgebniss
            // 
            this.tbxErgebniss.Location = new System.Drawing.Point(152, 59);
            this.tbxErgebniss.Name = "tbxErgebniss";
            this.tbxErgebniss.Size = new System.Drawing.Size(100, 22);
            this.tbxErgebniss.TabIndex = 6;
            this.tbxErgebniss.Text = "Ergebnis";
            this.tbxErgebniss.TextChanged += new System.EventHandler(this.tbxErgebniss_TextChanged);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(258, 141);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(75, 23);
            this.btnDiv.TabIndex = 7;
            this.btnDiv.Text = "Div";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.BtnDiv_Click);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(177, 141);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(75, 23);
            this.btnMult.TabIndex = 8;
            this.btnMult.Text = "Mult";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.BtnMult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.tbxErgebniss);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbxZahl2);
            this.Controls.Add(this.lblZahl2);
            this.Controls.Add(this.lblZahl1);
            this.Controls.Add(this.tbxZahl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxZahl1;
        private System.Windows.Forms.Label lblZahl1;
        private System.Windows.Forms.Label lblZahl2;
        private System.Windows.Forms.TextBox tbxZahl2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.TextBox tbxErgebniss;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnMult;
    }
}

