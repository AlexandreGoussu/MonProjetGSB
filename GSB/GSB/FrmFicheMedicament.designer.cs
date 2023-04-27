
namespace GSB
{
    partial class FrmFicheMedicament
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lesMedicaments = new System.Windows.Forms.ComboBox();
            this.familleMedoc = new System.Windows.Forms.TextBox();
            this.compoMedoc = new System.Windows.Forms.TextBox();
            this.contreIndicMedoc = new System.Windows.Forms.TextBox();
            this.effetMedoc = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTitre.Size = new System.Drawing.Size(936, 64);
            this.lblTitre.Text = "Fiche médicament";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lesMedicaments);
            this.panel2.Controls.Add(this.familleMedoc);
            this.panel2.Controls.Add(this.compoMedoc);
            this.panel2.Controls.Add(this.contreIndicMedoc);
            this.panel2.Controls.Add(this.effetMedoc);
            this.panel2.Location = new System.Drawing.Point(6, 82);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(924, 413);
            this.panel2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 336);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Contre indication";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 201);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Effet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Composition";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Famille";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Médicament recherché";
            // 
            // lesMedicaments
            // 
            this.lesMedicaments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lesMedicaments.FormattingEnabled = true;
            this.lesMedicaments.Location = new System.Drawing.Point(156, 16);
            this.lesMedicaments.Margin = new System.Windows.Forms.Padding(2);
            this.lesMedicaments.Name = "lesMedicaments";
            this.lesMedicaments.Size = new System.Drawing.Size(195, 21);
            this.lesMedicaments.TabIndex = 19;
            this.lesMedicaments.SelectedIndexChanged += new System.EventHandler(this.lesMedicaments_SelectedIndexChanged);
            // 
            // familleMedoc
            // 
            this.familleMedoc.Location = new System.Drawing.Point(28, 62);
            this.familleMedoc.Margin = new System.Windows.Forms.Padding(2);
            this.familleMedoc.Multiline = true;
            this.familleMedoc.Name = "familleMedoc";
            this.familleMedoc.Size = new System.Drawing.Size(864, 31);
            this.familleMedoc.TabIndex = 20;
            // 
            // compoMedoc
            // 
            this.compoMedoc.Location = new System.Drawing.Point(28, 120);
            this.compoMedoc.Margin = new System.Windows.Forms.Padding(2);
            this.compoMedoc.Multiline = true;
            this.compoMedoc.Name = "compoMedoc";
            this.compoMedoc.Size = new System.Drawing.Size(864, 68);
            this.compoMedoc.TabIndex = 22;
            // 
            // contreIndicMedoc
            // 
            this.contreIndicMedoc.Location = new System.Drawing.Point(28, 355);
            this.contreIndicMedoc.Margin = new System.Windows.Forms.Padding(2);
            this.contreIndicMedoc.Multiline = true;
            this.contreIndicMedoc.Name = "contreIndicMedoc";
            this.contreIndicMedoc.Size = new System.Drawing.Size(866, 55);
            this.contreIndicMedoc.TabIndex = 23;
            // 
            // effetMedoc
            // 
            this.effetMedoc.Location = new System.Drawing.Point(28, 222);
            this.effetMedoc.Margin = new System.Windows.Forms.Padding(2);
            this.effetMedoc.Multiline = true;
            this.effetMedoc.Name = "effetMedoc";
            this.effetMedoc.Size = new System.Drawing.Size(866, 94);
            this.effetMedoc.TabIndex = 21;
            // 
            // FrmFicheMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 534);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "FrmFicheMedicament";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFicheMedicament";
            this.Load += new System.EventHandler(this.FrmFicheMedicament_Load);
            this.Controls.SetChildIndex(this.lblTitre, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox lesMedicaments;
        private System.Windows.Forms.TextBox familleMedoc;
        private System.Windows.Forms.TextBox compoMedoc;
        private System.Windows.Forms.TextBox contreIndicMedoc;
        private System.Windows.Forms.TextBox effetMedoc;
    }
}