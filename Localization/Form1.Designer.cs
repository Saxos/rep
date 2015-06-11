namespace Localization
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
            this.label1 = new System.Windows.Forms.Label();
            this.artNrTextField = new System.Windows.Forms.TextBox();
            this.mengeTextField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kdNrTextField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTextField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ProductID";
            // 
            // artNrTextField
            // 
            this.artNrTextField.Location = new System.Drawing.Point(105, 30);
            this.artNrTextField.Name = "artNrTextField";
            this.artNrTextField.Size = new System.Drawing.Size(283, 20);
            this.artNrTextField.TabIndex = 1;
            // 
            // mengeTextField
            // 
            this.mengeTextField.Location = new System.Drawing.Point(105, 67);
            this.mengeTextField.Name = "mengeTextField";
            this.mengeTextField.Size = new System.Drawing.Size(283, 20);
            this.mengeTextField.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantity";
            // 
            // kdNrTextField
            // 
            this.kdNrTextField.Location = new System.Drawing.Point(105, 108);
            this.kdNrTextField.Name = "kdNrTextField";
            this.kdNrTextField.Size = new System.Drawing.Size(283, 20);
            this.kdNrTextField.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CustomerID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dateTextField
            // 
            this.dateTextField.Location = new System.Drawing.Point(105, 153);
            this.dateTextField.Name = "dateTextField";
            this.dateTextField.Size = new System.Drawing.Size(283, 20);
            this.dateTextField.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(359, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 376);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(483, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 398);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTextField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.kdNrTextField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mengeTextField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.artNrTextField);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox artNrTextField;
        private System.Windows.Forms.TextBox mengeTextField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kdNrTextField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dateTextField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

